using AnBTech.RestAPI.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI
{

    public static class ANBTX
    {

        static HttpClient _client;

        public static AccessTokenVO tokenInfos { internal get; set; }
        public static string accessTokenHold;
        /// <summary>
        /// Connection 객체를 생성합니다.
        /// </summary>
        static void Connect()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://restnfeel.com:8080/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenInfos.access_token.ToString());
        }

        /// <summary>
        /// Connection 객체를 닫습니다.
        /// </summary>
        static void Close()
        {
            if (_client != null) _client.Dispose();
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

            HttpResponseMessage response = _client.DeleteAsync(string.Format("{0}/{1}", strAPI, id)).Result;

            return response.StatusCode;
        }

        //로그인
        // 운영으로 들어갈 경우를 위해 URL을 남겨둠
        static HttpClient loginAccess;
        //static HttpWebRequest loginCheck;

        public static void MainAsync(string strAPI, LoginVO checkInfo)
        {
            loginAccess = new HttpClient();
            loginAccess.BaseAddress = new Uri("http://restnfeel.com:8080");
            loginAccess.DefaultRequestHeaders.Add("Accept", "application/json");
            loginAccess.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "YW5iZGV2Y2VudGVyLWNsaWVudC13aXRoLXNlY3JldDpkZXZjZW50ZXI=");
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type",checkInfo.grant_type),
                new KeyValuePair<string, string>("username",checkInfo.email),
                new KeyValuePair<string, string>("password",checkInfo.password)
            });
            var request = new HttpRequestMessage(new HttpMethod("POST"), strAPI) { Content = content };
            var result = loginAccess.SendAsync(request).Result;
            //var result2 = loginAccess.SendAsync(request).AsyncState;
            Console.WriteLine(result);
            //Console.WriteLine(result2);
        }

        public static string WebRequestCheck(String strAPI, LoginVO check)
        {
            StringBuilder dataParam = new StringBuilder();
            dataParam.Append("grant_type=" + check.grant_type);
            dataParam.Append("&username=" + check.email);
            dataParam.Append("&password=" + check.password);
            byte[] byteDataParams = UTF8Encoding.UTF8.GetBytes(dataParam.ToString());

            HttpWebRequest loginCheck = (HttpWebRequest)WebRequest.Create(strAPI);
            loginCheck.Method = "POST";
            loginCheck.Accept = "application/json";
            loginCheck.Headers.Add(HttpRequestHeader.Authorization, "Basic YW5iZGV2Y2VudGVyLWNsaWVudC13aXRoLXNlY3JldDpkZXZjZW50ZXI=");
            loginCheck.ContentType = "application/x-www-form-urlencoded";

            Stream stDataParams = loginCheck.GetRequestStream();
            stDataParams.Write(byteDataParams, 0, byteDataParams.Length);
            stDataParams.Close();

            HttpWebResponse resLogin = (HttpWebResponse)loginCheck.GetResponse();

            Stream stReadData = resLogin.GetResponseStream();
            StreamReader srReadData = new StreamReader(stReadData, Encoding.Default);
            return srReadData.ReadToEnd();
        }

        public static string TokenValue(string token)
        {
            try
            {
                char[] TokenCheck = { ',' };
                string[] accessTokenCheck = token.Split(TokenCheck);
                string[] tokenSplit = accessTokenCheck[0].Split(':');
                tokenInfos.access_token = tokenSplit[1].Split('"')[1];
                return tokenSplit[1].Split('"')[1];
            }
            catch
            {
                return null;
            }
        }
    }
}