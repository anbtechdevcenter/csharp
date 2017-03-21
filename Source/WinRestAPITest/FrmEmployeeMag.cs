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

		List<EmployeeVO> _lstEmployeeTotal;
		List<RankVO> _lstRank;
		List<ProjectVO> _lstProject;
		List<string> _lstTeam;
		

		private void FrmEmployeeMag_Load(object sender, EventArgs e)
		{
			InitControl();
		}

		private void InitControl()
		{
			// 직원이름 초기화.
			_lstEmployeeTotal = GetEmployee(API_EMPLOYEE_URL);
			var lstEmpName = _lstEmployeeTotal.Select(o => o.empNm).ToList().Where(o => !string.IsNullOrEmpty(o)).ToList();
			this.SetComboBox(cboEmployeeName, lstEmpName);


			// 부서명 초기화.
			_lstTeam = _lstEmployeeTotal.Select(o => o.team).ToList().Where(o => !string.IsNullOrEmpty(o)).Distinct().ToList();
			this.SetComboBox(cboTeamName, _lstTeam);


			// 프로젝트명 초기화.
			_lstProject = GetProject(API_RANK_URL);
			var lstProject = _lstProject.Select(o => o.prjNm).Where(o => !string.IsNullOrEmpty(o)).Distinct().ToList();
			this.SetComboBox(cboProjectName, lstProject);


			// 직급 초기화.
			_lstRank = GetRank(API_RANK_URL);
			var lstRank = _lstRank.Select(o => o.rankName).ToList();
			this.SetComboBox(cboRank, lstRank);


			// 기간 초기화.
			this.dtpkFrom.Value = DateTime.Today.AddDays(-30); ;
			this.dtpkTo.Value = DateTime.Now;
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

		/// <summary>
		/// Employee 항목을 가져옵니다.
		/// </summary>
		/// <param name="strAPI"></param>
		/// <returns></returns>
		public List<EmployeeVO> GetEmployee(string strAPI)
		{
			var lstEmployee = new List<EmployeeVO>();

			var response = ANBTX.Get(strAPI);

			if (response.IsSuccessStatusCode)
			{
				lstEmployee = response.Content.ReadAsAsync<List<EmployeeVO>>().Result;
			}

			return lstEmployee;
		}

		/// <summary>
		/// Rank 항목을 가져옵니다.
		/// </summary>
		/// <param name="strAPI"></param>
		/// <returns></returns>
		public List<RankVO> GetRank(string strAPI)
		{
			var lstObject = new List<RankVO>();

			var response = ANBTX.Get(strAPI);

			if (response.IsSuccessStatusCode)
			{
				lstObject = response.Content.ReadAsAsync<List<RankVO>>().Result;
			}

			return lstObject;
		}

		/// <summary>
		/// Project 항목을 가져옵니다.
		/// </summary>
		/// <param name="strAPI"></param>
		/// <returns></returns>
		public List<ProjectVO> GetProject(string strAPI)
		{
			var lstObject = new List<ProjectVO>();

			var response = ANBTX.Get(strAPI);

			if (response.IsSuccessStatusCode)
			{
				lstObject = response.Content.ReadAsAsync<List<ProjectVO>>().Result;
			}

			return lstObject;
		}

		/// <summary>
		/// 검색조건에 설정된 정보로 직원정보에서 필터링하여 결과 화면에 보여줍니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			// Get하여 고용리스트를 다 불러옮.
			var empList = ANBTX.Get(API_EMPLOYEE_URL);

			// 부서명 필터

			// 직급 필터

			// 사원명 필터

			// 검색년월일로 입사년도 필터

			// 프로젝트명 필터

			// 사원분류 필터.
		}

		private void btnNewEmployee_Click(object sender, EventArgs e)
		{
			// 신규 사원 입력 UI 생성.
			var frmEmpSetting = new FrmEmployeeSetting();
			frmEmpSetting.IsNewEmployee = true;
			frmEmpSetting.RankInfo = _lstRank;
			frmEmpSetting.TeamInfo = _lstTeam;

			if (frmEmpSetting.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				// UI 결과가 등록/수정 인경우 직원 정보 갱신하여 화면에 뿌려줌. 취소는 작업없음.
			}
			
		}

	}
}
