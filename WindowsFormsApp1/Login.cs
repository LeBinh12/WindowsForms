using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            if (login(username, password)) {
                QuanLy q = new QuanLy();
                this.Hide();
                q.ShowDialog(); //ShowDiaLog là top mode
                this.Show();
            }

            else
            {
                MessageBox.Show("Tài Khoản hoặc mặt khẩu không chính xác!");
            }

        }

        bool login(string username, string password)
        {
            return AccountDAO.Instance.login(username,password);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
