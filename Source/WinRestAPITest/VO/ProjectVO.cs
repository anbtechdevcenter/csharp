using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI
{
	/// <summary>
	/// 직원 정보 저장 객체.
	/// </summary>
	[Serializable]
	public class ProjectVO
	{
        internal string grant_type;
        public string prjId;
		public string prjNm;
        public string prjStatus;
		public string startDate;
		public string endDate;
    }
}
