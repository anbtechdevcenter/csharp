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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AnBTech.RestAPI
{
    public static class ANBTX_JWT_module
    {
        readonly static LoginVO setSession;

        public static void ReLogin(string strAPI, SessionVO check)
        {
            string tokenVal = WebRelogin(strAPI, check);
            TokenValue(tokenVal);
            SessionCheck(ANBTX.notConvertaccessTokenHold);
        }

        public static string WebRelogin(String strAPI, SessionVO check)
        {
            StringBuilder dataParam = new StringBuilder();
            dataParam.Append("grant_type=password");
            dataParam.Append("&username=" + check.loginEmailId.ToString());
            dataParam.Append("&password=" + check.loginPassword.ToString());
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
                ANBTX.TokenSet(tokenSplit[1].Split('"')[1]);
                return tokenSplit[1].Split('"')[1];
            }
            catch
            {
                return null;
            }
        }

        public static SessionVO SessionCheck(string splitToken)
        {
            var check = splitToken.Split('.');
            string partToConvert = check[1];
            partToConvert = partToConvert.Replace('-', '+');
            partToConvert = partToConvert.Replace('_', '/');
            switch (partToConvert.Length % 4)
            {
                case 0:
                    break;
                case 2:
                    partToConvert += "==";
                    break;
                case 3:
                    partToConvert += "=";
                    break;
            }

            var partAsBytes = Convert.FromBase64String(partToConvert);
            Console.WriteLine(partAsBytes.ToString());
            var partAsUTF8String = Encoding.UTF8.GetString(partAsBytes, 0, partAsBytes.Count());
            Console.WriteLine(partAsUTF8String.ToString());
            var jwt = JObject.Parse(partAsUTF8String);
            Console.WriteLine(jwt.ToString());
            var session = new SessionVO();
            session.loginEmailId = jwt.GetValue("user_name").ToString();
            session.loginPassword = setSession.password.ToString() == null ? session.loginPassword.ToString() : setSession.password.ToString();
            session.loginJti = jwt.GetValue("jti").ToString();
            session.loginAdmin = jwt.GetValue("authorities").ToString();
            var gaga = ANBTX_Common.GetEmployee("/api/employee");
            Console.WriteLine(gaga.Where(o => o.email != null && o.email.Equals("h@anbtech.com")).Select(o => o.empNm).ToString());
            //session.loginEmpId = gaga.Where(o => o.email == jwt.GetValue("user_name").ToString()).Select(o => o.empNm).;
            return session;
        }
    }
}