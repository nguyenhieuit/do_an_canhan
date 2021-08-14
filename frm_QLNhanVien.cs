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
    public partial class frm_QLNhanVien : Form
    {
        LopChung lc = new LopChung();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\\Images\\";
        public frm_QLNhanVien()
        {
            InitializeComponent();
        }
        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {
            loadDLNV();
            loadcbVT();
        }
        public void loadDLNV()
        {
            string sql = "Select *From NhanVien";
            dataGridView1.DataSource = lc.napDL(sql);
        }
        public void loadcbVT()
        {
            string sql = "Select *From ViTriNV";
            cbx_vitri.DataSource = lc.napDL(sql);
            cbx_vitri.DisplayMember = "TenVT";
            cbx_vitri.ValueMember = "MaVT";
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
        private void txt_tk_Click(object sender, EventArgs e)
        {
            txt_tk.Text = string.Empty;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_tennv.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["GT"].Value.ToString() == "True")
                rdb_nam.Checked = true;
            else rdb_nu.Checked = true;
            txt_diachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_sdt.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
            txt_Email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txt_hv.Text = dataGridView1.CurrentRow.Cells["TrinhDoHV"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["NgayVaoLam"].Value.ToString();
            txt_anhnv.Text = dataGridView1.CurrentRow.Cells["AnhNV"].Value.ToString();
            cbx_vitri.SelectedValue = dataGridView1.CurrentRow.Cells["MaVt"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_anhnv.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check;
            if (rdb_nam.Checked == true) check = 0;
            else check = 1;
            string sql = "Insert into NhanVien Values(" +
                "N'" + txt_tennv.Text + "'," +
                "Convert(datetime, '" + dateTimePicker1.Text + "',103)," +
                "N'" + check + "'," +
                "N'" + txt_diachi.Text + "'," +
                "N'" + txt_sdt.Text + "'," +
                "N'" + txt_Email.Text + "'," +
                "N'" + txt_hv.Text + "'," +
                "Convert(datetime, '" + dateTimePicker2.Text + "',103)," +
                "N'" + txt_anhnv.Text + "'," +
                "N'" + cbx_vitri.SelectedValue.ToString() + "')";
            lc.ThemSuaXoa(sql);
            pictureBox1.Image.Save(duongdan + txt_anhnv.Text);
            loadDLNV();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int check;
            if (rdb_nam.Checked == true) check = 0;
            else check = 1;
            string sql = "Update NhanVien Set " +
                "TenNV= N'"+txt_tennv.Text+"'," +
                "NgaySinh= Convert(datetime, '" + dateTimePicker1.Text + "',103)," +
                "GT= N'" + check + "'," +
                "DiaChi= N'" + txt_diachi.Text + "'," +
                "SDT= N'" + txt_sdt.Text + "'," +
                "Email= N'" + txt_Email.Text + "'," +
                "TrinhDoHV= N'" + txt_hv.Text + "'," +
                "NgayVaoLam= Convert(datetime, '" + dateTimePicker2.Text + "',103)," +
                "AnhNV= N'" + txt_anhnv.Text + "'," +
                "MaVT= N'" + cbx_vitri.SelectedValue.ToString() + "'" +
                " Where MaNV= '"+textBox7.Text+"'";
            lc.ThemSuaXoa(sql);
            pictureBox1.Image.Save(duongdan + txt_anhnv.Text);
            loadDLNV();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn xoá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete From NhanVien Where MaNV='" + textBox7.Text + "'";
                File.Delete(duongdan + txt_anhnv.Text);
                lc.ThemSuaXoa(sql);
                loadDLNV();
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                frm_QLXe qlx = new frm_QLXe();
                qlx.Close();
            }
        }
        public void button5_Click(object sender, EventArgs e)
        {
            frm_KQTimKiemNV tk = new frm_KQTimKiemNV();
            tk.Show();
        }
    }
}
