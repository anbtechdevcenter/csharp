using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AnBTech.RestAPI
{

    public static class ANBTXLogin
    {
        /// <summary>
        /// 입력된 API 함수를 이용하여 CREATE/UPDATE 합니다.
        /// </summary>
        /// <param name="strAPI"> 호출 할 "/api/함수명" </param>
        /// <param name="inputVo"> 함수에 입력 할 VO 객체</param>
        public static HttpResponseMessage PostAsJsonAsyncs<T>(this HttpClient client, string requestUri, T value)
        {
            var content = new ObjectContent<T>(value, new JsonMediaTypeFormatter());
            var request = new HttpRequestMessage(new HttpMethod("POST"), requestUri) { Content = content };
            return client.SendAsync(request).Result;
        }
    }
}