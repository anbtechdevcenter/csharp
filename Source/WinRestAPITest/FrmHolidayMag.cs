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
    public partial class FrmHolidayMag : Form
    {
        public FrmHolidayMag()
        {
            InitializeComponent();
            InitControl();
        }

        readonly string API_RANK_URL = "/api/rank";
        readonly string API_PROJECT_URL = "/api/project";
        readonly string API_HOLIDAY_URL = "/api/holiday";
        readonly string API_COMMON_CODE_URL = "/api/codeCommon";

        List<RankVO> _lstRank;
        List<ProjectVO> _lstProject;
        List<CommonCodeVO> _lstCommonCode;
        List<HolidayVO> _lstHoliday;

        readonly LoginVO getLoginInfo;

        private void InitControl()
        {
            commGetHoliday();
        }

        private void commGetHoliday()
        {
            try
            {
                var lstHoliday = ANBTX_Common.GetHoliday(API_HOLIDAY_URL);
                if(lstHoliday == null || lstHoliday.Count == 0)
                {
                    MessageBox.Show("There is no data. ");
                    return;
                }
                makeData(lstHoliday);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
            }
        }

        private void makeData(List<HolidayVO> lstHoliday)
        {
            DataTable dt = new DataTable();
            DataRow dr;

            DataColumn colNo = dt.Columns.Add("NO", typeof(Int32));
            colNo.AutoIncrement = true;
            colNo.AutoIncrementSeed = 1;
            colNo.AutoIncrementStep = 1;
            
            DataColumn colPrjId = dt.Columns.Add("사번", typeof(string));
            DataColumn colPrjNm = dt.Columns.Add("이름", typeof(string));
            DataColumn colStatus = dt.Columns.Add("일수", typeof(string));
            DataColumn colStartDate = dt.Columns.Add("시작일자", typeof(string));
            DataColumn colEndDate = dt.Columns.Add("종료일자", typeof(string));
            //DataColumn colMember = dt.Columns.Add("MEMBER", typeof(string));

            IEnumerable<HolidayVO> Query = from n in lstHoliday
                                           select n;
            foreach (HolidayVO k in Query)
            {
                dr = dt.NewRow();
                //dr["MEMBER"] = "이름";

                dt.Rows.Add(dr);
            }
            dataGridHoliday.DataSource = dt;
        }

        private void FrmHolidayMag_Load(object sender, EventArgs e)
        {
            //공통 코드 초기화
            _lstCommonCode = ANBTX_Common.GetCodeCommon(API_COMMON_CODE_URL);

            //직급 초기화
            _lstRank = ANBTX_Common.GetRank(API_RANK_URL);
            var lstRank = _lstRank.Select(o => o.rankName).ToList();
            ANBTX_Common.SetComboBox(cboRank, lstRank);

            //프로젝트 초기화
            _lstProject = ANBTX_Common.GetProject(API_PROJECT_URL);
            var lstProject = _lstProject.Select(o => o.prjNm).Where(o => !string.IsNullOrEmpty(o)).Distinct().ToList();
            ANBTX_Common.SetComboBox(cboProject, lstProject);
        }

        private void dataGridHoliday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
