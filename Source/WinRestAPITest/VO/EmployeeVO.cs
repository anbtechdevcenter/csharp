﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTBX.WinRestAPI
{
	/// <summary>
	/// 직원 정보 저장 객체.
	/// </summary>
	[Serializable]
	public class EmployeeVO
	{

		public string birthDate;
		public string birthState;
		public string depart;
		public string email;
		public string empAddr;
		public string empAddrDtl;
		public string empEngNm;
		public string empFlag;
		public string empHp;
		public string empId;
		public string empNm;
		public string empPwd;
		public string empTel;
		public string empZip;
		public DateTime enteringDate { get; set; }
		public DateTime leaveDate { get; set; }
		public DateTime loginDate { get; set; }
		public string maritalDate;
		public string maritalState;
		public string officeTel;
		public string photo;
		public string position;
		public string prjInfo;
		public ProjectVO project;
		public RankVO rank;
		public string rankDisp;
		public string reason;
		public string regEmpId;
		public string regEmpNm;
		public DateTime registDste { get; set; }
		public string spouseTel;
		public string state;
		public string team;
		public DateTime updateDate { get; set; }
		public string userInfo;
		public string workPosition;

	}

}