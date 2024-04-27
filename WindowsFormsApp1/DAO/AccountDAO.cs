using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool login(string username, string password)
        {
            //  string query = "Select * from Users where UserName = N'"+ username +"' and UserPassword = N'"+ password +"'";

            //   DataTable result = DataProvider.Instance.ExcuteQuery(query);

            // bảo mặt dữ liệu bằng store procedure 
            // chống lỗi SQL Injection 
            string query = "USPP_Login @UserName , @UserPassword ";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {username,password});



            return result.Rows.Count > 0;
        }
    }
}
