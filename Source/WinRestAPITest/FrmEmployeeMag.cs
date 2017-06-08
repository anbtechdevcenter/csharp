using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using AnBTech.RestAPI.VO;

namespace AnBTech.RestAPI
{

    /// <summary>
    /// 사원정보 관리 UI
    /// </summary>
    public partial class FrmEmployeeMag : Form
    {
        public FrmEmployeeMag()
        {
            InitializeComponent();
        }

        readonly string API_EMPLOYEE_URL = "/api/employee";
        readonly string API_RANK_URL = "/api/rank";
        readonly string API_PROJECT_URL = "/api/project";
        readonly string API_CODE_COMMON_URL = "/api/codeCommon";

        List<EmployeeVO> _lstEmployeeTotal;
        List<RankVO> _lstRank;
        List<ProjectVO> _lstProject;
        List<string> _lstTeam;
        List<CommonCodeVO> _lstCodeCommon;

        private void FrmEmployeeMag_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        private void InitControl()
        {
            //공통 코드 ( 근무지역 초기화 )
            _lstCodeCommon = ANBTX_Common.GetCodeCommon(API_CODE_COMMON_URL);

            // 직원이름 초기화.
            _lstEmployeeTotal = ANBTX_Common.GetEmployee(API_EMPLOYEE_URL);
            var lstEmpName = _lstEmployeeTotal.Select(o => o.empNm).ToList().Where(o => !string.IsNullOrEmpty(o)).ToList();
            ANBTX_Common.SetComboBox(cboEmployeeName, lstEmpName);


            // 부서명 초기화.
            _lstTeam = _lstEmployeeTotal.Select(o => o.team).ToList().Where(o => !string.IsNullOrEmpty(o)).Distinct().ToList();
            ANBTX_Common.SetComboBox(cboTeamName, _lstTeam);


            // 프로젝트명 초기화.
            _lstProject = ANBTX_Common.GetProject(API_PROJECT_URL);
            var lstProject = _lstProject.Select(o => o.prjNm).Where(o => !string.IsNullOrEmpty(o)).Distinct().ToList();
            ANBTX_Common.SetComboBox(cboProjectName, lstProject);


            // 직급 초기화.
            _lstRank = ANBTX_Common.GetRank(API_RANK_URL);
            var lstRank = _lstRank.Select(o => o.rankName).ToList();
            ANBTX_Common.SetComboBox(cboRank, lstRank);


            // 기간 초기화.
            this.dtpkFrom.Value = DateTime.Today.AddDays(-30); ;
            this.dtpkTo.Value = DateTime.Now;
        }

        /// <summary>
        /// 검색조건에 설정된 정보로 직원정보에서 필터링하여 결과 화면에 보여줍니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var lstEmp = new List<EmployeeVO>();
            var lstlstEmpId = new List<List<string>>();

            // 부서명 필터
            var strFilter = cboTeamName.Text;
            if (!string.IsNullOrEmpty(strFilter) && !strFilter.ToUpper().Contains("NONE"))
            {
                lstlstEmpId.Add(_lstEmployeeTotal.Where(o => o.team != null && o.team.Equals(strFilter))
                                                 .Select(o => o.empId).ToList());
            }


            // 직급 필터
            strFilter = cboRank.Text;
            if (!string.IsNullOrEmpty(strFilter) && !strFilter.ToUpper().Contains("NONE"))
            {
                lstlstEmpId.Add(_lstEmployeeTotal.Where(o => o.rank != null && o.rank.rankName != null && o.rank.rankName.Equals(strFilter))
                                                 .Select(o => o.empId).ToList());
            }


            // 사원명 필터
            strFilter = cboEmployeeName.Text;
            if (!string.IsNullOrEmpty(strFilter) && !strFilter.ToUpper().Contains("NONE"))
            {
                lstlstEmpId.Add(_lstEmployeeTotal.Where(o => o.empNm != null && o.empNm.Equals(strFilter))
                                                 .Select(o => o.empId).ToList());
            }


            // 프로젝트명 필터
            strFilter = cboProjectName.Text;
            if (!string.IsNullOrEmpty(strFilter) && !strFilter.ToUpper().Contains("NONE"))
            {
                lstlstEmpId.Add(_lstEmployeeTotal.Where(o => (o.project != null && o.project.prjNm != null && o.project.prjNm.Equals(strFilter)))
                                                 .Select(o => o.empId).ToList());
            }


            // 사원분류 필터.
            var isContract = chkContractEmployee.Checked;
            var isPermanent = chkPermanentEmployee.Checked;
            var lsttemp = new List<string>();

            if (isContract)
            {
                lsttemp.AddRange(_lstEmployeeTotal.Where(o => o.empFlag != null && o.empFlag.Equals("0")).Select(o => o.empId).ToList());
            }

            if (isPermanent)
            {
                lsttemp.AddRange(_lstEmployeeTotal.Where(o => o.empFlag != null && o.empFlag.Equals("1")).Select(o => o.empId).ToList());
            }

            if (isContract || isPermanent) lstlstEmpId.Add(lsttemp);


