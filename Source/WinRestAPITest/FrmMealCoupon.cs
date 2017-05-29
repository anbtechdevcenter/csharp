using AnBTech.RestAPI.VO;
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
    public partial class FrmMealCoupon : Form
    {
        public FrmMealCoupon()
        {
            InitializeComponent();
        }
        // readonly string API_EMPLOYEE_URL = "/api/employee";
        // readonly string API_PROJECT_URL = "/api/project";
        // readonly string API_MEAL_URL = "/api/meal";
        // readonly string API_MEAL_PURC_URL = "/api/mealcoupon_purchase";

        // List<EmployeeVO> _lstEmpList;
        // List<ProjectVO> _lstPrjList;
        // List<MealVO> _lstMealList;

        private void FrmMealCoupon_Load(object sender, EventArgs e)
        {
            InitControl();
        }
        private void InitControl()
        {
            // 식권 신청 가능자 선택항목
            // _lstEmpList = GetEmployee(API_EMPLOYEE_URL);
            // var lstEmpName = _lstEmployeeTotal.Select(o => o.empNm).ToList().Where(o => !string.IsNullOrEmpty(o)).ToList();
            // this.SetComboBox(cboEmployeeName, lstEmpName);

            // 프로젝트 참여 ( 식권 신청 가능 여부 판단 )
            // _lstPrjList = GetProject(API_PROJECT_URL);
            // var lstPrjCheck = _lstPrjList.Select(o => o.prjId).ToList().Where(o => !string.IsNullOrEmpty(o)).ToList();
            // this.mealCheck.value = t / f;

            // 기간 초기화.
            // this.dtpkFrom.Value = DateTime.Today.AddDays(-30); ;
            // this.dtpkTo.Value = DateTime.Now;
        }
    }
}
