using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 도서 대여
	/// </summary>
	[Serializable]
    public class BookRentalVO
    {
        public string appDate; // ??
        public string appEmpId; // ??
        public string appEmpNm; // ??
        public string filingDate; // 도서 출판일
        public string regEmpId; // 등록 직원 아이디
        public string regEmpNm; // 등록 직원 이름
        public string registDate; // 등록일
        public string rentalEdate; // 대여 종료일
        public string rentalEnpId; // 대여 종료 아이디
        public string rentalReason; // 대여 사유
        public string rentalSdate; // 대여 시작일
        public string seqBook; // 도서 시퀀스 값
        public string seqRental; // 도서 대여 시퀀스 값
    }
}
