using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn
{
    public partial class DangKy : Form
    { 
        public DangKy()
        {
            InitializeComponent();
        }
        private void btndangky_Click(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtxacnhanmk_TextChanged(object sender, EventArgs e)
        {
        }

        private void btndangky_Click_1(object sender, EventArgs e)
        {
            bool check = true; // tạo 1 biến check để validate dữ liệu
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item.Text == "") // nếu controls là textbox rỗng
                {

                    MessageBox.Show("Hãy điền đủ thông tin");
                    check = false;
                    break;
                }
            }
            DialogResult result = MessageBox.Show("Do you want to save ?", "", MessageBoxButtons.YesNoCancel);
            if (check = true && result == DialogResult.Yes)
            {
                string name = txtten.Text;
                string address = txtemail.Text;
                string username = txttaikhoan.Text;
                string password = txtmatkhau.Text;
                string phone = txtphone.Text;
                string xnmk = txtxacnhanmk.Text;

                account ac = new account(name, address, phone, username, password, xnmk);
                string accountFile = ac.CreateAccount();
                File.AppendAllText("account.txt", accountFile);

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    { c.Text = ""; }
                }
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
        }
    }
}
