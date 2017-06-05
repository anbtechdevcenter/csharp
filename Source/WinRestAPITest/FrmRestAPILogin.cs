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

namespace AnBTech.RestAPI
{
    public partial class FrmRestAPILogin : Form
    {
        public FrmRestAPILogin()
        {
            InitializeComponent();
        }

        public LoginVO loginInfo { internal get; set; }

        // 운영으로 들어갈 경우를 위해 URL을 남겨둠
        // 첫번째는 개발, 두번째는 운영
        readonly string[] BASE_URL = { "http://restnfeel.com:8080", "https://restnfeel.cloud.tyk.io/token/" };
        // 첫번째는 개발, 두번재는 운영 ( 로그인 관련 )
        readonly string[] BASE_SURV_URL = { "api/oauth/token", "/token" };
        static HttpClient loginAccess;

        static void MainAsync(string strAPI, LoginVO checkInfo)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoginEmail.Text))
            {
                MessageBox.Show("이메일을 입력해주세요.");
                return;
            }
            if (string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;
            }
            var login = new LoginVO()
            {
                grant_type = "password",
                email = txtLoginEmail.Text,
                password = txtLoginPassword.Text
            };

            MainAsync("/api/oauth/token", login);

            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var frmRestHome = new FrmRestAPITest();
                frmRestHome.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtLoginPassword.Text);
        }
    }
}
