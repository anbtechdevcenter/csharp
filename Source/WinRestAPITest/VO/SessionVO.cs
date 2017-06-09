using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 세션값
	/// </summary>
	[Serializable]
    public class SessionVO
    {
        public string loginEmailId { internal get; set; }  // email 리턴받아오는 아이디 값이 들어갈 장소
        public string loginPassword { internal get; set; }  // password 로그인할때 패쓰워드 값을 가지고 있다가 새션이 만료가 되면 자동 재로그인에 쓰임
        public string loginJti { internal get; set; }  // jti 리턴받아오는 jti 값이 들어갈 장소
        public string loginAdmin { internal get; set; }  // authorities 리턴받아오는 권한 값이 들어갈 장소
        public string loginEmpId { internal get; set; } // 재 로그인할때나 로그인 할때 직원 사번 값을 가져옴
        public string loginEmpNm { internal get; set; } // 재 로그인할때나 로그인 할때 직원 이름 값을 가져옴
    }
}
