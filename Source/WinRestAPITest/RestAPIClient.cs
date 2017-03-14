using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ANTBX.WinRestAPI
{
 
    public class RestAPIClient
    {
		public RestAPIClient()
		{

		}

        HttpClient _client;
		
		public bool IsConnect=false;

		/// <summary>
		/// Connection 객체를 생성합니다.
		/// </summary>
		public void Connect(string strBaseAddress)
        {
			_client = new HttpClient();
			_client.BaseAddress = new Uri(strBaseAddress);//"http://api.anbtech.net:8080/"
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			IsConnect = true;
        }

		/// <summary>
		/// Connection 객체를 닫습니다.
		/// </summary>
		public void Close()
		{
			if (_client != null)	_client.Dispose();
			_client = null;
			IsConnect = false;
		}

		 
		/// <summary>
		/// 입력된 API 함수를 이용하여 데이터를 수집 합니다.
		/// </summary>
		/// <param name="strAPI"></param>
		/// <returns></returns>
		public HttpResponseMessage ANTBX_Get(string strAPI)
		{
			return _client.GetAsync(strAPI).Result;
		}

		/// <summary>
		/// 입력된 API 함수를 이용하여 CREATE/UPDATE 합니다.
		/// </summary>
		/// <param name="strAPI"> 호출 할 "/api/함수명" </param>
		/// <param name="inputVo"> 함수에 입력 할 VO 객체</param>
		public void ANTBX_Update(string strAPI, object inputVO)
		{
			if (_client == null) return;

			HttpResponseMessage response = _client.PostAsJsonAsync(strAPI, inputVO).Result;
			response.EnsureSuccessStatusCode();
		}
 

		/// <summary>
		/// 입력된 API 함수를 이용하여 지정된 키값에 해당하는 값을 DELETE 합니다.
		/// </summary>
		/// <param name="strAPI">호출 할 "/api/함수명" </param>
		/// <param name="id">제거하기위한 키값</param>
		/// <returns></returns>
		public HttpStatusCode ANTBX_Delete(string strAPI, string id)
		{
			if (_client == null) return HttpStatusCode.NotAcceptable;

			HttpResponseMessage response = _client.DeleteAsync(string.Format("{0}/{1}",strAPI, id)).Result;

			return response.StatusCode;
		}

    }
}