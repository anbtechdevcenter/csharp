using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AnBTech.RestAPI
{

	public static class ANBTX
    {

		static HttpClient _client;
 

		/// <summary>
		/// Connection 객체를 생성합니다.
		/// </summary>
		static void Connect()
        {
			_client = new HttpClient();
			_client.BaseAddress = new Uri("http://restnfeel.com:8080/");
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

		/// <summary>
		/// Connection 객체를 닫습니다.
		/// </summary>
		static void Close()
		{
			if (_client != null)	_client.Dispose();
			_client = null;
		}

		 
		/// <summary>
		/// 입력된 API 함수를 이용하여 데이터를 수집 합니다.
		/// </summary>
		/// <param name="strAPI"></param>
		/// <returns></returns>
		public static HttpResponseMessage Get(string strAPI)
		{
			if (_client == null) Connect();
			return _client.GetAsync(strAPI).Result;
		}

		/// <summary>
		/// 입력된 API 함수를 이용하여 CREATE/UPDATE 합니다.
		/// </summary>
		/// <param name="strAPI"> 호출 할 "/api/함수명" </param>
		/// <param name="inputVo"> 함수에 입력 할 VO 객체</param>
		public static void Create(string strAPI, object inputVO)
		{
			if (_client == null) Connect();
			HttpResponseMessage response = _client.PostAsJsonAsync(strAPI, inputVO).Result;
			response.EnsureSuccessStatusCode();
		}

		/// <summary>
		/// 입력된 API 함수를 이용하여 CREATE/UPDATE 합니다.
		/// </summary>
		/// <param name="strAPI"> 호출 할 "/api/함수명" </param>
		/// <param name="inputVo"> 함수에 입력 할 VO 객체</param>
		public static HttpResponseMessage Update(string strAPI, object inputVO)
		{
			if (_client == null) Connect();
			return PatchAsJsonAsync(_client, strAPI, inputVO);
		}

		public static HttpResponseMessage PatchAsJsonAsync<T>(this HttpClient client, string requestUri, T value)
		{
			var content = new ObjectContent<T>(value, new JsonMediaTypeFormatter());
			var request = new HttpRequestMessage(new HttpMethod("PATCH"), requestUri) { Content = content };

			return client.SendAsync(request).Result;
		}

		/// <summary>
		/// 입력된 API 함수를 이용하여 지정된 키값에 해당하는 값을 DELETE 합니다.
		/// </summary>
		/// <param name="strAPI">호출 할 "/api/함수명" </param>
		/// <param name="id">제거하기위한 키값</param>
		/// <returns></returns>
		public static HttpStatusCode Delete(string strAPI, string id)
		{
			if (_client == null) Connect();

			HttpResponseMessage response = _client.DeleteAsync(string.Format("{0}/{1}",strAPI, id)).Result;
			
			return response.StatusCode;
		}
 
	}
}