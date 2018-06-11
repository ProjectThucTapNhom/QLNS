namespace QuanLiNS
{
    partial class editPB
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
            this.label2 = new System.Windows.Forms.Label();
            this.txttenpb = new System.Windows.Forms.TextBox();
            this.txtmapb = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng";
            // 
            // txttenpb
            // 
            this.txttenpb.Location = new System.Drawing.Point(56, 140);
            this.txttenpb.Name = "txttenpb";
            this.txttenpb.Size = new System.Drawing.Size(235, 26);
            this.txttenpb.TabIndex = 2;
            // 
            // txtmapb
            // 
            this.txtmapb.Location = new System.Drawing.Point(389, 140);
            this.txtmapb.Name = "txtmapb";
            this.txtmapb.Size = new System.Drawing.Size(248, 26);
            this.txtmapb.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(101, 215);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(500, 260);
            this.dgv.TabIndex = 3;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndelete.Image = global::QuanLiNS.Properties.Resources.Clear_16x16;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(505, 30);
            this.btndelete.Name = "btndelete";
            this.btndelete.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btndelete.Size = new System.Drawing.Size(128, 60);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnedit.Image = global::QuanLiNS.Properties.Resources.EditName_16x16;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(352, 30);
            this.btnedit.Name = "btnedit";
            this.btnedit.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnedit.Size = new System.Drawing.Size(128, 60);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnadd.Image = global::QuanLiNS.Properties.Resources.Add_16x16;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(189, 30);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnadd.Size = new System.Drawing.Size(128, 60);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncancel.Image = global::QuanLiNS.Properties.Resources.Cancel_16x16;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(44, 30);
            this.btncancel.Name = "btncancel";
            this.btncancel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btncancel.Size = new System.Drawing.Size(128, 60);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // editPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 487);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtmapb);
            this.Controls.Add(this.txttenpb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btncancel);
            this.Name = "editPB";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.editPB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenpb;
        private System.Windows.Forms.TextBox txtmapb;
        private System.Windows.Forms.DataGridView dgv;
    }
}