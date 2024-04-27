using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> list = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.BillIfor where Bill_id = " + id);

            foreach (DataRow row in data.Rows)
            {
                BillInfo info = new BillInfo( row );

                list.Add(info);
            }

            return list;
        }

      

        public void InsertBillinfor(int idBill, int idFood, int Count)
        {
            DataProvider.Instance.ExcuteQuery("USP_InsertBillInfor @idBill , @idFood , @count  ", new object[] {idBill,idFood,Count}) ;
        }

    }
}
