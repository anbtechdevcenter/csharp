﻿using System;
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
	public partial class FrmRestAPITest : Form
	{
		
		public FrmRestAPITest()
		{
			InitializeComponent();
		}
 
		string API_URL = "/api/employee";

        // Create
        private void btnCreate_Click(object sender, EventArgs e)
		{
			var currentDate = DateTime.Now.ToLongDateString();
			// creat
			var emp = new EmployeeVO()
			{
				empId = "",// 이거는 입력해도 의미 없음
				birthDate = null,
				birthState = null,
				depart = null,
				email = "null empid test22",
				empAddr = null,
				empAddrDtl = null,
				empEngNm = null,
				empFlag = "CREATE22",
				empHp = "010CREATE22",
				empNm = textBox1.Text,
				empPwd = null,
				empTel = "010-0000-0000",
				empZip = null,
				enteringDate = currentDate,
				leaveDate = currentDate,
				loginDate = currentDate,
				maritalDate = null,
				maritalState = "true",
				officeTel = null,
				photo = null,
				position = null,
				reason = null,
				regEmpId = null,
				regEmpNm = null,
				registDste = currentDate,
				rank = new RankVO
				{
					rankCode = "RANK50",
					rankName = "대리",
					rankOrder = 50,
					useYn = "Y",
					regEmpId = null,
					regEmpNm = null,
					registDate = currentDate,
					updateDate = ""
				},
				project = new ProjectVO
                {
                    prjId = null,
                    prjNm = null,
                    prjStatus = null,
                    startDate = null,
                    endDate = null
                },
				spouseTel = null,
				state = null,
				team = null,
				updateDate = currentDate,
				workPosition = null,
				userInfo = "CREATE,kim22",
				rankDisp = "CREATE",
				prjInfo = null
			};

			ANBTX.Create(API_URL, emp);
		}


		#region ##  Read(GET)  ##


		private void btnRead_Click(object sender, EventArgs e)
		{
		 
			// read
			richTextBox1.AppendText("Employee Read....\n\r");

            try
			{
                
				var lstEmployee = ANBTX_Common.GetEmployee(API_URL);

				if (lstEmployee == null || lstEmployee.Count == 0)
				{
					richTextBox1.AppendText("Employee Read Result : 0 \n\r");
					return;
				}
				foreach (var emp in lstEmployee)
				{
					richTextBox1.AppendText(emp.empId + "\n\r");
				}

				richTextBox1.AppendText("Employee Count :"+lstEmployee.Count + "\n\r");
			}
			catch(Exception ex)
			{
				richTextBox1.AppendText(ex.ToString() + "\n\r");
			}
		}

        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
		{

			// update
			var lstEmployee = ANBTX_Common.GetEmployee(API_URL);

			if (lstEmployee.Any(o=>o.empId.Equals(textBox3.Text)))
			{
				var emp = lstEmployee.Where(o => o.empId.Equals(textBox3.Text)).ToArray()[0];
				emp.email = "updateTest!!!!!!!!!";

				ANBTX.Update(API_URL, emp);
			}
			
			// 이렇게 하고 업데이트하니 에러발생. 
			// error info.
			//{
			//"timestamp": 1489502978843,
			//"status": 500,
			//"error": "Internal Server Error",
			//"exception": "org.springframework.dao.InvalidDataAccessApiUsageException",
			//"message": "Target object must not be null; nested exception is java.lang.IllegalArgumentException: Target object must not be null",
			//"path": "/api/employee"
			//}

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// delete
			ANBTX.Delete(API_URL, textBox4.Text);
			btnRead_Click(null, null);
		}

		private void btnOpenEmployeeUI_Click(object sender, EventArgs e)
		{
			var frmEmp = new FrmEmployeeMag();
			frmEmp.ShowDialog();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            var frmPrj = new FrmProject();
            frmPrj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmHoli = new FrmHolidayMag();
            frmHoli.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frmCheckLogin = new FrmRestAPILogin();
            frmCheckLogin.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmRestAPITest_Load(object sender, EventArgs e)
        {
            
        }
    }
}
