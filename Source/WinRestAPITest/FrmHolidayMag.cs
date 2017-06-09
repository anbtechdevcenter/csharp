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
            getLoadCombo();
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

        private void getLoadCombo()
        {
            //공통 코드 초기화
            _lstCommonCode = ANBTX_Common.GetCodeCommon(API_COMMON_CODE_URL);

            //직급 초기화
            _lstRank = ANBTX_Common.GetRank(API_RANK_URL);
            var lstRank = _lstRank.Select(o => o.rankName).ToList();
            this.SetComboBox(cboRank, lstRank);

            //프로젝트 초기화
            _lstProject = ANBTX_Common.GetProject(API_PROJECT_URL);
            var lstProject = _lstProject.Select(o => o.prjNm).Where(o => !string.IsNullOrEmpty(o)).Distinct().ToList();
            this.SetComboBox(cboProject, lstProject);
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
                dr["사번"] = k.empId;
                dr["이름"] = k.empNm;
                dr["일수"] = k.holidayDay;
                dr["시작일자"] = k.holidaySdate;
                dr["종료일자"] = k.holidayEdate;

                dt.Rows.Add(dr);
            }
            dataGridHoliday.DataSource = dt;
        }

        private void FrmHolidayMag_Load(object sender, EventArgs e)
        {
            
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

        private void dataGridHoliday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기능 구현중... ( 검색기능 ) \n\n 현재 화면 인터페이스 변경으로 기능이 미흡한 점 양해 부탁드립니다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기능 구현중... ( 검색기능 ) \n\n 현재 화면 인터페이스 변경으로 기능이 미흡한 점 양해 부탁드립니다.");
        }
    }
}
