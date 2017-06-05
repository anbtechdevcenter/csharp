using AnBTech.RestAPI.VO;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AnBTech.RestAPI
{

    public static class JWT_Module
    {
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
            char[] TokenCheck = { ',' };
            string[] accessTokenCheck = token.Split(TokenCheck);
            string[] tokenSplit = accessTokenCheck[0].Split(':');
            AccessTokenVO at = new AccessTokenVO();
            at.access_token = tokenSplit[1];
            return tokenSplit[1];
        }

    }
}