            // todo :
            var lstDateFilter = new List<string>();

            lstDateFilter.AddRange(_lstEmployeeTotal
                 .Where(o => o.empNm != null )
                 .Select(o => o.empId).ToList());

            lstlstEmpId.Add(lstDateFilter);

            // null인 filter가 없고, count가 0인게 없는지 체크.
            if (lstlstEmpId.Count > 0 &&
                !lstlstEmpId.Contains(null) &&
                !lstlstEmpId.Where(o => o != null && o.Count == 0).Any())
            {
                foreach (var strEmpId in lstlstEmpId[0])
                {
                    var iscontain = true;

                    for (var nCnt = 1; nCnt < lstlstEmpId.Count; nCnt++)
                    {
                        if (!lstlstEmpId[nCnt].Contains(strEmpId))
                        {
                            iscontain = false;
                            break;
                        }
                    }

                    if (iscontain)
                    {
                        lstEmp.Add(_lstEmployeeTotal.Where(o => o.empId.Equals(strEmpId)).FirstOrDefault());
                    }
                }

                lstEmp = lstEmp.Where(o => o != null).ToList();
            }

            // grid에 바인딩 한다.
            var dt = new DataTable("Result");
            dt.Columns.Add("No.", typeof(int));
            dt.Columns.Add("사번", typeof(string));
            dt.Columns.Add("성명", typeof(string));
            dt.Columns.Add("부서", typeof(string));
            dt.Columns.Add("직급", typeof(string));
            dt.Columns.Add("구분", typeof(string));
            dt.Columns.Add("입사일", typeof(DateTime));
            dt.Columns.Add("등록일", typeof(DateTime));
            dt.Columns.Add("비고", typeof(string));

            if (lstEmp.Count > 0)
            {
                if (gridResult.Rows.Count > 0) gridResult.DataSource = null;

                dt.BeginLoadData();
                var nCnt = 1;
                foreach (var emp in lstEmp)
                {
                    var newDr = dt.NewRow();
                    newDr.ItemArray = new object[] { nCnt, emp.empId, emp.empNm, emp.team, emp.rank.rankName, emp.empFlag, emp.enteringDate, emp.registDste, emp.userInfo };
                    dt.Rows.Add(newDr);
                    nCnt++;
                }
                dt.EndLoadData();
                 
                dt.AcceptChanges();

                gridResult.DataSource = dt;
            }
            else
            {
                if (lstlstEmpId.Count == 0)
                {
                    if (gridResult.Rows.Count > 0) gridResult.DataSource = null;


                    dt.BeginLoadData();
                    var nCnt = 1;
                    foreach (var emp in _lstEmployeeTotal)
                    {
                        var newDr = dt.NewRow();
                        newDr.ItemArray = new object[] { nCnt, emp.empId, emp.empNm, emp.team, emp.rank.rankName, emp.empFlag, emp.enteringDate, emp.registDste, emp.userInfo };
                        dt.Rows.Add(newDr);
                        nCnt++;
                    }
                    dt.EndLoadData();

                    dt.AcceptChanges();

                    gridResult.DataSource = dt;
                }
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            // 신규 사원 입력 UI 생성.
            var frmEmpSetting = new FrmEmployeeSetting();
            frmEmpSetting.IsNewEmployee = true;
            frmEmpSetting.RankInfo = _lstRank;
            frmEmpSetting.TeamInfo = _lstTeam;
            frmEmpSetting.ProjectInfo = _lstProject;
            frmEmpSetting.CodeInfo = _lstCodeCommon;

            if (frmEmpSetting.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // UI 결과가 등록/수정 인경우 직원 정보 갱신하여 화면에 뿌려줌. 취소는 작업없음.
                InitControl();
                btnSearch_Click(null, null);
            }

        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empId = gridResult.SelectedRows[0].Cells[1].Value.ToString();

            var emp = _lstEmployeeTotal.Where(o => o.empId.Equals(empId)).FirstOrDefault();

            if (emp != null)
            {
                // 신규 사원 입력 UI 생성.
                var frmEmpSetting = new FrmEmployeeSetting();
                frmEmpSetting.IsNewEmployee = false;
                frmEmpSetting.RankInfo = _lstRank;
                frmEmpSetting.TeamInfo = _lstTeam;
                frmEmpSetting.ProjectInfo = _lstProject;
                frmEmpSetting.UpdateEmployee = emp;

                if (frmEmpSetting.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    InitControl();
                    btnSearch_Click(null, null);
                }
            }
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // delete
            var empId = gridResult.SelectedRows[0].Cells[1].Value.ToString();

            var emp = _lstEmployeeTotal.Where(o => o.empId.Equals(empId)).FirstOrDefault();

            if (MessageBox.Show(string.Format("이름 : {0}, 직급 : {1} \r\n 삭제하시겠습니까?", emp.empNm, emp.rank.rankName), string.Empty, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                ANBTX.Delete(API_EMPLOYEE_URL, empId);
                InitControl();
                btnSearch_Click(null, null);
            }
        }
    }
}
