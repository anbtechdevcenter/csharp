using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 로그인 세션 Token.
	/// </summary>
	[Serializable]
    public class AccessTokenVO
    {
        public string access_token { internal get; set; }
    }
}
