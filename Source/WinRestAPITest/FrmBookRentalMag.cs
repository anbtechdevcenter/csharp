using AnBTech.RestAPI.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnBTech.RestAPI
{
    public partial class FrmBookRentalMag : Form
    {
        public string API_URL_BOOK_RENTAL = "/api/bookRental";

        public FrmBookRentalMag()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            getBookRentalList();
        }

        private void getBookRentalList()
        {
            try
            {
                var lstBookRental = ANBTX_Common.GetBookRental(API_URL_BOOK_RENTAL);
                if (lstBookRental == null || lstBookRental.Count == 0)
                {
                    MessageBox.Show("Ther is no Data");
                    return;
                }
                makeData(lstBookRental);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
            }
        }

        private void makeData(List<BookRentalVO> lstBookRental)
        {
            DataTable dt = new DataTable();
            DataRow dr;

            DataColumn colNo = dt.Columns.Add("NO", typeof(Int32));
            colNo.AutoIncrement = true;
            colNo.AutoIncrementSeed = 1;
            colNo.AutoIncrementStep = 1;
            DataColumn colBookNm = dt.Columns.Add("도서명", typeof(string));
            DataColumn colBookPul = dt.Columns.Add("출판사", typeof(string));
            DataColumn colBookAut = dt.Columns.Add("저자", typeof(string));
            DataColumn colRegDate = dt.Columns.Add("등록일", typeof(string));

            IEnumerable<BookRentalVO> Query = from n in lstBookRental
                                              select n;
            foreach (BookRentalVO k in Query)
            {
                dr = dt.NewRow();

                dt.Rows.Add(dr);
            }
            grdBookRental.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
