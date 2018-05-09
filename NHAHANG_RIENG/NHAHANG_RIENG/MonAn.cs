using NHAHANG_RIENG.DAO;
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
    public partial class MonAn : Form
    {
        private Account loginAcc;

        public Account LoginAcc { get => loginAcc; set => loginAcc = value; }

        BindingSource foodlist = new BindingSource();

        public MonAn(Account acc)
        {
            InitializeComponent();
            this.loginAcc = acc;
            LoadCateryInCombobox(cbxDanhmuc);
        }

        #region methors

        public void AddBindingFood()
        {
            // - kiểu - sourse - tên cột - true: tự động ép kiểu - never: sửa bên txb nhưng không thay đổi bên dgv
            txbID.DataBindings.Add(new Binding("text", dgvMonAn.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbTenMon.DataBindings.Add(new Binding("text", dgvMonAn.DataSource, "NAME", true, DataSourceUpdateMode.Never));
            nudGia.DataBindings.Add(new Binding("Value", dgvMonAn.DataSource, "GIA", true, DataSourceUpdateMode.Never));

        }

        public void LoadCateryInCombobox(ComboBox cbx)
        {
            cbx.DataSource = CateryDAO.Instance.GetListCatery();
            cbx.DisplayMember = "NAME";
        }


        public void LoadListFood()
        {
            dgvMonAn.DataSource = FoodDAO.Instance.GetListFood();
        }

        public void LoadListCatery()
        {
           // dgvDanhMuc.DataSource = CateryDAO.Instance.GetListCatery();
        }

        List<Food> SearchFood(string name)
        {
            List<Food> listfood = new List<Food>();
            FoodDAO.Instance.SearchFoodByName(name);


            return listfood;
        }
        #endregion



        #region event

        private void btTimkiem_Click(object sender, EventArgs e)
        {
           foodlist.DataSource = SearchFood(txbTimkiem.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btQuaylai_Click(object sender, EventArgs e)
        {
           TrangchuAdmin tc = new TrangchuAdmin(loginAcc);
            this.Hide();
            tc.ShowDialog();
        }

        private void dgvThongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MonAn_Load(object sender, EventArgs e)
        {
            dgvMonAn.DataSource = foodlist;
            foodlist.DataSource = FoodDAO.Instance.GetListFood();
           
            LoadCateryInCombobox(cbxDanhmuc);
            AddBindingFood();
            LoadListCatery();
        }


        // binding cbx Danh mục món ăn
        private void txb(object sender, EventArgs e)
        {
            try
            {

                if (dgvMonAn.SelectedCells.Count > 0)
                {
                    int id = (int)dgvMonAn.SelectedCells[0].OwningRow.Cells["LoaiMon"].Value;

                    Catery catery = CateryDAO.Instance.GetCateryById(id);

                    cbxDanhmuc.SelectedItem = catery;

                    int index = -1;
                    int i = 0;
                    foreach (Catery item in cbxDanhmuc.Items)
                    {

                        if (item.ID == catery.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbxDanhmuc.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            string name = txbTenMon.Text;
            int idcatery = (cbxDanhmuc.SelectedItem as Catery).ID;
            float gia = (float)nudGia.Value;

            if (FoodDAO.Instance.InsertFood(name, idcatery, gia))
            {
                MessageBox.Show("Thêm món thành công", "Thông báo");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm món ăn không thành công");
            }
        }

        private void btSuamon_Click(object sender, EventArgs e)
        {

            string name = txbTenMon.Text;
            int idcatery = (cbxDanhmuc.SelectedItem as Catery).ID;
            float gia = (float)nudGia.Value;
            int id = Convert.ToInt32(txbID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, idcatery, gia))
            {
                MessageBox.Show("Sửa món thành công", "Thông báo");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa món ăn không thành công");
            }
        }

        private void btXoamon_Click(object sender, EventArgs e)
        {
            string name = txbTenMon.Text;
            int id = Convert.ToInt32(txbID.Text);


            if (MessageBox.Show(String.Format("Chắc chắn xóa món {0}?",name, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == System.Windows.Forms.DialogResult.Yes)
            {
                if (FoodDAO.Instance.DeleteFood(id))
                {
                    MessageBox.Show("Xóa món thành công", "Thông báo");
                    LoadListFood();
                    if (deleteFood != null)
                        deleteFood(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Xóa món ăn không thành công");
                }
            }
            
        }



        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }


       
        #endregion


    }
}
