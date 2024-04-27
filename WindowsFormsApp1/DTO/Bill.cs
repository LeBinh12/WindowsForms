using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Bill
    {
        public Bill(int id , DateTime? CheckIn, DateTime? CheckOut , int status, int discount) { 
            this.ID = id;
            this.dateCkeckIn = CheckIn;
            this.dateCkeckOut = CheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row) {
            this.ID = (int)row["Bill_id"];
            this.dateCkeckIn = (DateTime?)row["DateCheckin"];
            var dateCheckOutTemp = row["DateCheckout"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.dateCkeckOut = (DateTime?)dateCheckOutTemp;
            }
         
            this.Status = (int)row["Bill_Status"];
            this.Discount = (int)row["discount"];


        }


        private DateTime? dateCkeckIn;
        private DateTime? dateCkeckOut;
        private int status;
        private int iD;
        private int discount;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCkeckIn { get => dateCkeckIn; set => dateCkeckIn = value; }
        public DateTime? DateCkeckOut { get => dateCkeckOut; set => dateCkeckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
