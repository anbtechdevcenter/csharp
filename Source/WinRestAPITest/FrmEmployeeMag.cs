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

	/// <summary>
	/// 사원정보 관리 UI
	/// </summary>
	public partial class FrmEmployeeMag : Form
	{
		public FrmEmployeeMag()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 검색조건에 설정된 정보로 직원정보에서 필터링하여 결과 화면에 보여줍니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			// Get하여 고용리스트를 다 불러옮.

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
			
			if (frmEmpSetting.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				// UI 결과가 등록/수정 인경우 직원 정보 갱신하여 화면에 뿌려줌. 취소는 작업없음.
			}
			
		}
	}
}
