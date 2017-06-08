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
    public partial class FrmRestAPILogin : Form
    {
        public FrmRestAPILogin()
        {
            InitializeComponent();
        }
        // 첫번째는 개발, 두번째는 운영
        readonly string[] BASE_URL = { "http://restnfeel.com:8080", "https://restnfeel.cloud.tyk.io/token/" };
        // 첫번째는 개발, 두번재는 운영 ( 로그인 관련 )
        readonly string[] BASE_SURV_URL = { "/api/oauth/token", "/token" };

        public LoginVO loginInfo { internal get; set; }
        public CookieContainer loginCookie = new CookieContainer();

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

            string token = ANBTX.WebRequestCheck(BASE_URL[0]+BASE_SURV_URL[0], login);
            ANBTX.TokenValue(token);
            
            if (ANBTX.TokenValue(token) != null)
            {
                //var frmRestHome = new FrmRestAPITest();
                //frmRestHome.ShowDialog();
                //this.Close();

                var frmMainViewList = new FrmMainViewList();
                frmMainViewList.Show();
                this.Hide();
                
                
            }
        }
    }
}
