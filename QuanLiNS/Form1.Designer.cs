namespace QuanLiNS
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trìnhĐộHọcVấnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbtenhienthi = new System.Windows.Forms.Label();
            this.TitleTable = new System.Windows.Forms.Label();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(211, 114);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1419, 949);
            this.dgv.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(8, 8);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thôngTinCáNhânToolStripMenuItem.Image = global::QuanLiNS.Properties.Resources.BOEmployee_16x16;
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Cá nhân";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::QuanLiNS.Properties.Resources.BOContact2_16x16;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(270, 30);
            this.toolStripMenuItem2.Text = "Thông tin cá nhân";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = global::QuanLiNS.Properties.Resources.Edit_16x16;
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Chỉnh sửa tài khoản";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::QuanLiNS.Properties.Resources.Left_32x32;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem,
            this.phòngBanToolStripMenuItem,
            this.trìnhĐộHọcVấnToolStripMenuItem,
            this.lươngToolStripMenuItem,
            this.toolStripMenuItem3});
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = global::QuanLiNS.Properties.Resources.TableOfContent_16x16;
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(159, 29);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Xem bảng ...";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Image = global::QuanLiNS.Properties.Resources.Table_16x16;
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Image = global::QuanLiNS.Properties.Resources.Table_16x16;
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // trìnhĐộHọcVấnToolStripMenuItem
            // 
            this.trìnhĐộHọcVấnToolStripMenuItem.Image = global::QuanLiNS.Properties.Resources.Table_16x16;
            this.trìnhĐộHọcVấnToolStripMenuItem.Name = "trìnhĐộHọcVấnToolStripMenuItem";
            this.trìnhĐộHọcVấnToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.trìnhĐộHọcVấnToolStripMenuItem.Text = "Trình độ học vấn";
            this.trìnhĐộHọcVấnToolStripMenuItem.Click += new System.EventHandler(this.trìnhĐộHọcVấnToolStripMenuItem_Click);
            // 
            // lươngToolStripMenuItem
            // 
            this.lươngToolStripMenuItem.Image = global::QuanLiNS.Properties.Resources.Table_16x16;
            this.lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            this.lươngToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.lươngToolStripMenuItem.Text = "Lương";
            this.lươngToolStripMenuItem.Click += new System.EventHandler(this.lươngToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::QuanLiNS.Properties.Resources.Table_16x16;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(270, 30);
            this.toolStripMenuItem3.Text = "Thông tin nhân viên";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // lbtenhienthi
            // 
            this.lbtenhienthi.AutoSize = true;
            this.lbtenhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbtenhienthi.Location = new System.Drawing.Point(1608, 21);
            this.lbtenhienthi.Name = "lbtenhienthi";
            this.lbtenhienthi.Size = new System.Drawing.Size(84, 20);
            this.lbtenhienthi.TabIndex = 3;
            this.lbtenhienthi.Text = "Xin chào!";
            // 
            // TitleTable
            // 
            this.TitleTable.AutoSize = true;
            this.TitleTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.TitleTable.Location = new System.Drawing.Point(787, 91);
            this.TitleTable.Name = "TitleTable";
            this.TitleTable.Size = new System.Drawing.Size(166, 20);
            this.TitleTable.TabIndex = 4;
            this.TitleTable.Text = "Thông tin nhân viên";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Image = global::QuanLiNS.Properties.Resources.images;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.TitleTable);
            this.Controls.Add(this.lbtenhienthi);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgv);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trìnhĐộHọcVấnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label lbtenhienthi;
        private System.Windows.Forms.Label TitleTable;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

