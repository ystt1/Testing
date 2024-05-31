namespace QLQCFTest
{
    partial class fAccount
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            btnConfirm = new Button();
            panel7 = new Panel();
            txbRePass = new TextBox();
            label6 = new Label();
            panel6 = new Panel();
            txbNewPass = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            txbPassword = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            txbDisplayUserName = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            txbUserName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 18);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Tài Khoản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 434);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(408, 393);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 22);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(288, 393);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(88, 22);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Xác Nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(txbRePass);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 300);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(540, 75);
            panel7.TabIndex = 6;
            // 
            // txbRePass
            // 
            txbRePass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbRePass.Location = new Point(51, 41);
            txbRePass.Margin = new Padding(3, 2, 3, 2);
            txbRePass.Name = "txbRePass";
            txbRePass.Size = new Size(445, 29);
            txbRePass.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(47, 16);
            label6.Name = "label6";
            label6.Size = new Size(145, 19);
            label6.TabIndex = 1;
            label6.Text = "Nhập lại mật khẩu";
            // 
            // panel6
            // 
            panel6.Controls.Add(txbNewPass);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 225);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(540, 75);
            panel6.TabIndex = 5;
            // 
            // txbNewPass
            // 
            txbNewPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNewPass.Location = new Point(51, 41);
            txbNewPass.Margin = new Padding(3, 2, 3, 2);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new Size(445, 29);
            txbNewPass.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(47, 16);
            label5.Name = "label5";
            label5.Size = new Size(111, 19);
            label5.TabIndex = 1;
            label5.Text = "Mật khẩu mới";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbPassword);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 150);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(540, 75);
            panel5.TabIndex = 4;
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbPassword.Location = new Point(51, 41);
            txbPassword.Margin = new Padding(3, 2, 3, 2);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(445, 29);
            txbPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(47, 16);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 1;
            label4.Text = "Mật khẩu";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbDisplayUserName);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 75);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(540, 75);
            panel4.TabIndex = 3;
            // 
            // txbDisplayUserName
            // 
            txbDisplayUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbDisplayUserName.Location = new Point(51, 41);
            txbDisplayUserName.Margin = new Padding(3, 2, 3, 2);
            txbDisplayUserName.Name = "txbDisplayUserName";
            txbDisplayUserName.Size = new Size(445, 29);
            txbDisplayUserName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 16);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 1;
            label3.Text = "Tên hiển thị";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbUserName);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 75);
            panel3.TabIndex = 2;
            // 
            // txbUserName
            // 
            txbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbUserName.Location = new Point(51, 41);
            txbUserName.Margin = new Padding(3, 2, 3, 2);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(445, 29);
            txbUserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 16);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // fAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 504);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin tài khoản";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnExit;
        private Button btnConfirm;
        private Panel panel7;
        public TextBox txbRePass;
        private Label label6;
        private Panel panel6;
        public TextBox txbNewPass;
        private Label label5;
        private Panel panel5;
        public TextBox txbPassword;
        private Label label4;
        private Panel panel4;
        public TextBox txbDisplayUserName;
        private Label label3;
        private Panel panel3;
        public TextBox txbUserName;
        private Label label2;
    }
}