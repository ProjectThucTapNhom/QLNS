namespace QuanLiNS
{
    partial class TDHV
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dsd = new System.Windows.Forms.Label();
            this.txtmatdhv = new System.Windows.Forms.TextBox();
            this.Tà = new System.Windows.Forms.Label();
            this.txttdhv = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btncancel.Image = global::QuanLiNS.Properties.Resources.Cancel_16x16;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(26, 27);
            this.btncancel.Name = "btncancel";
            this.btncancel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btncancel.Size = new System.Drawing.Size(117, 47);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = global::QuanLiNS.Properties.Resources.Add_16x16;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(162, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAdd.Size = new System.Drawing.Size(97, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Image = global::QuanLiNS.Properties.Resources.Edit_16x16;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(293, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnEdit.Size = new System.Drawing.Size(97, 47);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btndelete.Image = global::QuanLiNS.Properties.Resources.Clear_16x16;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(441, 27);
            this.btndelete.Name = "btndelete";
            this.btndelete.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btndelete.Size = new System.Drawing.Size(120, 47);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dsd
            // 
            this.dsd.AutoSize = true;
            this.dsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.dsd.Location = new System.Drawing.Point(193, 109);
            this.dsd.Name = "dsd";
            this.dsd.Size = new System.Drawing.Size(176, 20);
            this.dsd.TabIndex = 1;
            this.dsd.Text = "Mã trình độ học vấn :";
            // 
            // txtmatdhv
            // 
            this.txtmatdhv.Location = new System.Drawing.Point(393, 106);
            this.txtmatdhv.Multiline = true;
            this.txtmatdhv.Name = "txtmatdhv";
            this.txtmatdhv.Size = new System.Drawing.Size(208, 34);
            this.txtmatdhv.TabIndex = 2;
            // 
            // Tà
            // 
            this.Tà.AutoSize = true;
            this.Tà.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Tà.Location = new System.Drawing.Point(290, 158);
            this.Tà.Name = "Tà";
            this.Tà.Size = new System.Drawing.Size(79, 20);
            this.Tà.TabIndex = 1;
            this.Tà.Text = "Trình độ:";
            // 
            // txttdhv
            // 
            this.txttdhv.Location = new System.Drawing.Point(393, 155);
            this.txttdhv.Multiline = true;
            this.txttdhv.Name = "txttdhv";
            this.txttdhv.Size = new System.Drawing.Size(208, 34);
            this.txttdhv.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(183, 195);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(529, 240);
            this.dgv.TabIndex = 3;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            // 
            // TDHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txttdhv);
            this.Controls.Add(this.Tà);
            this.Controls.Add(this.txtmatdhv);
            this.Controls.Add(this.dsd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btncancel);
            this.Name = "TDHV";
            this.Text = "TDHV";
            this.Load += new System.EventHandler(this.TDHV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label dsd;
        private System.Windows.Forms.TextBox txtmatdhv;
        private System.Windows.Forms.Label Tà;
        private System.Windows.Forms.TextBox txttdhv;
        private System.Windows.Forms.DataGridView dgv;
    }
}