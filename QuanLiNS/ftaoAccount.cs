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
    public partial class ftaoAccount : Form
    {
        public ftaoAccount()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntaotaikhoan_Click(object sender, EventArgs e)
        {
            if (txttenhienthi.Text != "")
            {
                if (txtusername.Text != "")
                {
                    if (txtpassword.Text != "")
                    {
                        if (txtpassword.Text == txtrepassword.Text)
                        {
                            string query = "insert into Account values(N'"+txtusername.Text+"',N'"+txttenhienthi.Text+"',N'"+txtpassword.Text+"',"+txtmanv.Text+" )";
                            DataTable result = DataProvider.Instance.ExecuteQuery(query);
                            MessageBox.Show("Tạo tài khoản thành công !!!");
                            this.Close();
                        }
                        else MessageBox.Show("Mật khẩu không đồng nhât !!!");
                    }
                    else MessageBox.Show("Xin vui lòng nhập password !!!");
                }
                else MessageBox.Show("Xin vui lòng nhập tên username!!!");
            }
            else MessageBox.Show("Xin vui lòng nhập tên hiển thị !!!");
        }
    }
}
