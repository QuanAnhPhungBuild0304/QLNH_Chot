using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using NHAHANG_RIENG.DTO;

namespace NHAHANG_RIENG.DAO
{
   public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get
            { 
                if (instance == null) instance = new TableDAO();
                return TableDAO.instance;
            }
             private set { TableDAO.instance = value; }
        }
        public static int TableWidth = 110;
        public static int TableHieght = 110;




        public List<Table> LoadtableList()
        {
            List<Table> tablelist = new List<Table>();
            DataTable data;
            data = DataProvider.Instance.ExcuteQuery("USP_GetTableList");

            foreach(DataRow item in data.Rows)
            {
                Table table =new Table(item);
                tablelist.Add(table);
            }

            return tablelist;
        }

        // hàm đổi chuyển  2 bàn cho nhau
       public void SwitchTable (int idtable1, int idtable2)
        {
            DataProvider.Instance.ExcuteQuery("USP_SWITCHTABLE @IDTABLE_1 , @IDTABLE_2", new object[] {idtable1, idtable2});
        }
    }
}










