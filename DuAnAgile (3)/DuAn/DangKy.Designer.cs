namespace DuAn
{
    partial class DangKy
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
            btndangky = new Button();
            txtxacnhanmk = new TextBox();
            txtmatkhau = new TextBox();
            txttaikhoan = new TextBox();
            txtphone = new TextBox();
            txtemail = new TextBox();
            txtten = new TextBox();
            lbxacnhanmk = new Label();
            lbmatkhau = new Label();
            lbtaikhoan = new Label();
            lbphone = new Label();
            lbemail = new Label();
            lbten = new Label();
            SuspendLayout();
            // 
            // btndangky
            // 
            btndangky.BackColor = SystemColors.ControlLight;
            btndangky.Location = new Point(310, 290);
            btndangky.Margin = new Padding(3, 2, 3, 2);
            btndangky.Name = "btndangky";
            btndangky.Size = new Size(94, 38);
            btndangky.TabIndex = 29;
            btndangky.Text = "Đăng Ký";
            btndangky.UseVisualStyleBackColor = false;
            btndangky.Click += btndangky_Click_1;
            // 
            // txtxacnhanmk
            // 
            txtxacnhanmk.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtxacnhanmk.Location = new Point(220, 234);
            txtxacnhanmk.Margin = new Padding(3, 2, 3, 2);
            txtxacnhanmk.Name = "txtxacnhanmk";
            txtxacnhanmk.Size = new Size(325, 27);
            txtxacnhanmk.TabIndex = 23;
            txtxacnhanmk.TextChanged += txtxacnhanmk_TextChanged;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.Location = new Point(220, 187);
            txtmatkhau.Margin = new Padding(3, 2, 3, 2);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(325, 27);
            txtmatkhau.TabIndex = 24;
            txtmatkhau.TextChanged += txtmatkhau_TextChanged;
            // 
            // txttaikhoan
            // 
            txttaikhoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttaikhoan.Location = new Point(220, 139);
            txttaikhoan.Margin = new Padding(3, 2, 3, 2);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(325, 27);
            txttaikhoan.TabIndex = 25;
            txttaikhoan.TextChanged += txttaikhoan_TextChanged;
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtphone.Location = new Point(220, 93);
            txtphone.Margin = new Padding(3, 2, 3, 2);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(325, 27);
            txtphone.TabIndex = 26;
            txtphone.TextChanged += txtphone_TextChanged;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(220, 52);
            txtemail.Margin = new Padding(3, 2, 3, 2);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(325, 27);
            txtemail.TabIndex = 27;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // txtten
            // 
            txtten.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtten.Location = new Point(220, 8);
            txtten.Margin = new Padding(3, 2, 3, 2);
            txtten.Name = "txtten";
            txtten.Size = new Size(325, 27);
            txtten.TabIndex = 28;
            txtten.TextChanged += txtten_TextChanged;
            // 
            // lbxacnhanmk
            // 
            lbxacnhanmk.AutoSize = true;
            lbxacnhanmk.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbxacnhanmk.Location = new Point(7, 239);
            lbxacnhanmk.Name = "lbxacnhanmk";
            lbxacnhanmk.Size = new Size(146, 19);
            lbxacnhanmk.TabIndex = 17;
            lbxacnhanmk.Text = "Xác nhận mật khẩu";
            // 
            // lbmatkhau
            // 
            lbmatkhau.AutoSize = true;
            lbmatkhau.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbmatkhau.Location = new Point(74, 192);
            lbmatkhau.Name = "lbmatkhau";
            lbmatkhau.Size = new Size(76, 19);
            lbmatkhau.TabIndex = 18;
            lbmatkhau.Text = "Mật Khẩu";
            // 
            // lbtaikhoan
            // 
            lbtaikhoan.AutoSize = true;
            lbtaikhoan.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbtaikhoan.Location = new Point(72, 144);
            lbtaikhoan.Name = "lbtaikhoan";
            lbtaikhoan.Size = new Size(79, 19);
            lbtaikhoan.TabIndex = 19;
            lbtaikhoan.Text = "Tài Khoản";
            // 
            // lbphone
            // 
            lbphone.AutoSize = true;
            lbphone.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbphone.Location = new Point(104, 98);
            lbphone.Name = "lbphone";
            lbphone.Size = new Size(55, 19);
            lbphone.TabIndex = 20;
            lbphone.Text = "Phone";
            // 
            // lbemail
            // 
            lbemail.AutoSize = true;
            lbemail.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbemail.Location = new Point(104, 57);
            lbemail.Name = "lbemail";
            lbemail.Size = new Size(51, 19);
            lbemail.TabIndex = 21;
            lbemail.Text = "Email";
            // 
            // lbten
            // 
            lbten.AutoSize = true;
            lbten.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbten.Location = new Point(104, 14);
            lbten.Name = "lbten";
            lbten.Size = new Size(56, 19);
            lbten.TabIndex = 22;
            lbten.Text = "Họ tên";
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 333);
            Controls.Add(btndangky);
            Controls.Add(txtxacnhanmk);
            Controls.Add(txtmatkhau);
            Controls.Add(txttaikhoan);
            Controls.Add(txtphone);
            Controls.Add(txtemail);
            Controls.Add(txtten);
            Controls.Add(lbxacnhanmk);
            Controls.Add(lbmatkhau);
            Controls.Add(lbtaikhoan);
            Controls.Add(lbphone);
            Controls.Add(lbemail);
            Controls.Add(lbten);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DangKy";
            Text = "DangKy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btndangky;
        private TextBox txtxacnhanmk;
        private TextBox txtmatkhau;
        private TextBox txttaikhoan;
        private TextBox txtphone;
        private TextBox txtemail;
        private TextBox txtten;
        private Label lbxacnhanmk;
        private Label lbmatkhau;
        private Label lbtaikhoan;
        private Label lbphone;
        private Label lbemail;
        private Label lbten;
    }
}