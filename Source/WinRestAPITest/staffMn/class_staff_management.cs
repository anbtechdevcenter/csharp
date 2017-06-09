using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnBTech.RestAPI
{
    public class Class_staff_management
    {
        private ListView m_hlist;

        public Class_staff_management(ListView in_hlist)
        {
            m_hlist = in_hlist;
        }


        public void AddListColumns()
        {
            m_hlist.Columns.Add("선택");
            m_hlist.Columns.Add("No");
            m_hlist.Columns.Add("이름");
            m_hlist.Columns.Add("직급");
            m_hlist.Columns.Add("소속팀");
            m_hlist.Columns.Add("E-Mail");
            m_hlist.Columns.Add("진행프로젝트");
            m_hlist.Columns.Add("입사일");
            m_hlist.Columns.Add("근무지역");
            m_hlist.Columns.Add("직원유형");
        }

        public void ReadStaffMagementListItem()
        {
            string API_URL = "/api/employee";

            try
            {
                var lstEmployee = ANBTX_Common.GetEmployee(API_URL);

                if (lstEmployee == null || lstEmployee.Count == 0)
                {
                    AddListColumns();
                }
                else
                {
                    m_hlist.Clear();
                    AddListColumns();
                }

                int indexcount = 1;
                foreach (var emp in lstEmployee)
                {
                    m_hlist.Items.Add(new ListViewItem(new string[]
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
    }
}
