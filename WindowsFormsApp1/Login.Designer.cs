namespace WindowsFormsApp1
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.bLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 354);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Location = new System.Drawing.Point(518, 294);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 45);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(338, 294);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(152, 45);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Đăng Nhập";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Password);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(927, 65);
            this.panel3.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(294, 25);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(354, 22);
            this.Password.TabIndex = 1;
            this.Password.Text = "123456";
            this.Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mặt Khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 65);
            this.panel2.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(288, 25);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(354, 22);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Le Phuoc Binh";
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.bLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(1035, 448);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bLogin;
    }
}

