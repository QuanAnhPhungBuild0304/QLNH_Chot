using NHAHANG_RIENG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHAHANG_RIENG.DAO
{
    public class CateryDAO
    {
        private static CateryDAO instance;

        public static CateryDAO Instance
        {
            get
            {
                if (instance == null) instance = new CateryDAO();
                return CateryDAO.instance;
            }
           private set => instance = value;
        }
        private CateryDAO() { }

        // Lấy ra ds catery ở trên combobox danh mục món ăn
        public List<Catery> GetListCatery()
        {
            List<Catery> list = new List<Catery>();

            string query = "select ID, NAME from FOODCATERY";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Catery catery = new Catery(item);
                list.Add(catery);
            }

            return list;
        }
        public Catery GetCateryById(int id)
        {
            Catery catery = null;
            string query = "select * from FoodCatery where ID =" + id;
            DataTable data;
            data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                catery = new Catery(item);
                return catery;
            }

            return catery;
        }
    }
}
