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
    public partial class BanMon : Form
    {
        private Account loginAcc;

        public Account LoginAcc { get => loginAcc; set => loginAcc = value; }

        public BanMon(Account acc)
        {
            InitializeComponent();
            this.loginAcc = acc;
            ShowStatus(loginAcc.Type);
            LoadTable();
            LoadCatery();
            LoadComboboxTable(cbxChuyenban);
        }

        #region Mothor
        // Hàm đưa ds bàn ra cbx chuyển bàn
        void LoadComboboxTable(ComboBox cbx)
        {
            cbx.DataSource = TableDAO.Instance.LoadtableList();
            cbx.DisplayMember = "Name";
        }

        // Đưa ra tên user ở đầu form
        void ShowStatus(int type)
        {
            if (LoginAcc.Type == 0)
            {
                panelSetUser.Visible = true;
                panelQuayLai.Visible = false;
                panelStatus.Visible = true;
                lbStatus.Text = loginAcc.FullName.ToString() + " !";
            }
            else
            {
                panelStatus.Visible = false;
                panelQuayLai.Visible = true;
                panelSetUser.Visible = false;
            }
        }

        // mỗi khi nhấn vào Loại món ăn thì sẽ phải load lại và đưa Danh mục món ăn ra cbx Danh mục
        void LoadCatery()
        {
            List<Catery> listCatery = CateryDAO.Instance.GetListCatery();
            cbxLoaimon.DataSource = listCatery;
            cbxLoaimon.DisplayMember ="NAME";
        }

        // Lấy ds món ăn đưu ra conbobox sao cho food.idcatery = foodcatery.id
        void LoadFoodListByCateryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCateryID(id);
            cbxMon.DataSource = listFood;
            cbxMon.DisplayMember = "NAME";
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tablelist;
            tablelist = TableDAO.Instance.LoadtableList(); // lấy ds table
            foreach ( Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHieght };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click; // click vào btn thì làm event btn_ckick
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Gold;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            ltvhoadon.Items.Clear();
            float Thanhtien =0;
            List<NHAHANG_RIENG.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            foreach (NHAHANG_RIENG.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.TongTien.ToString());
                Thanhtien += item.TongTien;
                ltvhoadon.Items.Add(lsvItem);
            }
            //CultureInfo culture = new CultureInfo("VI-VN");

            //lbShowTien.Text = Thanhtien.ToString("c",culture);
            // txbshowtien.Text = Thanhtien.ToString("c", culture);
            txbshowtien.Text = Thanhtien.ToString();
        }

        #endregion

        #region Events
        private void btQuaylai_Click(object sender, EventArgs e)
        {

            TrangchuAdmin tc = new TrangchuAdmin(loginAcc);
            this.Hide();
            tc.ShowDialog();
        }

        private void BanMon_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ltvhoadon.Tag = (sender as Button).Tag;
            ShowBill(tableID);

        }
       
        private void ftpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ltvhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxLoaimon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if(cb.SelectedItem == null)
            {
                return;
            }

            Catery selected = cb.SelectedItem as Catery;
            id = selected.ID;

            LoadFoodListByCateryID(id);
        }

        private void btAddMon_Click(object sender, EventArgs e)
        {
            Table table = ltvhoadon.Tag as Table;
            int billID = BillDAO.Instance.GetUncheckBillIdByTableID(table.ID);

            int foodID = (cbxMon.SelectedItem as Food).ID;
            int count = (int)nudSlg.Value;
            // chưa tồn tại Bill
            if (billID == -1)
            {
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);               
            }
            
            else
            {              
                    BillInfoDAO.Instance.InsertBillInfo(billID, foodID, count);
                             
            }
            ShowBill(table.ID);
            LoadTable();

        }


        private void btThanhtoan_Click(object sender, EventArgs e)
        {
            Table table = ltvhoadon.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIdByTableID(table.ID);
            int giamgia = (int)nudGiamgia.Value;
            double tongtien_hoadon = Convert.ToDouble(txbshowtien.Text);           
            //double tongtien_hoadon = Convert.ToDouble(txbshowtien.Text.Split(',')[0]);
            //double tongtien_hoadon = double.Parse(txbshowtien.Text, NumberStyles.Currency);
            double tien_giamgia = (tongtien_hoadon / 100) * giamgia;
            double tongtien_thucte = tongtien_hoadon - tien_giamgia;
            

            if (idBill !=1)
            {
                if (MessageBox.Show(String.Format("Thanh toán hóa đơn cho {0}?\n Tổng tiền: {1} VNĐ\n Giảm giá: {2}% Tức: {3} VNĐ\n Cần thanh toán: {4} VNĐ",table.Name,tongtien_hoadon,giamgia,tien_giamgia,tongtien_thucte), "Thông báo",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
                {
                    //HoaDon hd = new HoaDon();
                    //hd.ShowDialog();
                    BillDAO.Instance.CheckOut(idBill,giamgia,(float)tongtien_hoadon,(float)tongtien_thucte);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }          
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ĐĂNG XUẤT sẽ kết thúc phiên làm việc của bạn. Yes?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Login lg = new Login();
                this.Hide();
                lg.ShowDialog();
            }

        }

        private void BanMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountInfo accinfo = new AccountInfo(loginAcc);
            this.Hide();
            accinfo.ShowDialog();
            
        }

        private void btXoaMon_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = ltvhoadon.Tag as Table;
                int billID = BillDAO.Instance.GetUncheckBillIdByTableID(table.ID);

                int foodID = (cbxMon.SelectedItem as Food).ID;
                int countFood = (cbxMon.SelectedItem as Bill).ID;
                int count = (int)nubXoaMon.Value;

                if (foodID != null)
                {
                    BillInfoDAO.Instance.InsertBillInfo(billID, foodID, count);
                }

                ShowBill(table.ID);
                LoadTable();
            }
            catch { }
            
        }

        private void btGiamgia_Click(object sender, EventArgs e)
        {

        }

        private void btChuyenban_Click(object sender, EventArgs e)
        {
            // lấy được id bàn 1 là từ bàn đang được chọn.
            int idtable1 = (ltvhoadon.Tag as Table).ID;

            // id bàn 2 là chọn từ combobox
            int idtable2 = (cbxChuyenban.SelectedItem as Table).ID;

            // thông báo chueyern bàn
            if (MessageBox.Show(String.Format("      THÔNG BÁO CHUYỂN BÀN:\n - Chuyển {0} sang {1}. YES / NO ?", (ltvhoadon.Tag as Table).Name, (cbxChuyenban.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                TableDAO.Instance.SwitchTable(idtable1, idtable2);

                LoadTable();
            }
        }

        #endregion

    }
}
