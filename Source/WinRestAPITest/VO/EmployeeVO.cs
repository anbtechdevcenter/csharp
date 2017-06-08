using System;


namespace AnBTech.RestAPI
{
	/// <summary>
	/// 직원 정보 저장 객체.
	/// </summary>
	[Serializable]
	public class EmployeeVO
	{
        public string grant_type = "password"; // 고정값
        public string birthDate; // 생일 ( 날짜 )
		public string birthState; // 생일 구분 ( 양 / 음 )
        public string depart; // 
        public string email; // 이메일 - 추후 계정
        public string empAddr; // 주소
        public string empAddrDtl; // 상세주소
        public string empEngNm; // 직원 영어이름
        public string empFlag; // 직원 구분
        public string empHp; // 직원 핸드폰번호
        public string empId; // 직원 ID값
        public string empNm; // 직원이름
        public string empPwd; // 로그인 비밀번호
        public string empTel; // 직원 집전화번호
        public string empZip; // 우편번호
        public string enteringDate; // 입사일
        public string leaveDate; // 퇴사일
        public string loginDate; // 로그인 가능날짜
        public string maritalDate; // 결혼기념일
        public string maritalState; // 결혼유무
        public string officeTel; // 사무실전화번호
        public string photo; // 직원 사진
        public string position; // 담당포지션
        public string prjInfo; // 프로젝트정보
        public ProjectVO project; // 투입프로젝트 정보
        public RankVO rank; // 직급 정보
        public string rankDisp; // 
        public string reason; // 
        public string regEmpId; // 직원정보 등록자 아이디
        public string regEmpNm; // 직원정보 등록자 이름
        public string registDste; // 직원정보 등록일
        public string spouseTel; // 
        public string state; // 
        public string team; // 부서
        public string updateDate; // 수정일
        public string userInfo; // 직원정보 ( 비고란 )
        public string workPosition; // 근무지역
    }

}
