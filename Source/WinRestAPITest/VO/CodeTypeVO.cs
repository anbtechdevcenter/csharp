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
    public class CodeTypeVO
    {
        public string codeType; // 코드 타입
        public string codeTypeName; // 코드 타입 명
        public string reason; // 코드 사용 목적
        public string registDate; // 코드 등록일
        public string updateDate; // 코드 수정일
        public string useEdate; // 코드 사용 종료일
        public string useStdate; // 코드 사용 시작일
        public string useYn; // 코드 사용 유무 ( Y / N )
    }
}
