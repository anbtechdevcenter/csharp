using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 로그인 관련 세션
	/// </summary>
	[Serializable]
    public class LoginVO
    {
        public string grant_type = "password"; // 고정값
        public string email; // 실질적인 계정
        public string password; // 비밀번호
    }
}
