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

namespace ANTBX.WinRestAPI
{
	public partial class FrmRestAPITest : Form
	{
		
		public FrmRestAPITest()
		{
			InitializeComponent();
		}

		RestAPIClient aa = new RestAPIClient();

		string API_URL = "/api/employee";


		// Create
		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (!aa.IsConnect)
			{
				MessageBox.Show("Click Connect"); return;
			}

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
				empNm = "CREATE,kim22",
				empPwd = null,
				empTel = "010-0000-0000",
				empZip = null,
				enteringDate = DateTime.Now,
				leaveDate = DateTime.Now,
				loginDate = DateTime.Now,
				maritalDate = null,
				maritalState = "true",
				officeTel = null,
				photo = null,
				position = null,
				reason = null,
				regEmpId = null,
				regEmpNm = null,
				registDste = DateTime.Now,
				rank = new RankVO
				{
					rankCode = "RANK50",
					rankName = "대리",
					rankOrder = 50,
					useYn = "Y",
					regEmpId = null,
					regEmpNm = null,
					registDate = new DateTime(),
					updateDate = new DateTime()
				},
				project = null,
				spouseTel = null,
				state = null,
				team = null,
				updateDate = DateTime.Now,
				workPosition = null,
				userInfo = "CREATE,kim22",
				rankDisp = "CREATE",
				prjInfo = null
			};

			aa.ANTBX_Update(API_URL, emp);
		}


		#region ##  Read(GET)  ##


		private void btnRead_Click(object sender, EventArgs e)
		{
			if (!aa.IsConnect)
			{
				MessageBox.Show("Click Connect"); return;
			}

			// read
			richTextBox1.AppendText("Employee Read....\n\r");
			
			try
			{
				var lstEmployee = GetEmployee(API_URL);

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

		/// <summary>
		/// Employee 항목을 가져옵니다.
		/// </summary>
		/// <param name="strAPI"></param>
		/// <returns></returns>
		public List<EmployeeVO> GetEmployee(string strAPI)
		{
			var lstEmployee = new List<EmployeeVO>();

			var response = aa.ANTBX_Get(strAPI);

			if (response.IsSuccessStatusCode)
			{
				lstEmployee = response.Content.ReadAsAsync<List<EmployeeVO>>().Result;
			}

			return lstEmployee;
		}


		#endregion
		
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (!aa.IsConnect)
			{
				MessageBox.Show("Click Connect"); return;
			}

			// update
			var emp = new EmployeeVO();
			emp.empId = "EMP_201611180045133";
			emp.email = "astatine@mail.mail";
			
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

			aa.ANTBX_Update(API_URL, emp);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			if (!aa.IsConnect)
			{
				MessageBox.Show("Click Connect"); return;
			}

			// delete
			var em = new EmployeeVO();

			em.empId = "EMP_2017030813473756";

			aa.ANTBX_Delete(API_URL, em.empId);
			btnRead_Click(null, null);
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			aa.Connect("http://api.anbtech.net:8080/");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			aa.Close();
		}
		 
	}
}
