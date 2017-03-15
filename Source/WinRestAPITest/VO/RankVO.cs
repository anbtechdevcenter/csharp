using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI
{

	[Serializable]
	public class RankVO
	{
		public string rankCode;
		public string rankName;
		public int rankOrder;
		public string regEmpId;
		public string regEmpNm;
		public DateTime registDate { get; set; }
		public DateTime updateDate { get; set; }
		public string useYn;
	}
}
