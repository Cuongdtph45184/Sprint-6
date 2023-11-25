using System.Text.RegularExpressions;

namespace DuAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lkbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKys = new DangKy();
            dangKys.ShowDialog();
        }

        public bool CheckCount(string message) // check m?t kh?u và tài kho?n
        {
            return Regex.IsMatch(message, @"^[A-Za-z0-9]{8,24}$");
        }
        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            string username = txtname.Text; string password = txtpassword.Text;
            account account = Service.CheckLogin(username, password);
            if (username.Length > 8 && password.ToLower() != password && account != null)
            {
                MessageBox.Show("Đăng nhập thành công", "thông báo", MessageBoxButtons.OK);
                FormSQL sql = new FormSQL();
                sql.ShowDialog();
            }
            else MessageBox.Show("Đăng nhập thất bại");
        }

        private void lkbDangKy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else txtpassword.PasswordChar = '*';
        }

        private void lkbDangKy_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }
    }
}