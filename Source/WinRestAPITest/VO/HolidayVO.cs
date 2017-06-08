using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 근태관리 현황
	/// </summary>
	[Serializable]
    public class HolidayVO
    {
        public string grant_type = "password"; // 고정값
        public string app1Date; // 참조결제일
        public string app1EmpId; // 참조 결제자 아이디
        public string app1EmpNm; // 참조 결제자 이름
        public string app2Date; // 최종결제일
        public string app2EmpId; // 최종 결제자 아이디
        public string app2EmpNm; // 최종 결제자 이름
        public string empId; // 요청자 아이디
        public string empNm; // 요청자 이름
        public int holidayDay; // 일수 ( 휴가 및 특근 일수 )
        public string holidayEdate; // 종료일 ( 휴가 및 특근 )
        public string holidayReason; // 사유 ( 휴가 및 특근 )
        public string holidaySdate; // 시작일 ( 휴가 및 특근 )
        public string holidayType; // 구분 ( 휴가 및 특근 )
        public string regEmpId; // 요청 및 등록자 아이디
        public string regEmpNm; // 요청 및 등록자 이름
        public string registDt; // 요청 및 등록날짜
        public string seqHoliday; // 시퀀스값 ( 휴가 및 특근 )
    }
}
