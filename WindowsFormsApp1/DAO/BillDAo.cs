using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class BillDAo
    {
        private static BillDAo instance;
        public static BillDAo Instance
        {
            get { if (instance == null) instance = new BillDAo(); return BillDAo.instance; }
            private set { BillDAo.instance = value; }
        }
        private BillDAo() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.Billtea where TableFood_id= " + id + " and Bill_Status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;

            }
            else
            {
                return -1;
            }
        }
        public void InsertBill(int id)
        {   
            DataProvider.Instance.ExcuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public void CheckOut(int id,int discount)
        {
            string query = "update dbo.Billtea set Bill_Status = 1,"+" discount ="+discount+" where Bill_id = " + id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("select MAX(Bill_id) From dbo.Billtea\r\n");
            }

            catch
            {
                return 1;
            }


        }
    }
}