using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S_NguyenHieu_2819
{
    public partial class frm_QLXe : Form
    {
        LopChung lc = new LopChung();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\\Images\\";
        private string culture;

        public frm_QLXe()
        {
            InitializeComponent();
        }

        private void frm_QLXe_Load(object sender, EventArgs e)
        {
            loadcbxloaixe();
            loadcbxhangxe();
            loadDLXe();
        }
        public void loadcbxloaixe()
        {
            string sql = "Select *From LoaiXe";
            cbx_loaixe.DataSource = lc.napDL(sql);
            cbx_loaixe.DisplayMember = "TenLoai";
            cbx_loaixe.ValueMember = "MaLoai";
        }
        public void loadcbxhangxe()
        {
            string sql = "Select *From HangXe ";
            cbx_hangxe.DataSource = lc.napDL(sql);
            cbx_hangxe.DisplayMember = "TenHangXe";
            cbx_hangxe.ValueMember = "MaHangXe";
        }
        public void loadDLXe()
        {
            string sql = "Select *From Xe";
            dataGridView1.DataSource = lc.napDL(sql);
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

        public Boolean check()
        {

            if (rdob_conhang.Checked == true)
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "Insert into Xe Values (" +
                "N'" + cbx_loaixe.SelectedValue.ToString() + "'," +
                "N'" + cbx_hangxe.SelectedValue.ToString() + "'," +
                "N'" + txt_tenxe.Text + "'," +
                "N'" + txt_namSX.Text + "'," +
                "N'" + txt_tieuchuanbang.Text + "'," +
                "N'" + txt_anhxe.Text + "'," +
                "N'" + check() + "'," +
                "'" + txt_dongia.Text + "' )";
            lc.ThemSuaXoa(sql);
            pictureBox1.Image.Save(duongdan + txt_anhxe.Text);
            loadDLXe();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "Update Xe Set " +
                "MaLoai= N'" + cbx_loaixe.SelectedValue.ToString() + "'," +
                "MaHangXe= N'" + cbx_hangxe.SelectedValue.ToString() + "'," +
                "TenXe= N'" + txt_tenxe.Text + "'," +
                "NamSX= N'" + txt_namSX.Text + "'," +
                "TieuChuanBang= N'" + txt_tieuchuanbang.Text + "'," +
                "HAXe= N'" + txt_anhxe.Text + "'," +
                "Check= '" + check() + "'," +
                "DonGia= '" + txt_dongia.Text + "'" +
                "Where ID_Xe= '" + textBox1.Text + "'";
            lc.ThemSuaXoa(sql);
            pictureBox1.Image.Save(duongdan + txt_anhxe.Text);
            loadDLXe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn xoá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete From Xe Where ID_Xe='" + textBox1.Text + "'";
                File.Delete(duongdan + txt_anhxe.Text);
                lc.ThemSuaXoa(sql);
                loadDLXe();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox1.Text = dataGridView1.CurrentRow.Cells["ID_Xe"].Value.ToString();
            cbx_loaixe.SelectedValue = dataGridView1.CurrentRow.Cells["MaLoai"].Value.ToString();
            cbx_hangxe.SelectedValue = dataGridView1.CurrentRow.Cells["MaHangXe"].Value.ToString();
            txt_tenxe.Text = dataGridView1.CurrentRow.Cells["TenXe"].Value.ToString();
            txt_namSX.Text = dataGridView1.CurrentRow.Cells["NamSX"].Value.ToString();
            txt_tieuchuanbang.Text = dataGridView1.CurrentRow.Cells["TieuChuanBang"].Value.ToString();
            txt_anhxe.Text = dataGridView1.CurrentRow.Cells["HAXe"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["Check"].Value.ToString() == "True")
                rdob_conhang.Checked = true;
            else
                rdob_hethang.Checked = true;
            txt_dongia.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0 đ}", Convert.ToDouble(dataGridView1.CurrentRow.Cells["DonGia"].Value.ToString()));
            pictureBox1.ImageLocation = duongdan + txt_anhxe.Text;
        }
    }
}
