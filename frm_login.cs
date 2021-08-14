using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INDIVIDUAL_PROJECT_CS414SC_2020S_NguyenHieu_2819
{
    public partial class frm_login : Form
    {
        LopChung lc = new LopChung();
        public frm_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Select Count (*) From TaiKhoan where TenDN = '" + txt_tentk.Text + "' and MatKhau = '" + txt_mk.Text + "'";
            int kq = (int)lc.demDL(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công...");
                frm_Main _main = new frm_Main();
                if (txt_tentk.Text != "admin")
                {
                    _main.Show();
                    _main.quánLýXeToolStripMenuItem.Enabled = false;
                    _main.quảnLýNhânViênToolStripMenuItem.Enabled = false;
                }
                else _main.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!!!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_layMK"] == null)
            {
                frm_layMK layMK = new frm_layMK();
                layMK.Show();
            }
            else Application.OpenForms["frm_layMK"].Activate();
        }
    }
}
