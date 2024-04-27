using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }

        public List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> List = new List<CategoryDTO>();
            string query = "select * from Category";
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {

                CategoryDTO category = new CategoryDTO(row);

                
                List.Add(category);
            }

            return List;
        }

    }
}
