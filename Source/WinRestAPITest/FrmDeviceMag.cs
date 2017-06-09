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
    public partial class FrmDeviceMag : Form
    {
        readonly string API_URL_DEVICE = "/api/device";

        public FrmDeviceMag()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            getDevice();
        }

        private void getDevice()
        {
            try
            {
                var lstDevice = ANBTX_Common.GetDevice(API_URL_DEVICE);
                if (lstDevice == null || lstDevice.Count == 0)
                {
                    MessageBox.Show("There is no data.");
                    return;
                }
                makeData(lstDevice);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred :" + ex.ToString());
            }
        }

        private void makeData(List<EquipmentVO> lstDevice)
        {
            DataTable dt = new DataTable();
            DataRow dr;

            DataColumn colNo = dt.Columns.Add("NO", typeof(Int32));
            colNo.AutoIncrement = true;
            colNo.AutoIncrementSeed = 1;
            colNo.AutoIncrementStep = 1;
            DataColumn colDeviceModelNm = dt.Columns.Add("모델명", typeof(string));
            DataColumn colDeviceNm = dt.Columns.Add("장비명", typeof(string));
            DataColumn colSerialNum = dt.Columns.Add("시리얼번호", typeof(string));
            DataColumn colDeviceState = dt.Columns.Add("장비상태", typeof(string));
            DataColumn colDeviceType = dt.Columns.Add("장비구분", typeof(string));
            DataColumn colDisposalDt = dt.Columns.Add("폐기일자", typeof(string));
            DataColumn colMakerId = dt.Columns.Add("제조사코드", typeof(string));
            DataColumn colMakerNm = dt.Columns.Add("제조사명", typeof(string));
            DataColumn colPurchaseDt = dt.Columns.Add("구입일", typeof(string));
            DataColumn colRentalStrDt = dt.Columns.Add("지급일", typeof(string));
            DataColumn colRentalEmpId = dt.Columns.Add("사용자사번", typeof(string));
            DataColumn colRentalEndDt = dt.Columns.Add("반납일", typeof(string));
            DataColumn colDeviceSeq = dt.Columns.Add("장비순번", typeof(string));
            DataColumn colBringProof = dt.Columns.Add("반납증여부", typeof(string));
            DataColumn colDesc01 = dt.Columns.Add("CPU", typeof(string));
            DataColumn colDesc02 = dt.Columns.Add("Memory", typeof(string));
            DataColumn colDesc03 = dt.Columns.Add("HDD", typeof(string));
            DataColumn colDesc04 = dt.Columns.Add("SSD", typeof(string));
            DataColumn colDesc05 = dt.Columns.Add("유선 MAC 주소", typeof(string));
            DataColumn colDesc06 = dt.Columns.Add("무선 MAC 주소", typeof(string));

            IEnumerable<EquipmentVO> Query = from n in lstDevice
                                             select n;

            foreach (EquipmentVO k in Query)
            {
                dr = dt.NewRow();

                dr["모델명"] = k.deviceModel;
                dr["장비명"] = k.deviceName;
                dr["시리얼번호"] = k.deviceSn;
                dr["장비상태"] = k.deviceState;
                dr["장비구분"] = k.deviceType;
                dr["폐기일자"] = k.disposalDate;
                dr["제조사코드"] = k.makersId;
                dr["제조사명"] = k.makersName;
                dr["구입일"] = k.purchaseDate;
                dr["지급일"] = k.rentalEdate;
                dr["사용자사번"] = k.rentalEmpId;
                dr["반납일"] = k.rentalSdate;
                dr["장비순번"] = k.seqDevice;
                dr["반납증여부"] = k.bringProof;
                dr["CPU"] = k.desc01;
                dr["Memory"] = k.desc02;
                dr["HDD"] = k.desc03;
                dr["SSD"] = k.desc04;
                dr["유선 MAC 주소"] = k.desc05;
                dr["무선 MAC 주소"] = k.desc06;

                dt.Rows.Add(dr);
            }
            grdDevice.DataSource = dt;
        }
    }
}
