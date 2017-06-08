using System;


namespace AnBTech.RestAPI
{

	[Serializable]
	public class RankVO
	{
        public string grant_type = "password"; // 고정값
        public string rankCode; // 직급 코드
        public string rankName; // 직급명
        public int rankOrder; // 직급 구분값 ( 상위 하위 구분값 )
        public string regEmpId; // 직급 등록자 아이디
        public string regEmpNm; // 직급 등록자 이름
        public string registDate; // 직급 등록일
        public string updateDate; // 직급 수정일
        public string useYn; // 직급 사용여부 ( Y / N )
    }
}
