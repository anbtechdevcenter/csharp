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
    public partial class FrmBookMag : Form
    {

        string API_URL_BOOK = "/api/book";
        string API_URL_BOOK_RENTAL = "/api/bookRental";

        public FrmBookMag()
        {
            InitializeComponent();
            InitControll();
        }

        private void InitControll()
        {
            getBookList();
        }

        private void getBookList()
        {
            try
            {
                var lstBook = ANBTX_Common.GetBook(API_URL_BOOK);
                if(lstBook == null || lstBook.Count == 0)
                {
                    MessageBox.Show("Ther is no Data");
                    return;
                }
                makeData(lstBook);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
            }
        }

        private void makeData(List<BookInfoVO> lstBook)
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

            IEnumerable<BookInfoVO> Query = from n in lstBook
                                            select n;
            foreach (BookInfoVO k in Query)
            {
                dr = dt.NewRow();

                dr["도서명"] = k.bookName;
                dr["출판사"] = k.publisher;
                dr["저자"] = k.author;
                dr["등록일"] = k.registDate;

                dt.Rows.Add(dr);
            }
            grdBook.DataSource = dt;
        }

    }
}
