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
    public partial class fDesignerAccount : Form
    {
        public fDesignerAccount()
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
            if (txttenhienthi.Text!=Userinfo.tenhienthi)
            {
              query = "update Account set [Ten hien thi]=N'"+txttenhienthi.Text+"' where UserName=N'"+Userinfo.username+"'";
              result = DataProvider.Instance.ExecuteQuery(query);
              Userinfo.tenhienthi = txttenhienthi.Text;
              MessageBox.Show("Cập nhật tên hiển thị thành công!!!");
              this.Close();

            }
            if(txtoldpassword.Text != "")
            {
                if (txtoldpassword.Text == Userinfo.password)
                {
                    if (txtnewpassword.Text != "")
                    {
                        if(txtnewpassword.Text==txtrepassword.Text)
                        {
                            query = "update Account set [Password] = N'"+ txtnewpassword.Text + "' where [UserName] = N'"+ Userinfo.username + "'";
                            result= DataProvider.Instance.ExecuteQuery(query );
                            MessageBox.Show("Cập nhật mật khẩu thành công!!!");
                        }
                       else MessageBox.Show("Mật khẩu mới không trùng khớp!!!");
                    }
                    else MessageBox.Show("Vui lòng nhập mật khẩu mới!!!");
                }
                else MessageBox.Show("Mật khẩu không chính xác!!!");
            }   
        }

        private void fDesignerAccount_Load(object sender, EventArgs e)
        {
            txttenhienthi.Text =Userinfo.tenhienthi;
        }
    }
}
