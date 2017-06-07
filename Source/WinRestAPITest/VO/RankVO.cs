using System;


namespace AnBTech.RestAPI
{

	[Serializable]
	public class RankVO
	{
        public string grant_type = "password"; // 고정값
        public string rankCode;
		public string rankName;
		public int rankOrder;
		public string regEmpId;
		public string regEmpNm;
		public string registDate;
		public string updateDate;
		public string useYn;
	}
}
