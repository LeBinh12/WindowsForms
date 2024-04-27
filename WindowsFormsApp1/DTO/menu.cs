using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
     public  class menu
    {
        public menu ( string foodName , int count, float price, float totalPrice = 0) { 
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public menu(DataRow row) {
            this.FoodName = row["Food_Name"].ToString();
            this.Count = (int)row["BillCount"];
            this.Price = (float)Convert.ToDouble(row["Food_Price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private float totalPrice;
        private float price;
        private int count;

        private string FoodName;

        public string FoodName1 { get => FoodName; set => FoodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
