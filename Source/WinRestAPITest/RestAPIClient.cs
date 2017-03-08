using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WinRestAPITest
{
	//public class Product
	//{
	//	public string Id { get; set; }
	//	public string Name { get; set; }
	//	public decimal Price { get; set; }
	//	public string Category { get; set; }
	//}
    
    public class RestAPIClient
    {
		public RestAPIClient()
		{

		}

        HttpClient _client;

        public void Connect()
        {
			_client = new HttpClient();
			_client.BaseAddress = new Uri("http://api.anbtech.net/");
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

		public void Close()
		{
			if (_client != null)	_client.Dispose();
			_client = null;
		}

        public void Test()
        {
			
			_client = new HttpClient();
			_client.BaseAddress = new Uri("http://api.anbtech.net/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new employee
				List<EmployeeDTO> lstEmployee = new List<EmployeeDTO>();

				// Get the employee list
				lstEmployee = GetEmployees();

				// Update the employee
				// empId는 서버에서 자동 생성되는 듯함.
				// empId가 동일하면 update, 다르면 insert. 직급 표시는 별도의 값이 있는듯?

				lstEmployee[0].empId = "EMP_2017030814075557";
				lstEmployee[0].empNm = "JAMES,kim2";
				lstEmployee[0].rank.rankName = "대리"; // no effect
				lstEmployee[0].empTel = "010-0000-0000";

				UpdateEmployee(lstEmployee[0]);

				// 화면에 다시 표시.
				lstEmployee = GetEmployees();


                // Delete the employee : id 제어.
				var statusCode = DeleteEmployee(lstEmployee[0].empId);
				Console.WriteLine("Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
 
		public List<EmployeeDTO> GetEmployees()
		{
			var lstEmployee = new List<EmployeeDTO>();
			var response = _client.GetAsync("api/employee").Result;
			if (response.IsSuccessStatusCode)
			{
				lstEmployee = response.Content.ReadAsAsync<List<EmployeeDTO>>().Result;
			}

			return lstEmployee;
		}
 
		public void UpdateEmployee(EmployeeDTO employee)
		{
			HttpResponseMessage response = _client.PostAsJsonAsync("api/employee", employee).Result;
			response.EnsureSuccessStatusCode();

			// Deserialize the updated employee from the response body.
			response.Content.ReadAsAsync<EmployeeDTO>();
		}
 

		public HttpStatusCode DeleteEmployee(string id)
		{
			HttpResponseMessage response = _client.DeleteAsync(string.Format("api/employee/{0}", id)).Result;
			return response.StatusCode;
		}

    }
}