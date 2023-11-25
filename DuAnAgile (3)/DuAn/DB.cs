using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DuAn
{
    public class DB
    {
        SqlConnection conn; //ket noi
        SqlCommand com; //xu ly lenh
        SqlDataAdapter da; //adapter
        DataSet ds; //anh bang du lieu
        public void ketnoi()
        {
            //chuoi ket noi csdl
            string s = "Data Source=CUONG123\\SQLEXPRESS;Initial Catalog=QuanLyDiemSVcuong;Integrated Security=True";
            conn = new SqlConnection(s);//khoi taoket noi
            da = new SqlDataAdapter();//khoi tao bo dieu phoi du lieu
            ds = new DataSet();//khoi tao 
        }
        public void getData(ListView lv)
        {
            com = new SqlCommand("select * from DiemSV", conn);//lenh
            da.SelectCommand = com;//select
            da.Fill(ds, "DiemSV");//dien du lieu vao dataset
            lv.Items.Clear();//xoa du lieu tren listview
            for (int rows = 0; rows < ds.Tables[0].Rows.Count; rows++)//chay tu dong 0 den n
            {
                lv.Items.Add(ds.Tables[0].Rows[rows].ItemArray[0].ToString());//them dong
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[1].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[2].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[3].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[4].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[5].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[6].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[7].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[8].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[9].ToString());
                // lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[4].ToString());
                // lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[5].ToString());
            }
        }

        public void SearchStudentByID(string MaSV, ListView lv)
        {
            ketnoi(); // Make sure to call the connection method before executing any command

            string query = "SELECT * FROM DiemSV WHERE MaSV = @MaSV";
            com = new SqlCommand(query, conn);
            com.Parameters.AddWithValue("@MaSV", MaSV);

            da.SelectCommand = com;
            da.Fill(ds, "DiemSV");

            lv.Items.Clear();

            for (int rows = 0; rows < ds.Tables[0].Rows.Count; rows++)
            {
                lv.Items.Add(ds.Tables[0].Rows[rows].ItemArray[0].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[1].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[2].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[3].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[4].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[5].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[6].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[7].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[8].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[9].ToString());
            }
        }

        public void SapXep(ListView lv)
        {
            ketnoi(); // Make sure to call the connection method before executing any command

            string path = "SELECT * FROM DiemSV ORDER BY DiemTB DESC";
            com = new SqlCommand(path, conn);
            da.SelectCommand = com;
            da.Fill(ds, "DiemSV");

            lv.Items.Clear();

            for (int rows = 0; rows < ds.Tables[0].Rows.Count; rows++)
            {
                lv.Items.Add(ds.Tables[0].Rows[rows].ItemArray[0].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[1].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[2].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[3].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[4].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[5].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[6].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[7].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[8].ToString());
                lv.Items[rows].SubItems.Add(ds.Tables[0].Rows[rows].ItemArray[9].ToString());
            }
        }
        //ham them du lieu
        public void saveData(TextBox txtMaSv, TextBox txtTenSv, DateTimePicker dtpNgaySinh, ComboBox cboGioiTinh
            , TextBox txtEmail, TextBox txtLop, TextBox txtDiemIT, TextBox txtDiemTiengAnh, TextBox txtDiemDuAn, TextBox txtDiemTB)
        {
            //lay du lieu tren form va cap nhat vao dataset
            ds.Tables["DiemSV"].Rows.Add(txtMaSv.Text, txtTenSv.Text, dtpNgaySinh.Value, cboGioiTinh.Text, txtEmail.Text, txtLop.Text, float.Parse(txtDiemIT.Text), float.Parse(txtDiemTiengAnh.Text), float.Parse(txtDiemDuAn.Text), float.Parse(txtDiemTB.Text));
            //chuan bi lenh
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetInsertCommand();//thuc hien insert
            da.Update(ds, "DiemSV");//sau khi insert, cap nhat vao dataset
        }
        //SP4.1. Khi click vao listview -> hien thi du lieu len textbox
        public void getDataToTextBox(TextBox txtMaSv, TextBox txtTenSv, DateTimePicker dtpNgaySinh, ComboBox cboGioiTinh
            , TextBox txtEmail, TextBox txtLop, TextBox txtDiemIT, TextBox txtDiemTiengAnh, TextBox txtDiemDuAn, TextBox txtDiemTB, ListView lv)
        {
            foreach (ListViewItem selectedItem in lv.SelectedItems)
            {
                //1. Lay ve chi so cua dong vua click
                int index = selectedItem.Index;
                //2. Tao doi tuong DataRow chua du lieu cua dong vua click
                DataRow dr = ds.Tables["DiemSV"].Rows[index];
                //3. gan du lieu len textbox
                txtMaSv.Text = dr[0].ToString();
                txtTenSv.Text = dr[1].ToString();
                // 4. Assign the DateTime value to the DateTimePicker
                dtpNgaySinh.Value = Convert.ToDateTime(dr[2]);
                // 5. Assign the selected item to the ComboBox
                cboGioiTinh.Text = dr[3].ToString();
                txtEmail.Text = dr[4].ToString();
                txtLop.Text = dr[5].ToString();
                txtDiemIT.Text = dr[6].ToString();
                txtDiemTiengAnh.Text = dr[7].ToString();
                txtDiemDuAn.Text = dr[8].ToString();
                txtDiemTB.Text = dr[9].ToString();
            }
        }
        //sp4.2 Cap nhat du lieu
        int selectedIndex;
        public void updateData(TextBox txtMaSv, TextBox txtTenSv, DateTimePicker dtpNgaySinh, ComboBox cboGioiTinh
            , TextBox txtEmail, TextBox txtLop, TextBox txtDiemIT, TextBox txtDiemTiengAnh, TextBox txtDiemDuAn, TextBox txtDiemTB, ListView lv)
        {
            //1. gan chi so cho dong vua chon
            selectedIndex = lv.SelectedItems[0].Index;
            //2. Lay du lieu tu textbox dua vao dataset
            ds.Tables["DiemSV"].Rows[selectedIndex][6] = txtDiemIT.Text;
            ds.Tables["DiemSV"].Rows[selectedIndex][7] = txtDiemTiengAnh.Text;
            ds.Tables["DiemSV"].Rows[selectedIndex][8] = txtDiemDuAn.Text;
            ds.Tables["DiemSV"].Rows[selectedIndex][9] = txtDiemTB.Text;
            //3.Su dung doi tuong chua du lieu va update
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            cb.GetUpdateCommand();//xac dinh cau lenh
            da.Update(ds, "DiemSV");//cap nhat du lieu
        }
    }
}
