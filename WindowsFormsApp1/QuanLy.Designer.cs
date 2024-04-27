namespace WindowsFormsApp1
{
    partial class QuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.mnDisCount = new System.Windows.Forms.NumericUpDown();
            this.DisCount = new System.Windows.Forms.Button();
            this.CheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TeaCount = new System.Windows.Forms.NumericUpDown();
            this.AddTea = new System.Windows.Forms.Button();
            this.cbTea = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.flqTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnDisCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeaCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin Tài Khoản";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Bill);
            this.panel2.Location = new System.Drawing.Point(604, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 316);
            this.panel2.TabIndex = 2;
            // 
            // Bill
            // 
            this.Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Bill.GridLines = true;
            this.Bill.HideSelection = false;
            this.Bill.Location = new System.Drawing.Point(3, 3);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(399, 335);
            this.Bill.TabIndex = 0;
            this.Bill.UseCompatibleStateImageBehavior = false;
            this.Bill.View = System.Windows.Forms.View.Details;
            this.Bill.SelectedIndexChanged += new System.EventHandler(this.Bill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Food Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ToTal Price";
            this.columnHeader4.Width = 215;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.mnDisCount);
            this.panel3.Controls.Add(this.DisCount);
            this.panel3.Controls.Add(this.CheckOut);
            this.panel3.Location = new System.Drawing.Point(604, 441);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 55);
            this.panel3.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalPrice.Location = new System.Drawing.Point(203, 13);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 28);
            this.txtTotalPrice.TabIndex = 8;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(3, 28);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(93, 24);
            this.cbSwitchTable.TabIndex = 4;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(0, 0);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(96, 27);
            this.btnSwitchTable.TabIndex = 7;
            this.btnSwitchTable.Text = "Chuyển Bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            this.btnSwitchTable.Click += new System.EventHandler(this.SwitchTable_Click);
            // 
            // mnDisCount
            // 
            this.mnDisCount.Location = new System.Drawing.Point(102, 30);
            this.mnDisCount.Name = "mnDisCount";
            this.mnDisCount.Size = new System.Drawing.Size(96, 22);
            this.mnDisCount.TabIndex = 4;
            this.mnDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DisCount
            // 
            this.DisCount.Location = new System.Drawing.Point(102, 3);
            this.DisCount.Name = "DisCount";
            this.DisCount.Size = new System.Drawing.Size(96, 27);
            this.DisCount.TabIndex = 6;
            this.DisCount.Text = "Giảm Giá";
            this.DisCount.UseVisualStyleBackColor = true;
            this.DisCount.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.Location = new System.Drawing.Point(309, 5);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(96, 47);
            this.CheckOut.TabIndex = 4;
            this.CheckOut.Text = "Thanh Toán";
            this.CheckOut.UseVisualStyleBackColor = true;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TeaCount);
            this.panel4.Controls.Add(this.AddTea);
            this.panel4.Controls.Add(this.cbTea);
            this.panel4.Controls.Add(this.Category);
            this.panel4.Location = new System.Drawing.Point(607, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 47);
            this.panel4.TabIndex = 4;
            // 
            // TeaCount
            // 
            this.TeaCount.Location = new System.Drawing.Point(344, 13);
            this.TeaCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TeaCount.Name = "TeaCount";
            this.TeaCount.Size = new System.Drawing.Size(55, 22);
            this.TeaCount.TabIndex = 3;
            this.TeaCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TeaCount.ValueChanged += new System.EventHandler(this.TeaCount_ValueChanged);
            // 
            // AddTea
            // 
            this.AddTea.Location = new System.Drawing.Point(228, 0);
            this.AddTea.Name = "AddTea";
            this.AddTea.Size = new System.Drawing.Size(96, 47);
            this.AddTea.TabIndex = 2;
            this.AddTea.Text = "Thêm Món";
            this.AddTea.UseVisualStyleBackColor = true;
            this.AddTea.Click += new System.EventHandler(this.AddTea_Click);
            // 
            // cbTea
            // 
            this.cbTea.BackColor = System.Drawing.Color.White;
            this.cbTea.FormattingEnabled = true;
            this.cbTea.Location = new System.Drawing.Point(-3, 23);
            this.cbTea.Name = "cbTea";
            this.cbTea.Size = new System.Drawing.Size(225, 24);
            this.cbTea.TabIndex = 0;
            this.cbTea.SelectedIndexChanged += new System.EventHandler(this.Tea_SelectedIndexChanged);
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(-3, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(225, 24);
            this.Category.TabIndex = 0;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            this.Category.SelectionChangeCommitted += new System.EventHandler(this.Category_SelectionChangeCommitted);
            // 
            // flqTable
            // 
            this.flqTable.AutoScroll = true;
            this.flqTable.Location = new System.Drawing.Point(12, 47);
            this.flqTable.Name = "flqTable";
            this.flqTable.Size = new System.Drawing.Size(586, 449);
            this.flqTable.TabIndex = 5;
            this.flqTable.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Paint);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 508);
            this.Controls.Add(this.flqTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trà Sữa ";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnDisCount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeaCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView Bill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.ComboBox cbTea;
        private System.Windows.Forms.Button AddTea;
        private System.Windows.Forms.NumericUpDown TeaCount;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.FlowLayoutPanel flqTable;
        private System.Windows.Forms.Button DisCount;
        private System.Windows.Forms.NumericUpDown mnDisCount;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}