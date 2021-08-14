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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLNhanVien"] == null)
            {
                frm_QLNhanVien qlnv = new frm_QLNhanVien();
                qlnv.MdiParent = this;
                qlnv.Show();
            }
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TTLienHe"] == null)
            {
                frm_TTLienHe lh = new frm_TTLienHe();
                lh.MdiParent = this;
                lh.Show();
            }
            else Application.OpenForms["frm_TTLienHe"].Activate();
        }

        private void thôngTinKhácHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_khachhang"] == null)
            {
                frm_khachhang kh = new frm_khachhang();
                kh.MdiParent = this;
                kh.Show();
            }
            else Application.OpenForms["frm_khachhang"].Activate();
        }

        private void thôngTinĐốiTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TTDoiTac"] == null)
            {
                frm_TTDoiTac dt = new frm_TTDoiTac();
                dt.MdiParent = this;
                dt.Show();
            }
            else Application.OpenForms["frm_TTDoiTac"].Activate();
        }

        private void quánLýXeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLXe"] == null)
            {
                frm_QLXe qlx = new frm_QLXe();
                qlx.MdiParent = this;
                qlx.Show();
            }
        }
    }
}
