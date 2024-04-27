using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Table
    {
        public Table(int id, string name, string status) { 
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["TableFood_id"];
            this.Name = row["TableFood_Name"].ToString();
            this.Status = row["TableFood_Status"].ToString();

        }


        private string name;
        private string status;
        private int iD;
        
        public int ID {
            get { return iD; }
            set {  iD = value; }
        }

        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
