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
        internal string grant_type;
        public string seqCode;
        public string codeType;
        public string codeId;
        public string codeNm;
        public string upCoseType;
        public string upCodeId;
        public string useYn;
        public string useStartDate;
        public string useEndDate;
        public string registDate;
        public string updateDate;
        public string reason;
    }
}
