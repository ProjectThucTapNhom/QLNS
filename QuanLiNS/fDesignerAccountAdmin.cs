using QuanLiNS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNS
{
    public partial class fDesignerAccountAdmin : Form
    {
        public fDesignerAccountAdmin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable result;
            string query;
            if (txttenhienthi.Text != Userinfo.tenhienthi)
            {
                query = "update Admin set [Tên hiển thị]=N'" + txttenhienthi.Text + "' where Username=N'" + Userinfo.username + "'";
                result = DataProvider.Instance.ExecuteQuery(query);
                Userinfo.tenhienthi = txttenhienthi.Text;
                MessageBox.Show("Cập nhật tên hiển thị thành công!!!");
                this.Close();

            }
            if (txtoldpassword.Text != "")
            {
                if (txtoldpassword.Text == Userinfo.password)
                {
                    if (txtnewpassword.Text != "")
                    {
                        if (txtnewpassword.Text == txtrepassword.Text)
                        {
                            query = "update Admin set [Password] = N'" + txtnewpassword.Text + "' where [Username] = N'" + Userinfo.username + "'";
                            result = DataProvider.Instance.ExecuteQuery(query);
                            MessageBox.Show("Cập nhật mật khẩu thành công!!!");
                        }
                        else MessageBox.Show("Mật khẩu mới không trùng khớp!!!");
                    }
                    else MessageBox.Show("Vui lòng nhập mật khẩu mới!!!");
                }
                else MessageBox.Show("Mật khẩu không chính xác!!!");
            }
        }

        private void fDesignerAccountAdmin_Load(object sender, EventArgs e)
        {
            txttenhienthi.Text = Userinfo.tenhienthi;
        }
    }
}
