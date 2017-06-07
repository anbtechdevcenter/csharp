using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using AnBTech.RestAPI.VO;

namespace AnBTech.RestAPI
{
	public partial class FrmProject : Form
	{
		
		public FrmProject()
		{
			InitializeComponent();
            InitControl();
		}
 
        string API_URL_EMP = "/api/employee";
        string API_URL_PRJ = "/api/project";
        public static string prjId = null;
        public static string prjNm = null;
        public static string prjendDt = null;
        public static string prjstartDt = null;
        public static string prjStatus = null;
        public static AccessTokenVO TokenInfo { internal get; set; }

        private void InitControl()
        {
            commGetPrj();
            commGetEmp();
        }

        private void commGetPrj()
        {
            try
            {
                var lstPrj = GetProject(API_URL_PRJ);
                if (lstPrj == null || lstPrj.Count == 0)
                {
                    MessageBox.Show("There is no data.");
                    return;
                }
                makeDt(lstPrj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
            }
        }

        private void commGetEmp()
        {
            try
            {
                var lstEmp = GetEmployee(API_URL_EMP);
                if (lstEmp == null || lstEmp.Count == 0)
                {
                    MessageBox.Show("There is no data.");
                    return;
                }
                //makeDt(lstEmp);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
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
		/// Project 항목을 가져옵니다.
		/// </summary>
		/// <param name="strAPI"></param>
		/// <returns></returns>
		public List<ProjectVO> GetProject(string strAPI)
        {
            var lstProject = new List<ProjectVO>();

            var response = ANBTX.Get(strAPI);

            if (response.IsSuccessStatusCode)
            {
                lstProject = response.Content.ReadAsAsync<List<ProjectVO>>().Result;
            }

            return lstProject;
        }
        
        private void makeDt(List<ProjectVO> lstPrj)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            
            DataColumn colNo = dt.Columns.Add("NO", typeof(Int32));
            colNo.AutoIncrement = true;
            colNo.AutoIncrementSeed = 1;
            colNo.AutoIncrementStep = 1;
            DataColumn colPrjId = dt.Columns.Add("PROJECT ID", typeof(string));
            DataColumn colPrjNm = dt.Columns.Add("PROJECT NAME", typeof(string));
            DataColumn colStatus = dt.Columns.Add("STATUS", typeof(string));
            DataColumn colStartDate = dt.Columns.Add("START DATE", typeof(string));
            DataColumn colEndDate = dt.Columns.Add("END DATE", typeof(string));
            //DataColumn colMember = dt.Columns.Add("MEMBER", typeof(string));

            IEnumerable<ProjectVO> Query = from n in lstPrj
                                           select n;
            foreach (ProjectVO k in Query)
            {
                dr = dt.NewRow();

                dr["PROJECT ID"] = k.prjId;
                dr["PROJECT NAME"] = k.prjNm;
                dr["STATUS"] = k.prjStatus;
                dr["START DATE"] = k.startDate;
                dr["END DATE"] = k.endDate;
                //dr["MEMBER"] = "이름";

                dt.Rows.Add(dr);
            }
            grdRpt.DataSource = dt;
        }

        // 조회버튼
        private void btnSelect_Click(object sender, EventArgs e)
        {
            commGetPrj();
        }

        // 신규버튼
        private void btnAdd_Click(object sender, EventArgs e)
        {
            prjId = null;
            FrmProjectP1 frmProjectP1 = new FrmProjectP1();
            frmProjectP1.ShowDialog();
        }

        private void grdRpt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            prjId = grdRpt.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            prjNm = grdRpt.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            prjStatus = grdRpt.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            prjstartDt = grdRpt.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            prjendDt = grdRpt.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

            FrmProjectP1 frmProjectP1 = new FrmProjectP1();
            frmProjectP1.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
