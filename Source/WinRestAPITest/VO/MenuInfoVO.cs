using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 메뉴 정보 VO
	/// </summary>
	[Serializable]
    public class MenuInfoVO
    {
        public string anthroityName;  // 
        public string isDefault;  // 메뉴 기본
        public string mnController; // 메뉴 호출 API
        public string mnDepth; // 메뉴 구분 ( 상 / 하위 )
        public string mnId; // 메뉴 아이디
        public string mnName; // 메뉴 명
        public string mnOrder; // 
        public string mnState; // 메뉴 상태
        public string mnTemplateUrl; // 메뉴 경로 ( C#은 CS파일명 )
        public string mnUrl; // 메뉴 경로 ( C#은 CS파일명 => 처리 CS파일명 )
        public string parentId; // 메뉴 상위 아이디값
        public string platformType; // 메뉴 구분 ( C# / JAVA )
        public string publishingRef; // 
    }
}
