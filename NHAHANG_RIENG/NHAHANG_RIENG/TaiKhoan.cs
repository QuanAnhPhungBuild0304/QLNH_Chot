using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NHAHANG_RIENG.DAO;
using NHAHANG_RIENG.DTO;

namespace NHAHANG_RIENG
{
    public partial class TaiKhoan : Form
    {
        private Account loginAcc;

        public Account LoginAcc { get => loginAcc; set => loginAcc = value; }

        BindingSource accountlist = new BindingSource();

        public TaiKhoan(Account acc)
        {
            InitializeComponent();
            this.loginAcc = acc;
            LoadAccount();
           
         
        }

        private void btQuaylai_Click(object sender, EventArgs e)
        {
            TrangchuAdmin tc = new TrangchuAdmin(loginAcc);
            this.Hide();
            tc.ShowDialog();
        }
       
        void AccountBingding()
        {
            txbFullname.DataBindings.Add(new Binding("Text", dgvACC.DataSource, "FULLNAME", true, DataSourceUpdateMode.Never));
            txbUsername.DataBindings.Add(new Binding("Text", dgvACC.DataSource, "USERNAME", true, DataSourceUpdateMode.Never));
            nudPhanquyen.DataBindings.Add(new Binding("value", dgvACC.DataSource,"TYPE", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountlist.DataSource = AccountDAO.Instance.GetListAccount();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            dgvACC.DataSource = accountlist;
            LoadAccount();
            AccountBingding();
        }

        private void btXemTk_Click(object sender, EventArgs e)
        {

        }

        void AddAccount(string fullname, string username, int type)
        {
            if(AccountDAO.Instance.InsertAccount(username, fullname, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
                MessageBox.Show("Thêm tài khoản không thành công");
            LoadAccount();
        }

        void EditAccount(string fullname, string username, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(username, fullname, type))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
                MessageBox.Show("Sửa tài khoản không thành công");
            LoadAccount();
        }

        void DeleteAccount(string username)
        {
            if (MessageBox.Show(String.Format("Chắc chắn xóa tài khoản : {0}?", username.ToUpper(), "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == System.Windows.Forms.DialogResult.OK)
            {
                if (!username.Equals(loginAcc.UserName))
                {
                    if (AccountDAO.Instance.DeleteAccount(username))
                    {
                        MessageBox.Show("Xóa tài khoản thành công");
                    }
                    else
                        MessageBox.Show("Xóa tài khoản không thành công");
                }
                else
                    MessageBox.Show("Không thể xóa chính bạn :D ","Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    //MessageBox.Show(String.Format("Tài khoản : {0} chính là tài khoản đang đăng nhập! Không thể xóa!", username, "Cảnh báo!",MessageBoxButtons.OK, MessageBoxIcon.Error));
            }           
            LoadAccount();
        }

        void ResetPass( string username)
        {
          
            if (MessageBox.Show(String.Format("Đặt lại mật khẩu cho tài khoản : {0}?", username.ToUpper(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == System.Windows.Forms.DialogResult.OK)
            {
                if (AccountDAO.Instance.ResetPassword(username))
                {
                    MessageBox.Show("Reset mật khẩu thành công");
                }
                else
                    MessageBox.Show("Reset mật khẩu không thành công");
            }
                
            LoadAccount();
        }

        private void btThemTk_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string fullname = txbFullname.Text;
            int type = (int)nudPhanquyen.Value;
            AddAccount(fullname,username,type);
        }

        private void btSuaTk_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string fullname = txbFullname.Text;
            int type = (int)nudPhanquyen.Value;
            EditAccount(fullname, username, type);
        }

        private void btXoaTk_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            
            DeleteAccount(username);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            ResetPass(username);
        }
    }
}
