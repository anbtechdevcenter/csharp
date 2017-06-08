using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 공통코드.
	/// </summary>
	[Serializable]
    public class CommonCodeVO
    {
        public string grant_type = "password"; // 고정값
        public string seqCode; // 시퀀스값
        public string codeType; // 코드 타입
        public string codeId; // 코드 아이디 ( 구분을 위해 )
        public string codeNm; // 코드명
        public string upCoseType; // 상위코드 타입
        public string upCodeId; // 상위코드 아이디
        public string useYn; // 사용유무
        public string useStartDate; // 사용 시작일
        public string useEndDate; // 사용 종료일
        public string registDate; // 등록날짜
        public string updateDate; // 수정날짜
        public string reason; // 비고
    }
}
