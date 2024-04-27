using System;
using System.Collections.Generic;   
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class DataProvider
    {

        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get {  if (instance == null) instance = new DataProvider();return DataProvider.instance; }
            private set { DataProvider.Instance = value; }
        }

        private DataProvider() { }




        private string ConnectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLTS;Integrated Security=True";


        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            //chứa dữ liệu kết quả truy vấn
            DataTable data = new DataTable();
            //kết thúc thì dữ liệu sẽ tự giải phóng
            using (SqlConnection conn = new SqlConnection(ConnectionSTR))
            {



                conn.Open();
                //Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                //Thực hiện truy vấn và lấy dữ liệu từ DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //Thực hiện truy vấn
                adapter.Fill(data);

                conn.Close();

            }
            return data;

        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            //kết thúc thì dữ liệu sẽ tự giải phóng
            using (SqlConnection conn = new SqlConnection(ConnectionSTR))
            {



                conn.Open();
                //Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                //Thực hiện truy vấn và lấy dữ liệu từ DataTable
                data = command.ExecuteNonQuery();

                conn.Close();

            }
            return data;



        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            //kết thúc thì dữ liệu sẽ tự giải phóng
            using (SqlConnection conn = new SqlConnection(ConnectionSTR))
            {



                conn.Open();
                //Thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                //Thực hiện truy vấn và lấy dữ liệu từ DataTable
                data = command.ExecuteScalar();
                conn.Close();

            }
            return data;
        }
    }
}
