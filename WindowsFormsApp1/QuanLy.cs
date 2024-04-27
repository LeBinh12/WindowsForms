using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
            LoadTable();
            loadCategory();
            loadComboBoxTable(cbSwitchTable);
        }

        #region Method 


        void loadCategory()
        {
            List<CategoryDTO> listCategory = CategoryDAO.Instance.GetListCategory();
            Category.DataSource = listCategory;
            Category.DisplayMember = "Name";
            
        }
        void loadListByCategoryID(int id)
        {
            List<Food> ListFood = FoodDAO.Instance.GetFoodListByCategoryId(id);
            cbTea.DataSource = ListFood;
            cbTea.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flqTable.Controls.Clear();
            

          List<Table> tableList = TableDAO.Instance.loadTableList();

        foreach (Table table in tableList)
            {
                Button button = new Button() { Width = TableDAO.TableWith, Height = TableDAO.TableHeight };
                button.Text = table.Name + Environment.NewLine + table.Status;
                button.Click += button1_Click;
                button.Tag = table;

                switch (table.Status)
                {
                    case "Trống":
                        button.BackColor = Color.Green;
                        break;
                    default:
                        button.BackColor = Color.BlueViolet;
                        break;
                }

                flqTable.Controls.Add(button);
            }

        }
        void ShowBill(int id)
        {
            Bill.Items.Clear();

            List<menu> listBillInfo = MenuDAO.Instance.GetListMenuTable(id);
            float totalPrice = 0;
            foreach (menu info in listBillInfo)
            {
                ListViewItem Lvitem = new ListViewItem(info.FoodName1.ToString());
                Lvitem.SubItems.Add(info.Count.ToString());
                Lvitem.SubItems.Add(info.Price.ToString());
                Lvitem.SubItems.Add(info.TotalPrice.ToString());
                totalPrice += info.TotalPrice;
                Bill.Items.Add(Lvitem);



                
            }
            CultureInfo cul = new CultureInfo("vi-VN"); // thay doi tien $ sang đ 

            Thread.CurrentThread.CurrentCulture = cul; //thay đổi luồng đang chạy thành luông cul

            txtTotalPrice.Text = totalPrice.ToString("c"); // hiện đơn vị tiền tệ

           


        }

        private void Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if(cb.SelectedItem == null)
                return;
            
            CategoryDTO selected = cb.SelectedItem as CategoryDTO;

            id = selected.ID;

            loadListByCategoryID(id);
        }

        private void AddTea_Click(object sender, EventArgs e)
        {
            Table table = Bill.Tag as Table;

            int idBill = BillDAo.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbTea.SelectedItem as Food).ID;
            int count = (int)TeaCount.Value;



            if(idBill == -1)
            {
                BillDAo.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillinfor(BillDAo.Instance.GetMaxIDBill(),foodID,count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillinfor(idBill, foodID, count);

            }
            ShowBill(table.ID);
            LoadTable();


        }
        private void CheckOut_Click(object sender, EventArgs e)
        {
            Table table =Bill.Tag as Table;
            int idBill = BillDAo.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)mnDisCount.Value;

            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)
            {
                if(MessageBox.Show(string.Format("Bạn muons thanh toán hóa đơn cho bàn {0}\n Tổng tiền - Giảm giá = {1} - ({1}/100)x{2} = {3}",table.Name,totalPrice,discount,finalTotalPrice),"Thông Báo",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAo.Instance.CheckOut(idBill,discount);
                    ShowBill(table.ID);
                    LoadTable();
                    


                }

            }
        }
        void loadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.loadTableList();
            cb.DisplayMember = "Name";
        }   
        #endregion

        #region Event



        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAccount f = new FAccount();
            f.ShowDialog();

        }

        private void TeaCount_ValueChanged(object sender, EventArgs e)
        {

        }

        void button1_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).ID;
            Bill.Tag = (sender as Button).Tag ;
            ShowBill(TableID);

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin a = new fAdmin();
            a.ShowDialog();

        }

        private void Table_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (Bill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn không {0} sang bàn {1} không", (Bill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                TableDAO.Instance.switchTable(id1, id2);

                LoadTable();
            }
        }
        #endregion

        private void Bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }

        
    }
}
