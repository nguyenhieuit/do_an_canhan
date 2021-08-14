using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S_NguyenHieu_2819
{
    public partial class frm_khachhang : Form
    {
        LopChung lc = new LopChung();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\\Images\\";

        public frm_khachhang()
        {
            InitializeComponent();
        }

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            loadDLKH();
        }
        public void loadDLKH()
        {
            string sql = "Select *From KhachHang";
            dataGridView1.DataSource = lc.napDL(sql);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Hãy chọn hình ảnh cần tải lên";
            op.Filter = "Ảnh dạng JPG|*.JPG|Ảnh dạng PNG|*.PNG|Tất cả|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Hãy chọn hình ảnh cần tải lên";
            op.Filter = "Ảnh dạng JPG|*.JPG|Ảnh dạng PNG|*.PNG|Tất cả|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            txt_tenKH.Text = dataGridView1.CurrentRow.Cells["TenKH"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_diachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_sdt.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["NgayNhanXe"].Value.ToString();
            txt_anhln.Text = dataGridView1.CurrentRow.Cells["AnhLN"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_anhln.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "Insert Into KhachHang Values(" +
                "N'" + txt_tenKH.Text + "'," +
                "Convert(datetime, '" + dateTimePicker1.Text + "',103)," +
                "N'" + txt_diachi.Text + "'," +
                "'" + txt_sdt.Text + "'," +
                "Convert(datetime, '" + dateTimePicker2.Text + "',103)," +
                "N'" + txt_anhln.Text + "')";
            lc.ThemSuaXoa(sql);
            pictureBox1.Image.Save(duongdan + txt_anhln.Text);
            loadDLKH();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Update KhachHang Set " +
                "TenKH= N'" + txt_tenKH.Text + "'," +
                "NgaySinh= Convert(datetime, '" + dateTimePicker1.Text + "',103)," +
                "DiaChi= N'" + txt_diachi.Text + "'," +
                "SDT= '" + txt_sdt.Text + "'," +
                "NgayNhanXe= Convert(datetime, '" + dateTimePicker2.Text + "',103)," +
                "AnhLN= N'" + txt_anhln.Text + "' " +
                "Where MaKH= N'" + textBox1.Text +"'";
            lc.ThemSuaXoa(sql);
            pictureBox1.Image.Save(duongdan + txt_anhln.Text);
            loadDLKH();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "Delete From KhachHang Where MaKH= N'" + textBox1.Text + "'";
            lc.ThemSuaXoa(sql);
            File.Delete(duongdan + txt_anhln.Text);
            loadDLKH();
        }
        private void txt_tk_TextChanged(object sender, EventArgs e)
        {

            string sql = "Select *From KhachHang Where SDT Like '%" + txt_tk.Text + "%'";
            dataGridView1.DataSource = lc.napDL(sql);
            if (txt_tk.Text == "")
            {
                loadDLKH();
            }
        }
        private void txt_tk_Click(object sender, EventArgs e)
        {
            txt_tk.Text = string.Empty;
        }
    }
}
