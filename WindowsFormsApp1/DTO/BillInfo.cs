using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class BillInfo
    {

        public BillInfo(int id, int BillID, int foodID, int count) { 
            this.ID = id;
            this.BillID = BillID;
            this.foodId = foodID;
            this.count = count;
        }

        public BillInfo(DataRow row) {
            this.ID = (int)row["BillInfor_id"];
            this.BillID = (int)row["Bill_id"];
            this.foodId = (int)row["Food_id"];
            this.count = (int)row["BillCount"];
        }


        private int count;
        private int billID;
        private int foodId;

        private int ID;

        public int ID1 { get => ID; set => ID = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodId { get => foodId; set => foodId = value; }
        public int Count { get => count; set => count = value; }
    }
}
