using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace DuAn
{
    public partial class HoTro : Form
    {
        public HoTro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = true;
            string text = tb_ch.Text;
            string cbo = comboBox1.Text;
            string filepath = "C:\\Users\\Admin\\Documents\\Zalo Received Files\\DuAnAgile (3)\\DuAn\\bin\\Debug\\net6.0-windows\\hotro.txt";
            if (text == "")
            {
                check = false;
                MessageBox.Show("Hãy điền hỗ trợ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbo == "")
            {
                check = false;
                MessageBox.Show("Hãy chọn danh mục", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check = true;
                File.WriteAllText(filepath, text);
                MessageBox.Show("Đã gửi hỗ trợ");
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    { c.Text = ""; }
                }
                foreach (Control c in this.Controls)
                {
                    if (c is ComboBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
