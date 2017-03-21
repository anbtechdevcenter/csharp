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

			// 구분 초기화.
			cboEmployeeType.Items.Add("정규직");
			cboEmployeeType.Items.Add("계약직");
			cboEmployeeType.SelectedIndex = 0;

			if (IsNewEmployee)
			{
				btnUpdate.Enabled = false;
				btnCreate.Enabled = true;
			}
			else
			{
				btnUpdate.Enabled = true;
				btnCreate.Enabled = false;
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
				birthDate = null,
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
				enteringDate = dateTimePicker1.Value,
				leaveDate = DateTime.MaxValue,
				loginDate = DateTime.MaxValue,
				maritalDate = null,
				maritalState = "true",
				officeTel = null,
				photo = null,
				position = null,
				reason = null,
				regEmpId = null,
				regEmpNm = null,
				registDste = DateTime.Now,

				rank = RankInfo.Where(o=>o.rankName.Equals(cboRank.Text)).First(),

				project = null,
				spouseTel = null,
				state = null,
				team = cboTeamName.Text,
				updateDate = DateTime.Now,
				workPosition = null,
				userInfo = "",
				rankDisp = "",
				prjInfo = null
			};

			ANBTX.Create("/api/employee", emp);
		}
	}
}
