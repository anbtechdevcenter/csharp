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
        Class_staff_management m_hstaff_management;
        public FrmMainViewList()
        {
            InitializeComponent();
        }

        public void AddListColumns()
        {
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

        private void FrmMainViewList_Load(object sender, EventArgs e)
        {
            m_hstaff_management = new Class_staff_management(listStaffView);
            m_hstaff_management.ReadStaffMagementListItem();
        }

        private void tabSubMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = tabStafeSubMenu.SelectedIndex;
            switch(selectIndex)
            {
                case 0: //enum으로 변경
                    m_hstaff_management.ReadStaffMagementListItem();
                    break;
            }
            //MessageBox.Show(selectIndex.ToString()+"눌렸다 이놈아!!");
        }

        private void FrmMainViewList_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
