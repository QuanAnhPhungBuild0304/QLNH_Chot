using NHAHANG_RIENG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHAHANG_RIENG
{
    public partial class TrangchuAdmin : Form
    {

        private Account loginAcc;

        public Account LoginAcc { get => loginAcc; set => loginAcc = value; }
       
        public TrangchuAdmin(Account acc)
        {
            InitializeComponent();
            this.LoginAcc = acc;
            lbstatus.Text = loginAcc.FullName.ToString() + " !";
        }

        #region event
        private void btqlban_Click(object sender, EventArgs e)
        {
            BanMon bm = new BanMon(loginAcc);
            this.Hide();
            bm.ShowDialog();
        }

        private void btDoanhthu_Click(object sender, EventArgs e)
        {
            DoanhThu dt = new DoanhThu(loginAcc);
            this.Hide();
            dt.ShowDialog();
        }

        private void btqlmon_Click(object sender, EventArgs e)
        {
            MonAn ma = new MonAn(loginAcc);
            this.Hide();
            ma.ShowDialog();
        }

        private void btuser_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(loginAcc);
            this.Hide();
            tk.ShowDialog();
        }

        private void ctlLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void TrangchuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountInfo acc = new AccountInfo(loginAcc);
            this.Hide();
            acc.ShowDialog();
        }
        #endregion

        private void lbstatus_Click(object sender, EventArgs e)
        {
            AccountInfo accinfo = new AccountInfo(loginAcc);
            accinfo.UpdateAccount += accinfo_UpdateAccount;
            accinfo.ShowDialog();
        }
        void accinfo_UpdateAccount(object sender, AccountEvent e)
        {

            lbstatus.Text = e.Acc.FullName.ToString() + " !" ;
        }
    }
}
