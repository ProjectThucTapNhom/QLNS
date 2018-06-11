namespace QuanLiNS
{
    partial class ftaoAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenhienthi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrepassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btntaotaikhoan = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(50, 52);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(280, 26);
            this.txtmanv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hiển thị:";
            // 
            // txttenhienthi
            // 
            this.txttenhienthi.Location = new System.Drawing.Point(50, 109);
            this.txttenhienthi.Name = "txttenhienthi";
            this.txttenhienthi.Size = new System.Drawing.Size(280, 26);
            this.txttenhienthi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(50, 161);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(280, 26);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(50, 223);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(280, 26);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(46, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // txtrepassword
            // 
            this.txtrepassword.Location = new System.Drawing.Point(50, 277);
            this.txtrepassword.Name = "txtrepassword";
            this.txtrepassword.Size = new System.Drawing.Size(280, 26);
            this.txtrepassword.TabIndex = 1;
            this.txtrepassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(46, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu:";
            // 
            // btntaotaikhoan
            // 
            this.btntaotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btntaotaikhoan.Image = global::QuanLiNS.Properties.Resources.Save_16x16;
            this.btntaotaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaotaikhoan.Location = new System.Drawing.Point(175, 332);
            this.btntaotaikhoan.Name = "btntaotaikhoan";
            this.btntaotaikhoan.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btntaotaikhoan.Size = new System.Drawing.Size(155, 45);
            this.btntaotaikhoan.TabIndex = 2;
            this.btntaotaikhoan.Text = "Ghi nhận";
            this.btntaotaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntaotaikhoan.UseVisualStyleBackColor = true;
            this.btntaotaikhoan.Click += new System.EventHandler(this.btntaotaikhoan_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btncancel.Image = global::QuanLiNS.Properties.Resources.Cancel_16x16;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(50, 332);
            this.btncancel.Name = "btncancel";
            this.btncancel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btncancel.Size = new System.Drawing.Size(119, 45);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // ftaoAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 389);
            this.Controls.Add(this.btntaotaikhoan);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtrepassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttenhienthi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label1);
            this.Name = "ftaoAccount";
            this.Text = "ftaoAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenhienthi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrepassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btntaotaikhoan;
    }
}