namespace DuAn
{
    partial class FormSQL
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
            label10 = new Label();
            dtpNgaySinh = new DateTimePicker();
            CboGioiTinh = new ComboBox();
            txtDiemTB = new TextBox();
            txtDiemDuAn = new TextBox();
            txtDiemTiengAnh = new TextBox();
            txtDiemIT = new TextBox();
            txtEmail = new TextBox();
            txtLop = new TextBox();
            txtTenSv = new TextBox();
            txtMaSv = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvDanhSach = new ListView();
            MaSV = new ColumnHeader();
            TenSV = new ColumnHeader();
            NgaySinh = new ColumnHeader();
            GioiTinh = new ColumnHeader();
            Email = new ColumnHeader();
            Lop = new ColumnHeader();
            DiemIT = new ColumnHeader();
            DiemTiengAnh = new ColumnHeader();
            DiemDuAn = new ColumnHeader();
            DiemTB = new ColumnHeader();
            btnSua = new Button();
            btnthem = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            tuỳChọnToolStripMenuItem = new ToolStripMenuItem();
            txtsapxep = new ToolStripMenuItem();
            txthotro = new ToolStripMenuItem();
            txtreset = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(336, 271);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 47;
            label10.Text = "DiemTB";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(88, 202);
            dtpNgaySinh.Margin = new Padding(2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(174, 23);
            dtpNgaySinh.TabIndex = 46;
            // 
            // CboGioiTinh
            // 
            CboGioiTinh.FormattingEnabled = true;
            CboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            CboGioiTinh.Location = new Point(88, 235);
            CboGioiTinh.Margin = new Padding(2);
            CboGioiTinh.Name = "CboGioiTinh";
            CboGioiTinh.Size = new Size(174, 23);
            CboGioiTinh.TabIndex = 45;
            CboGioiTinh.SelectedIndexChanged += CboGioiTinh_SelectedIndexChanged;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(437, 271);
            txtDiemTB.Margin = new Padding(2);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(191, 23);
            txtDiemTB.TabIndex = 43;
            txtDiemTB.TextChanged += txtDiemTB_TextChanged;
            // 
            // txtDiemDuAn
            // 
            txtDiemDuAn.Location = new Point(437, 236);
            txtDiemDuAn.Margin = new Padding(2);
            txtDiemDuAn.Name = "txtDiemDuAn";
            txtDiemDuAn.Size = new Size(191, 23);
            txtDiemDuAn.TabIndex = 42;
            txtDiemDuAn.TextChanged += txtDiemDuAn_TextChanged;
            // 
            // txtDiemTiengAnh
            // 
            txtDiemTiengAnh.Location = new Point(437, 202);
            txtDiemTiengAnh.Margin = new Padding(2);
            txtDiemTiengAnh.Name = "txtDiemTiengAnh";
            txtDiemTiengAnh.Size = new Size(191, 23);
            txtDiemTiengAnh.TabIndex = 41;
            txtDiemTiengAnh.TextChanged += txtDiemTiengAnh_TextChanged;
            // 
            // txtDiemIT
            // 
            txtDiemIT.Location = new Point(437, 173);
            txtDiemIT.Margin = new Padding(2);
            txtDiemIT.Name = "txtDiemIT";
            txtDiemIT.Size = new Size(191, 23);
            txtDiemIT.TabIndex = 40;
            txtDiemIT.TextChanged += txtDiemIT_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 266);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 23);
            txtEmail.TabIndex = 39;
            // 
            // txtLop
            // 
            txtLop.Location = new Point(437, 145);
            txtLop.Margin = new Padding(2);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(191, 23);
            txtLop.TabIndex = 38;
            // 
            // txtTenSv
            // 
            txtTenSv.Location = new Point(88, 173);
            txtTenSv.Margin = new Padding(2);
            txtTenSv.Name = "txtTenSv";
            txtTenSv.Size = new Size(174, 23);
            txtTenSv.TabIndex = 44;
            // 
            // txtMaSv
            // 
            txtMaSv.Location = new Point(88, 145);
            txtMaSv.Margin = new Padding(2);
            txtMaSv.Name = "txtMaSv";
            txtMaSv.Size = new Size(174, 23);
            txtMaSv.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(336, 236);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 35;
            label9.Text = "DiemDuAn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(336, 206);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 34;
            label8.Text = "DiemTiengAnh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 177);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 33;
            label7.Text = "DiemIT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 147);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 32;
            label6.Text = "Lop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 265);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 31;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 235);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 30;
            label4.Text = "GioiTinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 204);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 29;
            label3.Text = "NgaySInh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 177);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 36;
            label2.Text = "TenSV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 147);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 28;
            label1.Text = "MaSV";
            // 
            // lvDanhSach
            // 
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { MaSV, TenSV, NgaySinh, GioiTinh, Email, Lop, DiemIT, DiemTiengAnh, DiemDuAn, DiemTB });
            lvDanhSach.FullRowSelect = true;
            lvDanhSach.GridLines = true;
            lvDanhSach.Location = new Point(-2, 31);
            lvDanhSach.Margin = new Padding(3, 2, 3, 2);
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(814, 104);
            lvDanhSach.TabIndex = 25;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            lvDanhSach.SelectedIndexChanged += lvDanhSach_SelectedIndexChanged;
            // 
            // MaSV
            // 
            MaSV.Text = "MaSV";
            MaSV.Width = 100;
            // 
            // TenSV
            // 
            TenSV.Text = "TenSV";
            TenSV.Width = 150;
            // 
            // NgaySinh
            // 
            NgaySinh.Text = "NgaySinh";
            NgaySinh.Width = 150;
            // 
            // GioiTinh
            // 
            GioiTinh.Text = "GioiTinh";
            GioiTinh.Width = 100;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 100;
            // 
            // Lop
            // 
            Lop.Text = "Lop";
            Lop.Width = 100;
            // 
            // DiemIT
            // 
            DiemIT.Text = "DiemIT";
            DiemIT.Width = 100;
            // 
            // DiemTiengAnh
            // 
            DiemTiengAnh.Text = "DiemTiengAnh";
            DiemTiengAnh.Width = 100;
            // 
            // DiemDuAn
            // 
            DiemDuAn.Text = "DiemDuAn";
            DiemDuAn.Width = 100;
            // 
            // DiemTB
            // 
            DiemTB.Text = "DiemTB";
            DiemTB.Width = 100;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(111, 307);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 35);
            btnSua.TabIndex = 27;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(10, 307);
            btnthem.Margin = new Padding(3, 2, 3, 2);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(95, 35);
            btnthem.TabIndex = 26;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click_1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(707, 7);
            btnTimKiem.Margin = new Padding(2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(78, 20);
            btnTimKiem.TabIndex = 48;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(538, 7);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(150, 23);
            txtTimKiem.TabIndex = 49;
            // 
            // button1
            // 
            button1.Location = new Point(694, 307);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(103, 35);
            button1.TabIndex = 52;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tuỳChọnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 24);
            menuStrip1.TabIndex = 54;
            menuStrip1.Text = "menuStrip1";
            // 
            // tuỳChọnToolStripMenuItem
            // 
            tuỳChọnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtsapxep, txthotro, txtreset });
            tuỳChọnToolStripMenuItem.Name = "tuỳChọnToolStripMenuItem";
            tuỳChọnToolStripMenuItem.Size = new Size(70, 20);
            tuỳChọnToolStripMenuItem.Text = "Tuỳ Chọn";
            // 
            // txtsapxep
            // 
            txtsapxep.Name = "txtsapxep";
            txtsapxep.Size = new Size(116, 22);
            txtsapxep.Text = "Sắp Xếp";
            txtsapxep.Click += txtsapxep_Click;
            // 
            // txthotro
            // 
            txthotro.Name = "txthotro";
            txthotro.Size = new Size(116, 22);
            txthotro.Text = "Hỗ Trợ";
            txthotro.Click += txthotro_Click;
            // 
            // txtreset
            // 
            txtreset.Name = "txtreset";
            txtreset.Size = new Size(116, 22);
            txtreset.Text = "Reset";
            txtreset.Click += txtreset_Click;
            // 
            // FormSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 355);
            Controls.Add(button1);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(label10);
            Controls.Add(dtpNgaySinh);
            Controls.Add(CboGioiTinh);
            Controls.Add(txtDiemTB);
            Controls.Add(txtDiemDuAn);
            Controls.Add(txtDiemTiengAnh);
            Controls.Add(txtDiemIT);
            Controls.Add(txtEmail);
            Controls.Add(txtLop);
            Controls.Add(txtTenSv);
            Controls.Add(txtMaSv);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvDanhSach);
            Controls.Add(btnSua);
            Controls.Add(btnthem);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FormSQL";
            Text = "FormSQL";
            Load += FormSQL_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private DateTimePicker dtpNgaySinh;
        private ComboBox CboGioiTinh;
        private TextBox txtDiemTB;
        private TextBox txtDiemDuAn;
        private TextBox txtDiemTiengAnh;
        private TextBox txtDiemIT;
        private TextBox txtEmail;
        private TextBox txtLop;
        private TextBox txtTenSv;
        private TextBox txtMaSv;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lvDanhSach;
        private ColumnHeader MaSV;
        private ColumnHeader TenSV;
        private ColumnHeader NgaySinh;
        private ColumnHeader GioiTinh;
        private ColumnHeader Email;
        private ColumnHeader Lop;
        private ColumnHeader DiemIT;
        private ColumnHeader DiemTiengAnh;
        private ColumnHeader DiemDuAn;
        private ColumnHeader DiemTB;
        private Button btnSua;
        private Button btnthem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tuỳChọnToolStripMenuItem;
        private ToolStripMenuItem txtsapxep;
        private ToolStripMenuItem txthotro;
        private ToolStripMenuItem txtreset;
    }
}