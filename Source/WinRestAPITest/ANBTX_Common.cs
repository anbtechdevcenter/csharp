using AnBTech.RestAPI.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnBTech.RestAPI
{
    public static class ANBTX_Common
    {
        /// <summary>
        /// 공통코드 항목을 가져옵니다.
        /// </summary>
        /// 
        /// <returns></returns>
        public static List<CommonCodeVO> GetCodeCommon(string strAPI)
        {
            var lstCodeCommon = new List<CommonCodeVO>();

            var response = ANBTX.Get(strAPI);

            if (response.IsSuccessStatusCode)
            {
                lstCodeCommon = response.Content.ReadAsAsync<List<CommonCodeVO>>().Result;
            }

            return lstCodeCommon;
        }

        /// <summary>
        /// Employee 항목을 가져옵니다.
        /// </summary>
        /// <param name="strAPI"></param>
        /// <returns></returns>
        public static List<EmployeeVO> GetEmployee(string strAPI)
        {
            var lstEmployee = new List<EmployeeVO>();

            var response = ANBTX.Get(strAPI);

            if (response.IsSuccessStatusCode)
            {
                lstEmployee = response.Content.ReadAsAsync<List<EmployeeVO>>().Result;
            }

            return lstEmployee;
        }

        internal static void SetComboBox(ComboBox cboEmployeeName, List<string> lstEmpName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rank 항목을 가져옵니다.
        /// </summary>
        /// <param name="strAPI"></param>
        /// <returns></returns>
        public static List<RankVO> GetRank(string strAPI)
        {
            var lstObject = new List<RankVO>();

            var response = ANBTX.Get(strAPI);

            if (response.IsSuccessStatusCode)
            {
                lstObject = response.Content.ReadAsAsync<List<RankVO>>().Result;
            }

            return lstObject;
        }

        /// <summary>
        /// Project 항목을 가져옵니다.
        /// </summary>
        /// <param name="strAPI"></param>
        /// <returns></returns>
        public static List<ProjectVO> GetProject(string strAPI)
        {
            var lstProject = new List<ProjectVO>();

            var response = ANBTX.Get(strAPI);

            if (response.IsSuccessStatusCode)
            {
                lstProject = response.Content.ReadAsAsync<List<ProjectVO>>().Result;
            }

            return lstProject;
        }

        /// <summary>
        /// Holiday 항목을 가져옵니다.
        /// </summary>
        /// <param name="strAPI"></param>
        /// <returns></returns>
        public static List<HolidayVO> GetHoliday(string strAPI)
        {
            var lstHoliday = new List<HolidayVO>();

            var response = ANBTX.Get(strAPI);

            if (response.IsSuccessStatusCode)
            {
                lstHoliday = response.Content.ReadAsAsync<List<HolidayVO>>().Result;
            }

            return lstHoliday;
        }

        /// <summary>
        /// Book 항목을 가져옵니다.
        /// </summary>
        /// <param name="strAPI"></param>
        /// <returns></returns>
        public static List<BookInfoVO> GetBook(string strAPI)
        {
            var lstBook = new List<BookInfoVO>();

            var response = ANBTX.Get(strAPI);

            if (response.IsSuccessStatusCode)
            {
                lstBook = response.Content.ReadAsAsync<List<BookInfoVO>>().Result;
            }

            return lstBook;
        }

        /// <summary>
        /// Book Rental 항목을 가져옵니다.
        /// </summary>
        /// <param name="strAPI"></param>
        /// <returns></returns>
        public static List<BookRentalVO> GetBookRental(string strAPI)
        {
            var lstBookRental = new List<BookRentalVO>();

            var response = ANBTX.Get(strAPI);

            if (response.IsSuccessStatusCode)
            {
                lstBookRental = response.Content.ReadAsAsync<List<BookRentalVO>>().Result;
            }

            return lstBookRental;
        }

        /// <summary>
        /// Book Rental 항목을 가져옵니다.
        /// </summary>
        /// <param name="strAPI"></param>
        /// <returns></returns>
        public static List<EquipmentVO> GetDevice(string strAPI)
        {
            var lstDevice = new List<EquipmentVO>();

            var response = ANBTX.Get(strAPI);

            if (response.IsSuccessStatusCode)
            {
                lstDevice = response.Content.ReadAsAsync<List<EquipmentVO>>().Result;
            }

            return lstDevice;
        }

        /// <summary>
        /// 지정된 콤보박스에 데이터를 입력합니다.
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="lstValue"></param>
        /// <param name="isAscending"></param>
        private static void SetComboBoxs(ComboBox combo, List<string> lstValue, bool isAscending = true)
        {
            if (lstValue.Any())
            {
                lstValue.OrderBy(o => o);
                combo.Items.Add("[None]");
                combo.Items.AddRange(lstValue.ToArray());
                combo.SelectedIndex = 0;
            }
        }
    }
}
