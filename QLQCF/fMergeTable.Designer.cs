namespace QLQCF
{
    partial class fMergeTable
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
            lbNameTable = new Label();
            cbTableCanMerge = new ComboBox();
            cbTableResult = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnMergeTable = new Button();
            SuspendLayout();
            // 
            // lbNameTable
            // 
            lbNameTable.AutoSize = true;
            lbNameTable.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbNameTable.Location = new Point(64, 41);
            lbNameTable.Name = "lbNameTable";
            lbNameTable.Size = new Size(79, 23);
            lbNameTable.TabIndex = 0;
            lbNameTable.Text = "Tên Bàn";
            // 
            // cbTableCanMerge
            // 
            cbTableCanMerge.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbTableCanMerge.FormattingEnabled = true;
            cbTableCanMerge.Location = new Point(206, 38);
            cbTableCanMerge.Name = "cbTableCanMerge";
            cbTableCanMerge.Size = new Size(121, 31);
            cbTableCanMerge.TabIndex = 1;
            cbTableCanMerge.SelectedIndexChanged += cbTableCanMerge_SelectedIndexChanged;
            cbTableCanMerge.KeyPress += txbCanNotChange_KeyPress;
            // 
            // cbTableResult
            // 
            cbTableResult.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbTableResult.FormattingEnabled = true;
            cbTableResult.Location = new Point(186, 127);
            cbTableResult.Name = "cbTableResult";
            cbTableResult.Size = new Size(121, 31);
            cbTableResult.TabIndex = 2;
            cbTableResult.KeyPress += txbCanNotChange_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(107, 130);
            label2.Name = "label2";
            label2.Size = new Size(36, 23);
            label2.TabIndex = 3;
            label2.Text = "-->";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(164, 46);
            label3.Name = "label3";
            label3.Size = new Size(22, 23);
            label3.TabIndex = 4;
            label3.Text = "+";
            // 
            // btnMergeTable
            // 
            btnMergeTable.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMergeTable.Location = new Point(97, 183);
            btnMergeTable.Name = "btnMergeTable";
            btnMergeTable.Size = new Size(166, 50);
            btnMergeTable.TabIndex = 3;
            btnMergeTable.Text = "Gộp Bàn";
            btnMergeTable.UseVisualStyleBackColor = true;
            btnMergeTable.Click += btnMergeTable_Click;
            // 
            // fMergeTable
            // 
            AcceptButton = btnMergeTable;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 256);
            Controls.Add(btnMergeTable);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbTableResult);
            Controls.Add(cbTableCanMerge);
            Controls.Add(lbNameTable);
            Name = "fMergeTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gộp Bàn";
            FormClosed += fMergeTable_FormClosed;
            Load += fMergeTable_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNameTable;
        private ComboBox cbTableCanMerge;
        public ComboBox cbTableResult;
        private Label label2;
        private Label label3;
        private Button btnMergeTable;
    }
}