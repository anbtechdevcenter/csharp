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
    public partial class FrmMainViewList : Form
    {
        public FrmMainViewList()
        {
            InitializeComponent();
        }

        public void AddListColumns()
        {
            //직원관리 Columns
            listStaffView.Columns.Add("선택");
            listStaffView.Columns.Add("No");
            listStaffView.Columns.Add("이름");
            listStaffView.Columns.Add("직급");
            listStaffView.Columns.Add("소속팀");
            listStaffView.Columns.Add("E-Mail");
            listStaffView.Columns.Add("진행프로젝트");
            listStaffView.Columns.Add("입사일");
            listStaffView.Columns.Add("근무지역");
            listStaffView.Columns.Add("직원유형");

            //근태관리 Colums
            listWorkView.Columns.Add("선택");
            listWorkView.Columns.Add("No.");
            listWorkView.Columns.Add("사번");
            listWorkView.Columns.Add("이름");
            listWorkView.Columns.Add("일수");
            listWorkView.Columns.Add("휴가시작일");
            listWorkView.Columns.Add("휴가종료일");
            listWorkView.Columns.Add("사유");
            listWorkView.Columns.Add("휴일특근코드");
            listWorkView.Columns.Add("등록ID");
            listWorkView.Columns.Add("등록자명");
            listWorkView.Columns.Add("등록일");
            listWorkView.Columns.Add("휴일순번");
            listWorkView.Columns.Add("결재일자");
            listWorkView.Columns.Add("결재ID");
            listWorkView.Columns.Add("결재명");
        }

        public void ReadStaffMagementListItem()
        {
            string API_URL = "/api/employee";

            try
            {

                var lstEmployee = ANBTX_Common.GetEmployee(API_URL);
                
                if (lstEmployee == null || lstEmployee.Count == 0)
                {
                    MessageBox.Show("Employee Read Result : 0 \n\r");
                    return;
                }
                
                listStaffView.Clear();
                AddListColumns();

                int indexcount = 1;
                foreach (var emp in lstEmployee)
                {
                    listStaffView.Items.Add(new ListViewItem(new string[]
                    {
                        "",indexcount.ToString(),emp.empNm,emp.rank.rankName,"디자인팀","mjkang@anbtech.co.kr","ANB New Project","2017-04-04", "이천","정직원"
                    }));
                    indexcount++;                
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\r");
            }
        }
        

        private void FrmMainViewList_Load(object sender, EventArgs e)
        {
            AddListColumns();            
        }

        private void tabSubMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = tabStafeSubMenu.SelectedIndex;
            switch(selectIndex)
            {
                case 0: //enum으로 변경
                    ReadStaffMagementListItem();
                    break;
            }
            //MessageBox.Show(selectIndex.ToString()+"눌렸다 이놈아!!");
        }
    }
}
