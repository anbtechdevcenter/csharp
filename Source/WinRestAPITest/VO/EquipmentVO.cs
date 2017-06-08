using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 장비관리VO
	/// </summary>
	[Serializable]
    public class EquipmentVO
    {
        public string bringProof;
        public string desc01;
        public string desc02;
        public string desc03;
        public string desc04;
        public string desc05;
        public string desc06;
        public string desc07;
        public string desc08;
        public string desc09;
        public string desc10;
        public string desc11;
        public string desc12;
        public string desc13;
        public string desc14;
        public string desc15;
        public string desc16;
        public string desc17;
        public string desc18;
        public string desc19;
        public string desc20;
        public string deviceModel; // 장비 모델명
        public string deviceName; // 장비명
        public string deviceSn; // 장비 시리얼 번호
        public string deviceState; // 장비 상태
        public string deviceType; // 장비 타입
        public string disposalDate; // 폐기일자
        public string makersId; // 제조사 코드
        public string makersName; // 제조사명
        public string purchaseDate; // 구입일
        public string rentalEdate; // 장비 사용 종료일
        public string rentalEmpId; // 장비사용자 아이디
        public string rentalSdate; // 장비 사용 시작일
        public string seqDevice;
    }
}
