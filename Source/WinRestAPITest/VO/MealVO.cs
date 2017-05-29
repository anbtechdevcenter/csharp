using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBTech.RestAPI.VO
{
    /// <summary>
	/// 식권신청 현황
	/// </summary>
	[Serializable]
    public class MealVO
    {
        public string seqMeal;
        public string applyDate;
        public string applyQty;
        public string buyPrice;
        public string fixedDate;
        public string fixedQty;
        public string mealType;
        public string reason;
        public EmployeeVO employeeVO;
        public ProjectVO projectVO;
        public string spouseTel;
        public string state;
        public string team;
        public string updateDate;
        public string workPosition;
        public string userInfo;
        public string rankDisp;
        public string prjInfo;
    }
}
