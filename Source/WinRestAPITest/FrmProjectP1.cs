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
	public partial class FrmProjectP1 : Form
	{
		public FrmProjectP1()
		{
			InitializeComponent();
            InitControl();
        }

        public static string prjId = null;

        string API_URL = "/api/project";

        public void InitControl()
        {
            ComboBox cbStatus = new ComboBox();
            cbStatus.Name = "cbStatus";
            cboStatus.Items.Add("Active");
            cboStatus.Items.Add("Terminated");
            cboStatus.DisplayMember = "cbStatus";
            cboStatus.SelectedIndex = 0;

            edPrjId.Text = FrmProject.prjId;
            if (edPrjId.Text.Length > 0)
            {
                btnAdd.Enabled = true;
                edPrjId.Text = FrmProject.prjId;
                edPrjName.Text = FrmProject.prjNm;
                //dtpStartDate.Value = Convert.ToDateTime(FrmProject.prjstartDt);
                //dtpEndDate.Value = Convert.ToDateTime(FrmProject.prjendDt);
                cboStatus.SelectedValue = FrmProject.prjStatus;
            }
            else
            {
                btnAdd.Enabled = false;
                edPrjId.Text = null;
                edPrjName.Text = null;
                dtpStartDate.Value = DateTime.Now;
                dtpEndDate.Value = DateTime.Now;
                cboStatus.SelectedValue = FrmProject.prjStatus;
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
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var prj = new ProjectVO()
                {
                    prjId = edPrjId.Text
                };
                if(edPrjId.Text != null)
                {
                    ANBTX.Delete(API_URL, prjId);
                    MessageBox.Show("성공적으로 삭제되었습니다.");
                }
                else
                {
                    MessageBox.Show("이미 없는 데이터 입니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var prj = new ProjectVO()
                {
                    prjId = edPrjId.Text,// 이거는 입력해도 의미 없음
                    prjNm = edPrjName.Text,
                    prjStatus = cboStatus.Text,
                    startDate = dtpStartDate.Value.ToString("yyyy-MM-dd"),
                    endDate = dtpEndDate.Value.ToString("yyyy-MM-dd")
                    //startDate = DateTime.Now,
                };

                if (edPrjId.Text.Length > 0)
                {
                    ANBTX.Update(API_URL, prj);
                }
                else
                {
                    ANBTX.Create(API_URL, prj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
            }

            if (edPrjId.Text.Length > 0)
            {
                MessageBox.Show("성공적으로 저장되었습니다.");
            }
            else
            {
                MessageBox.Show("프로젝트가 성공적으로 추가되었습니다.");
            }
            //FrmProject.commGetPrj();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
