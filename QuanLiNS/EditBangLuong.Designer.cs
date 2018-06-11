namespace QuanLiNS
{
    partial class EditBangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBangLuong));
            this.bntcancel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtmaluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bntcancel
            // 
            this.bntcancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntcancel.Image = ((System.Drawing.Image)(resources.GetObject("bntcancel.Image")));
            this.bntcancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntcancel.Location = new System.Drawing.Point(43, 17);
            this.bntcancel.Name = "bntcancel";
            this.bntcancel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.bntcancel.Size = new System.Drawing.Size(121, 58);
            this.bntcancel.TabIndex = 0;
            this.bntcancel.Text = "Cancel";
            this.bntcancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntcancel.UseVisualStyleBackColor = true;
            this.bntcancel.Click += new System.EventHandler(this.bntcancel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(187, 17);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnadd.Size = new System.Drawing.Size(107, 58);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(336, 17);
            this.btnedit.Name = "btnedit";
            this.btnedit.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnedit.Size = new System.Drawing.Size(121, 58);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(497, 17);
            this.btndelete.Name = "btndelete";
            this.btndelete.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btndelete.Size = new System.Drawing.Size(121, 58);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label.Location = new System.Drawing.Point(86, 88);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(87, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Mã lương:";
            // 
            // txtmaluong
            // 
            this.txtmaluong.Location = new System.Drawing.Point(90, 111);
            this.txtmaluong.Name = "txtmaluong";
            this.txtmaluong.Size = new System.Drawing.Size(204, 26);
            this.txtmaluong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(332, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền:";
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(336, 111);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(204, 26);
            this.txtluong.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(73, 175);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(484, 246);
            this.dgv.TabIndex = 3;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // EditBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 431);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaluong);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.bntcancel);
            this.Name = "EditBangLuong";
            this.Text = "EditBangLuong";
            this.Load += new System.EventHandler(this.EditBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntcancel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtmaluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.DataGridView dgv;
    }
}