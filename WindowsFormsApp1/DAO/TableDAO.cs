using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance { 
            get { if (instance == null) instance = new TableDAO();return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWith = 90;
        public static int TableHeight = 90;

        private TableDAO() { }

        public void switchTable(int id1, int id2)
        {
            DataProvider.Instance.ExcuteQuery("sp_switchTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }


        public List<Table> loadTableList()
        {
            List<Table> list = new List<Table>();

            DataTable data = DataProvider.Instance.ExcuteQuery("dbo.USP_GetTableList");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                list.Add(table);
            }

            return list;
        }
    }
}
