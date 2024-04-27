using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Food
    {

        public Food(int id, string name , int CategoryID, float Price) {
            this.ID = id;   
            this.Name = name;
            this.CategoryID1 = CategoryID;
            this.Price = Price;
        
        }

        public Food(DataRow row)
        {
            this.iD = (int)row["Food_id"];
            this.Name = row["Food_Name"].ToString();
            this.Price1 = (float)Convert.ToDouble(row["Food_Price"].ToString());// ep kieu 
            this.CategoryID1 = (int)row["Category_id"]; 
        }

        private int iD;
        private string name;
        private int CategoryID;
        private float Price;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryID1 { get => CategoryID; set => CategoryID = value; }
        public float Price1 { get => Price; set => Price = value; }
    }
}
