using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class CategoryDTO
    {
        public CategoryDTO(int id, string name) {
            this.name = name;
            this.iD = id;
        }

        public CategoryDTO(DataRow row) { 
            this.name = row["Category_Name"].ToString();
            this.iD = (int)row["Category_id"];
        }

        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
