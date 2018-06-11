namespace QuanLiNS
{
    partial class fDesignerAccountAdmin
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
            this.txttenhienthi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrepassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hiển thị:";
            // 
            // txttenhienthi
            // 
            this.txttenhienthi.Location = new System.Drawing.Point(63, 85);
            this.txttenhienthi.Name = "txttenhienthi";
            this.txttenhienthi.Size = new System.Drawing.Size(407, 26);
            this.txttenhienthi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(59, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Location = new System.Drawing.Point(63, 221);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(407, 26);
            this.txtoldpassword.TabIndex = 2;
            this.txtoldpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(59, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(63, 313);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(407, 26);
            this.txtnewpassword.TabIndex = 3;
            this.txtnewpassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chỉnh sửa tài khoản<nếu có>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đổi mật khẩu<nếu có>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(59, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập lại mật khẩu:";
            // 
            // txtrepassword
            // 
            this.txtrepassword.Location = new System.Drawing.Point(63, 399);
            this.txtrepassword.Name = "txtrepassword";
            this.txtrepassword.Size = new System.Drawing.Size(407, 26);
            this.txtrepassword.TabIndex = 4;
            this.txtrepassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::QuanLiNS.Properties.Resources.Cancel_16x16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(144, 476);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.button1.Size = new System.Drawing.Size(124, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::QuanLiNS.Properties.Resources.Save_16x16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(295, 476);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.button2.Size = new System.Drawing.Size(175, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Lưu thay đổi";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fDesignerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrepassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtoldpassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttenhienthi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "fDesignerAccount";
            this.Text = "fDesignerAccount";
            this.Load += new System.EventHandler(this.fDesignerAccountAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenhienthi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtrepassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}