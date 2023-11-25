using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuAn
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        DB db = new DB();

        private void btnSua_Click(object sender, EventArgs e)
        {
            db.updateData(txtMaSv, txtTenSv, dtpNgaySinh, CboGioiTinh, txtEmail, txtLop, txtDiemIT, txtDiemTiengAnh, txtDiemDuAn, txtDiemTB, lvDanhSach);
            FormSQL_Load(null, null);//load laij du lieu
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            db.saveData(txtMaSv, txtTenSv, dtpNgaySinh, CboGioiTinh, txtEmail, txtLop, txtDiemIT, txtDiemTiengAnh, txtDiemDuAn, txtDiemTB);
            //
            FormSQL_Load(null, null);
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {
            db.ketnoi();
            db.getData(lvDanhSach);
        }
        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.getDataToTextBox(txtMaSv, txtTenSv, dtpNgaySinh, CboGioiTinh, txtEmail, txtLop, txtDiemIT, txtDiemTiengAnh, txtDiemDuAn, txtDiemTB, lvDanhSach);
        }

        private void txtDiemTB_TextChanged(object sender, EventArgs e)
        {
            float diem1 = float.Parse(txtDiemDuAn.Text);
            float diem2 = float.Parse(txtDiemIT.Text);
            float diem3 = float.Parse(txtDiemTiengAnh.Text);

            // Tính điểm trung bình
            float diemTrungBinh = (diem1 + diem2 + diem3) / 3;
            txtDiemTB.Text = diemTrungBinh.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            db.ketnoi();
            string studentIDToSearch = txtTimKiem.Text;
            db.SearchStudentByID(studentIDToSearch, lvDanhSach);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {

        }

        private void btmHoTro_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                Close();
            }
        }

        private void CboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemTiengAnh_TextChanged(object sender, EventArgs e)
        {
            TinhTB();
        }

        private void txtDiemIT_TextChanged(object sender, EventArgs e)
        {
            TinhTB();
        }
        void TinhTB()
        {
            if (txtDiemDuAn.Text != "" && txtDiemIT.Text != "" && txtDiemTiengAnh.Text != "")
            {
                double ta = Convert.ToDouble(txtDiemTiengAnh.Text);
                double da = Convert.ToDouble(txtDiemDuAn.Text);
                double it = Convert.ToDouble(txtDiemIT.Text);
                txtDiemTB.Text = (ta + da + it) / 3 + "";
            }
        }
        private void txtDiemDuAn_TextChanged(object sender, EventArgs e)
        { TinhTB(); }

        private void btnreset_Click(object sender, EventArgs e)
        {}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {  }

        private void txtsapxep_Click(object sender, EventArgs e)
        {
            db.ketnoi();
            db.SapXep(lvDanhSach);
        }

        private void txthotro_Click(object sender, EventArgs e)
        {
            HoTro hoTro = new HoTro();
            hoTro.ShowDialog();
        }

        private void txtreset_Click(object sender, EventArgs e)
        {
            dtpNgaySinh.ResetText();
            CboGioiTinh.ResetText();
            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}
