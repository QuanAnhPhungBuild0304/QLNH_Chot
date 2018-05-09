using NHAHANG_RIENG.DAO;
using NHAHANG_RIENG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHAHANG_RIENG
{
    public partial class DoanhThu : Form
    {
        private Account loginAcc;

        public Account LoginAcc { get => loginAcc; set => loginAcc = value; }

        public DoanhThu(Account acc )
        {
            InitializeComponent();
            this.loginAcc = acc;
            //LoadDatetimePicker();
            //LoadListBillByDate(dtp_in.Value, dtp_out.Value);
            
            LoadListBillByDate(dtp_in.Value, dtp_out.Value);
        }

        #region methors

        void LoadListBillByDate(DateTime checkin, DateTime checkout)
        {
           // LoadDatetimePicker();
            dgvThongke.DataSource = BillDAO.Instance.GetListBillByDate(checkin, checkout);
            btnDau.Text = "1";
            int tonghoadon = BillDAO.Instance.GetNumberBillByDate(checkin, checkout);
            txbLuotkhach.Text = tonghoadon.ToString();

            string thanhtienHD = "";
            string thanhtienTT = "";

            thanhtienHD = BillDAO.Instance.TotalPrices_HD(checkin, checkout);
            thanhtienTT = BillDAO.Instance.TotalPrices_TT(checkin, checkout);

            txbTongthuHoadon.Text = thanhtienHD.ToString();
            txbTongthuThucte.Text = thanhtienTT.ToString();

            // 1 trang có 5 dòng
            int trangcuoi = tonghoadon / 5;
            if (tonghoadon % 5 != 0)
                trangcuoi++;
            btnCuoi.Text = trangcuoi.ToString();
        }

        // Load 
        void LoadDatetimePicker()
        {
            DateTime today = DateTime.Now;
            dtp_in.Value = new DateTime(today.Year, today.Month, 01);
            today.AddHours(00);
            dtp_out.Value = dtp_in.Value.AddMonths(1).AddDays(-1);
        }

        #endregion


        #region events
        private void btQuaylai_Click(object sender, EventArgs e)
        {
            TrangchuAdmin tc = new TrangchuAdmin(loginAcc);
            this.Hide();
            tc.ShowDialog();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            LoadDatetimePicker();
            LoadListBillByDate(dtp_in.Value, dtp_out.Value);

            
        }

        private void btThongke_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtp_in.Value, dtp_out.Value);
        }


        private void btnDau_Click(object sender, EventArgs e)
        {

            txbTrangHientai.Text = "1";
        }

        private void btCuoi_Click(object sender, EventArgs e)
        {
            int tonghoadon = BillDAO.Instance.GetNumberBillByDate(dtp_in.Value, dtp_out.Value);
            // 1 trang có 5 dòng
            int trangcuoi = tonghoadon / 5;
            if (tonghoadon % 5 != 0)
                trangcuoi++;
            txbTrangHientai.Text = trangcuoi.ToString();
        }

        private void txbTrangHientai_TextChanged(object sender, EventArgs e)
        {
            dgvThongke.DataSource = BillDAO.Instance.GetListBillByDate_inPage(dtp_in.Value, dtp_out.Value, Convert.ToInt32(txbTrangHientai.Text));
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbTrangHientai.Text);
            if (page > 1)
                page--;
            txbTrangHientai.Text = page.ToString();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbTrangHientai.Text);
            int tonghoadon = BillDAO.Instance.GetNumberBillByDate(dtp_in.Value, dtp_out.Value);
            // 1 trang có 5 hóa đơn
            if (page * 5 < tonghoadon)
                page++;
            txbTrangHientai.Text = page.ToString();
        }

        private void txbLuotkhach_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private void txbTongthu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
