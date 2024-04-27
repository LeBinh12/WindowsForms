using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodListByCategoryId(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from food where Category_id = " + id ;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);


            foreach (DataRow row in data.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }

            return list;
        }
    }
}
