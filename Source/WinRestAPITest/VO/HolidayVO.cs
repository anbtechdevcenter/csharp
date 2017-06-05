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
        public string app1Date;
        public string app1EmpId;
        public string app1EmpNm;
        public string app2Date;
        public string app2EmpId;
        public string app2EmpNm;
        public string empId;
        public string empNm;
        public int holidayDay;
        public string holidayEdate;
        public string holidayReason;
        public string holidaySdate;
        public string holidayType;
        public string regEmpId;
        public string regEmpNm;
        public string registDt;
        public string seqHoliday;
    }
}
