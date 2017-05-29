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
				this.SetComboBox(cboRank, RankInfo.Select(o=>o.rankName).ToList());
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
			cboEmployeeType.SelectedIndex = 0;

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
				var lstRank = RankInfo.Select(o=>o.rankName).ToList();
				nIndex = UpdateEmployee.rank == null ? 0 : lstRank.IndexOf(UpdateEmployee.rank.rankName);
				cboRank.SelectedIndex = nIndex+1;

				// team name bind
				nIndex = string.IsNullOrEmpty(UpdateEmployee.team) ? 0 : TeamInfo.IndexOf(UpdateEmployee.team);
				cboTeamName.SelectedIndex = nIndex+1;

                // project name bind
                var lstProject = ProjectInfo.Select(o => o.prjNm).ToList();
                nIndex = UpdateEmployee.project == null ? 0 : lstProject.IndexOf(UpdateEmployee.project.prjNm);
                cboProject.SelectedIndex = nIndex+1;

                // name bind.
                txtEmployeeName.Text = UpdateEmployee.empNm;

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
			UpdateEmployee.empNm = UpdateEmployee.empNm != txtEmployeeName.Text ? txtEmployeeName.Text : UpdateEmployee.empNm;
			UpdateEmployee.rank = RankInfo.Where(o=>o.rankName.Equals(cboRank.Text)).First();
			UpdateEmployee.empFlag = cboEmployeeType.Text;
			UpdateEmployee.team = cboTeamName.Text;
            UpdateEmployee.project = ProjectInfo.Where(o => o.prjNm.Equals(cboProject.Text)).First();
			UpdateEmployee.updateDate = DateTime.Now.ToUniversalTime().ToString("s") + "Z"; ;
			UpdateEmployee.enteringDate = dateTimePicker1.Value.ToUniversalTime().ToString("s") + "Z";
            UpdateEmployee.birthDate = dateTimePicker2.Value.ToUniversalTime().ToString("s") + "Z";

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
				birthDate = dateTimePicker2.Value.ToUniversalTime().ToString("s") + "Z",
				birthState = null,
				depart = null,
				email = "",
				empAddr = null,
				empAddrDtl = null,
				empEngNm = null,
				empFlag = cboEmployeeType.Text,
				empHp = "",
				empNm = txtEmployeeName.Text,
				empPwd = null,
				empTel = "",
				empZip = null,
				enteringDate = dateTimePicker1.Value.ToUniversalTime().ToString("s") + "Z",
				leaveDate = DateTime.MaxValue.ToUniversalTime().ToString("s") + "Z",
				loginDate = DateTime.MaxValue.ToUniversalTime().ToString("s") + "Z",
				maritalDate = null,
				maritalState = "true",
				officeTel = null,
				photo = null,
				position = null,
				reason = null,
				regEmpId = null,
				regEmpNm = null,
				registDste = DateTime.Now.ToUniversalTime().ToString("s") + "Z",

				rank = RankInfo.Where(o=>o.rankName.Equals(cboRank.Text)).First(),

				project = ProjectInfo.Where(o=>o.prjNm.Equals(cboProject.Text)).First(),

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
    }
}
