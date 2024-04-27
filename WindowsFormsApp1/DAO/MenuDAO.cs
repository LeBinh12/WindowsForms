using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }

        public List<menu> GetListMenuTable(int id)
        {
            List<menu> list = new List<menu>();
            string query = "select f.Food_Name,bi.BillCount,f.Food_Price,f.Food_Price*bi.BillCount as totalPrice " +
                "from dbo.BillIfor as bi,dbo.Billtea as b,dbo.food as f " +
                "where bi.Bill_id = b.Bill_id and b.Bill_Status = 0 and bi.Food_id = f.Food_id and b.TableFood_id = "+id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                menu menu = new menu(row);
                list.Add(menu);
            }

            return list;
        }
    }
}
