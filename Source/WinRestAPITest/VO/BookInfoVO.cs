using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 도서 정보
	/// </summary>
	[Serializable]
    public class BookInfoVO
    {
        public string app1Date; // 대여일자
        public string app1EmpId; // 대여해준 직원 아이디값
        public string app1EmpNm; // 대여해준 직원 이름
        public string app2Date; // 반납일자
        public string app2EmpId; // 반납받은 직원 아이디값
        public string app2EmpNm; // 반납받은 직원 이름
        public string author; // 도서 저자 및 작가
        public string bookName; // 도서명
        public string bookYear; // 도서년도
        public string filingDate; // 도서 출원일
        public string publisher; // 도서 출판사
        public string purchaseAmount; // 도서 구입 금액
        public string purchaseDate; // 도서 구입일자
        public string purchaseEmpId; // 도서 구입 직원 아이디값
        public string purchaseEmpNm; // 도서 구입 직원 이름
        public string regEmpId; // 등록 직원 아이디값
        public string regEmpNm; // 등록 직원 이름
        public string registDate; // 등록일자
        public string seqBook; // 도서 시퀀스값
    }
}
