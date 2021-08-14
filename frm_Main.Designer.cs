
namespace INDIVIDUAL_PROJECT_CS414SC_2020S_NguyenHieu_2819
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quánLýXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKhácHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐốiTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.liênHệToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quánLýXeToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quánLýXeToolStripMenuItem
            // 
            this.quánLýXeToolStripMenuItem.Name = "quánLýXeToolStripMenuItem";
            this.quánLýXeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quánLýXeToolStripMenuItem.Text = "Quán lý Xe";
            this.quánLýXeToolStripMenuItem.Click += new System.EventHandler(this.quánLýXeToolStripMenuItem_Click_1);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKhácHàngToolStripMenuItem,
            this.thôngTinĐốiTácToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thôngTinKhácHàngToolStripMenuItem
            // 
            this.thôngTinKhácHàngToolStripMenuItem.Name = "thôngTinKhácHàngToolStripMenuItem";
            this.thôngTinKhácHàngToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.thôngTinKhácHàngToolStripMenuItem.Text = "Thông tin khác hàng";
            this.thôngTinKhácHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKhácHàngToolStripMenuItem_Click);
            // 
            // thôngTinĐốiTácToolStripMenuItem
            // 
            this.thôngTinĐốiTácToolStripMenuItem.Name = "thôngTinĐốiTácToolStripMenuItem";
            this.thôngTinĐốiTácToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.thôngTinĐốiTácToolStripMenuItem.Text = "Thông tin đối tác";
            this.thôngTinĐốiTácToolStripMenuItem.Click += new System.EventHandler(this.thôngTinĐốiTácToolStripMenuItem_Click);
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.liênHệToolStripMenuItem.Text = "Liên hệ ";
            this.liênHệToolStripMenuItem.Click += new System.EventHandler(this.liênHệToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Quản lý cửa hàng ô tô";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKhácHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐốiTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        protected internal System.Windows.Forms.ToolStripMenuItem quánLýXeToolStripMenuItem;
        protected internal System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
    }
}