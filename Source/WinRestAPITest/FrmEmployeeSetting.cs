using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnBTech.RestAPI
{
    public partial class FrmEmployeeSetting : Form
    {
        public FrmEmployeeSetting()
        {
            InitializeComponent();
        }

        public bool IsNewEmployee { get; set; }
        public EmployeeVO UpdateEmployee { internal get; set; }
        public List<RankVO> RankInfo { internal get; set; }
        public List<string> TeamInfo { internal get; set; }
        public List<ProjectVO> ProjectInfo { internal get; set; }


        private void FrmEmployeeSetting_Load(object sender, EventArgs e)
        {

            // 부서명 초기화.
            if (TeamInfo != null)
            {
                this.SetComboBox(cboTeamName, TeamInfo);
            }

            // 직급 초기화.
            if (RankInfo != null)
            {
                this.SetComboBox(cboRank, RankInfo.Select(o => o.rankName).ToList());
            }

            // 프로젝트 초기화
            if (ProjectInfo != null)
            {
                this.SetComboBox(cboProject, ProjectInfo.Select(o => o.prjNm).ToList());
            }

            // 구분 초기화.
            cboEmployeeType.Items.Add("[None]");
            cboEmployeeType.Items.Add("정규직");
            cboEmployeeType.Items.Add("계약직");
            cboEmployeeType.SelectedIndex = 1;

            // 이메일 주소 초기화
            cboEmailAddr.Items.Add("[None]");
            cboEmailAddr.Items.Add("gmail.com");
            cboEmailAddr.Items.Add("naver.com");
            cboEmailAddr.Items.Add("anbtech.co.kr");
            cboEmailAddr.Items.Add("직접입력");
            cboEmailAddr.SelectedIndex = 1;

            // 생일 구분
            cboEmployeeBrithState.Items.Add("[None]");
            cboEmployeeBrithState.Items.Add("양력");
            cboEmployeeBrithState.Items.Add("음력");
            cboEmployeeBrithState.SelectedIndex = 1;

            // 퇴사 구분
            cboEmployeeLeaveType.Items.Add("[None]");
            cboEmployeeLeaveType.Items.Add("근무중");
            cboEmployeeLeaveType.Items.Add("퇴사");
            cboEmployeeLeaveType.SelectedIndex = 1;

            // 결혼유무 구분
            cboEmployeeMaritalState.Items.Add("[None]");
            cboEmployeeMaritalState.Items.Add("미혼");
            cboEmployeeMaritalState.Items.Add("기혼");
            cboEmployeeMaritalState.SelectedIndex = 1;

            cboRank.SelectedIndex = 1;
            cboTeamName.SelectedIndex = 1;
            cboProject.SelectedIndex = 1;

            if (IsNewEmployee)
            {
                btnUpdate.Enabled = false;
                btnCreate.Enabled = true;
                //dateTimePicker1.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnCreate.Enabled = false;
                //dateTimePicker1.Enabled = false;
            }

            if (UpdateEmployee != null)
            {

                // empType bind
                var nIndex = UpdateEmployee.empFlag == null ? 0 : UpdateEmployee.empFlag.Equals("정규직") ? 1 : 2;
                cboEmployeeType.SelectedIndex = nIndex;

                // rank bind
                var lstRank = RankInfo.Select(o => o.rankName).ToList();
                nIndex = UpdateEmployee.rank == null ? 0 : lstRank.IndexOf(UpdateEmployee.rank.rankName);
                cboRank.SelectedIndex = nIndex + 1;

                // team name bind
                nIndex = string.IsNullOrEmpty(UpdateEmployee.team) ? 0 : TeamInfo.IndexOf(UpdateEmployee.team);
                cboTeamName.SelectedIndex = nIndex + 1;

                // project name bind
                var lstProject = ProjectInfo.Select(o => o.prjNm).ToList();
                nIndex = UpdateEmployee.project == null ? 0 : lstProject.IndexOf(UpdateEmployee.project.prjNm);
                cboProject.SelectedIndex = nIndex + 1;

                // name bind.
                txtEmployeeName.Text = UpdateEmployee.empNm;

                // eng name bind
                txtEmployeeEngName.Text = UpdateEmployee.empEngNm;

                // tel bind
                txtEmployeeTel.Text = UpdateEmployee.empTel;

                // hand phone number bind
                txtEmployeeHtel.Text = UpdateEmployee.empHp;

                // zip code bind
                txtEmployeeZip.Text = UpdateEmployee.empZip;

                // address bind
                txtEmployeeAddr.Text = UpdateEmployee.empAddr;

                // address detail bind
                txtEmployeeAddrDtl.Text = UpdateEmployee.empAddrDtl;

                // brith day type bind
                cboEmployeeBrithState.Text = UpdateEmployee.birthState;

                // brith day bind
                employeeBirthDate.Text = UpdateEmployee.birthDate;

                // leave day bind
                employeeLeaveDate.Text = UpdateEmployee.leaveDate != null ? UpdateEmployee.leaveDate : null;

                // leave day type bind
                cboEmployeeLeaveType.Text = UpdateEmployee.leaveDate != null ? "퇴사" : "근무중";

                // emp zip code bind
                txtEmployeeZip.Text = UpdateEmployee.empZip;

                // emp addr bind
                txtEmployeeAddr.Text = UpdateEmployee.empAddr;

                // emp addr detail bind
                txtEmployeeAddrDtl.Text = UpdateEmployee.empAddrDtl;

                // email bind.
                string emailSplit = UpdateEmployee.email;
                string[] emailSplitWord = { "@" };
                string[] emails = emailSplit.Split(emailSplitWord, StringSplitOptions.RemoveEmptyEntries);
                txtEmailFirst.Text = emails[0];
                cboEmailAddr.Text = emails[1];

                // marital type bind
                cboEmployeeMaritalState.Text = UpdateEmployee.maritalState == "true" ? "기혼" : "미혼";

                // marital day bind
                employeeMarital_date.Text = UpdateEmployee.maritalDate;

                // 날짜 추가.
            }

        }

        /// <summary>
        /// 지정된 콤보박스에 데이터를 입력합니다.
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="lstValue"></param>
        /// <param name="isAscending"></param>
        private void SetComboBox(ComboBox combo, List<string> lstValue, bool isAscending = true)
        {
            if (lstValue.Any())
            {
                lstValue.OrderBy(o => o);
                combo.Items.Add("[None]");
                combo.Items.AddRange(lstValue.ToArray());
                combo.SelectedIndex = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployee.empNm = txtEmployeeName.Text;
            UpdateEmployee.empEngNm = txtEmployeeEngName.Text;
            UpdateEmployee.rank = RankInfo.Where(o => o.rankName.Equals(cboRank.Text)).First();
            UpdateEmployee.empFlag = cboEmployeeType.Text;
            UpdateEmployee.team = cboTeamName.Text;
            UpdateEmployee.email = txtEmailFirst + "@" + cboEmailAddr.Text;
            UpdateEmployee.empTel = txtEmployeeTel.Text;
            UpdateEmployee.empHp = txtEmployeeHtel.Text;
            UpdateEmployee.project = ProjectInfo.Where(o => o.prjNm.Equals(cboProject.Text)).First();
            UpdateEmployee.maritalState = cboEmployeeMaritalState.Text != "기혼" ? "false" : "true";
            UpdateEmployee.birthState = cboEmployeeBrithState.Text;
            UpdateEmployee.updateDate = DateTime.Now.ToUniversalTime().ToString("s") + "Z"; ;
            UpdateEmployee.enteringDate = employeeEnteringDate.Value.ToUniversalTime().ToString("s") + "Z";
            UpdateEmployee.birthDate = employeeBirthDate.Value.ToUniversalTime().ToString("s") + "Z";
            UpdateEmployee.maritalDate = employeeMarital_date.Value.ToUniversalTime().ToString("s") + "Z";
            UpdateEmployee.leaveDate = cboEmployeeLeaveType.Text != "퇴사" ? employeeLeaveDate.Value.ToUniversalTime().ToString("s") + "Z" : " ";

            ANBTX.Update("/api/employee", UpdateEmployee);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeName.Text))
            {
                MessageBox.Show("등록 할 [직원 성명]을 입력해주세요.");
                return;
            }

            // creat
            var emp = new EmployeeVO()
            {
                empId = "",// 이거는 입력해도 의미 없음
                birthDate = employeeBirthDate.Value.ToUniversalTime().ToString("s") + "Z",
                birthState = cboEmployeeBrithState.Text == "양력" ? "0" : cboEmployeeBrithState.Text == "음력" ? "1" : null,
                depart = null,
                email = txtEmailFirst.Text + "@" + cboEmailAddr.Text,
                empAddr = txtEmployeeAddr.Text,
                empAddrDtl = txtEmployeeAddrDtl.Text,
                empEngNm = txtEmployeeEngName.Text,
                empFlag = cboEmployeeType.Text == "정직원" ? "0" : cboEmployeeType.Text == "계약직" ? "1" : cboEmployeeType.Text == "협력사직원" ? "2" : cboEmployeeType.Text == "파트타임" ? "3" : "9",
                empHp = txtEmployeeHtel.Text,
                empNm = txtEmployeeName.Text,
                empPwd = null,
                empTel = txtEmployeeTel.Text,
                empZip = txtEmployeeZip.Text,
                enteringDate = employeeEnteringDate.Value.ToUniversalTime().ToString("s") + "Z",
                leaveDate = cboEmployeeLeaveType.Text != "퇴사" ? null : DateTime.MaxValue.ToUniversalTime().ToString("s") + "Z",
                loginDate = DateTime.MaxValue.ToUniversalTime().ToString("s") + "Z",
                maritalDate = cboEmployeeMaritalState.Text != "기혼" ? null : employeeMarital_date.Value.ToUniversalTime().ToString("s") + "Z",
                maritalState = cboEmployeeMaritalState.Text == "기혼" ? "1" : cboEmployeeMaritalState.Text == "미혼" ? "0" : null,
                officeTel = null,
                photo = null,
                position = null,
                reason = null,
                regEmpId = null,
                regEmpNm = null,
                registDste = DateTime.Now.ToUniversalTime().ToString("s") + "Z",

                rank = RankInfo.Where(o => o.rankName.Equals(cboRank.Text)).First(),

                project = ProjectInfo.Where(o => o.prjNm.Equals(cboProject.Text)).First(),

                spouseTel = null,
                state = null,
                team = cboTeamName.Text,
                updateDate = DateTime.Now.ToUniversalTime().ToString("s") + "Z",
                workPosition = null,
                userInfo = "",
                rankDisp = "",
                prjInfo = null
            };

            ANBTX.Create("/api/employee", emp);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비중 입니다.");
        }

        private void addrSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비중 입니다. \n\n 기존의 Open API 적용을 위해 CS를 구성하고 있습니다. \n\n 빠른 시일안에 조치하도록 하겠습니다.");
        }
    }
}
