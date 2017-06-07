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
	public partial class FrmProjectP2 : Form
	{
		
		public FrmProjectP2()
		{
			InitializeComponent();
            InitControl();
        }
 
		string API_URL = "/api/employee";
        string API_URL_EMP = "/api/employee";

        private void InitControl()
        {
            commGetEmp();
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
                makeDt(lstEmp);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
            }
        }

        private void makeDt(List<EmployeeVO> lstEmp)
        {
            DataTable dt = new DataTable();
            DataRow dr;

            DataColumn colNo = dt.Columns.Add("NO", typeof(Int32));
            colNo.AutoIncrement = true;
            colNo.AutoIncrementSeed = 1;
            colNo.AutoIncrementStep = 1;
            DataColumn colChk = dt.Columns.Add("CHK", typeof(bool));
            DataColumn colempId = dt.Columns.Add("아이디", typeof(string));
            DataColumn colMember = dt.Columns.Add("멤버", typeof(string));
            DataColumn colPrjId = dt.Columns.Add("직급", typeof(string));
            DataColumn colPrjNm = dt.Columns.Add("참여일", typeof(string));
            
            IEnumerable<EmployeeVO> Query = from n in lstEmp select n;

            foreach (EmployeeVO k in Query)
            {
                dr = dt.NewRow();

                dr["아이디"] = k.empId;
                dr["멤버"] = k.empNm;
                dr["직급"] = k.rank.rankName;
                dr["참여일"] = DateTime.Now;
                
                dt.Rows.Add(dr);
            }
            grdRpt.DataSource = dt;
        }

        private void grdRpt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DateTimePicker oDateTimePicker = new DateTimePicker();
                grdRpt.Controls.Add(oDateTimePicker);

                oDateTimePicker.Format = DateTimePickerFormat.Short;
                Rectangle oRectangle = grdRpt.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                oDateTimePicker.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var lstEmployee = GetEmployee(API_URL);
                for (int i = 0; i < grdRpt.Rows.Count; i++)
                {
                    var chk = grdRpt.Rows[i].Cells[1].FormattedValue.ToString();
                    if (chk.Equals("True"))
                    {
                        var chkEmpId = grdRpt.Rows[i].Cells[2].FormattedValue.ToString();

                        if (lstEmployee.Any(o => o.empId.Equals(chkEmpId)))
                        {
                            var emp = lstEmployee.Where(o => o.empId.Equals(chkEmpId)).ToArray()[0];
                            emp.email = "updateTest!!!!!!!!!";
                            //emp.project.prjId = FrmProjectP1.prjId;
                            //emp.project.prjNm = "test";
                            //emp.project.prjStatus = "OK";
                            //emp.project.startDate = DateTime.Now;
                            //emp.project.endDate = DateTime.Now;


                            ANBTX.Update(API_URL, emp);
                        }
                    }
                }
                MessageBox.Show("성공적으로 등록되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
            }
            this.Close();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
