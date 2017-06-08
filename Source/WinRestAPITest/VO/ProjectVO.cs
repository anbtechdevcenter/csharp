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
        public string grant_type = "password"; // 고정값
        public string prjId; // 프로젝트 아이디
        public string prjNm; // 프로젝트 이름
        public string prjStatus; // 프로젝트 상태
        public string startDate; // 프로젝트 시작일
        public string endDate; // 프로젝트 종료일
    }
}
