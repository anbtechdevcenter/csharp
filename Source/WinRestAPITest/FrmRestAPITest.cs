using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRestAPITest
{
	public partial class FrmRestAPITest : Form
	{
		public FrmRestAPITest()
		{
			InitializeComponent();
		}
		RestAPIClient aa = new RestAPIClient();

		private void button1_Click(object sender, EventArgs e)
		{
			// creat
			aa.UpdateEmployee(new EmployeeDTO());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// read
			richTextBox1.AppendText("Employees Read....\n\r");
			
			try
			{
				var lstEmployee = aa.GetEmployees();

				if (lstEmployee == null || lstEmployee.Count == 0)
				{
					richTextBox1.AppendText("Employees Read Result : 0 \n\r");
					return;
				}
				foreach (var emp in lstEmployee)
				{
					richTextBox1.AppendText(emp.empId + "\n\r");
				}
			}
			catch(Exception ex)
			{
				richTextBox1.AppendText(ex.ToString() + "\n\r");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			// update
			aa.UpdateEmployee(new EmployeeDTO());
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// delete
			var em = new EmployeeDTO();

			aa.DeleteEmployee(em.empId);
			button2_Click(null, null);
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			aa.Connect();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			aa.Close();
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			aa.Test();
		}
	}
}
