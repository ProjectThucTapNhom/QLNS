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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            if (Login(txtusername.Text, txtpassword.Text))
            {
                string username = txtusername.Text;
                string password = txtpassword.Text;
                Userinfo.username = username;
                Userinfo.password = password;
                
                Form1 f = new Form1();
                f.ShowDialog();
               
            }
            else if(Login1(txtusername.Text, txtpassword.Text))
            {
                string username = txtusername.Text;
                string password = txtpassword.Text;
                Userinfo.username = username;
                Userinfo.password = password;
                fadmin f = new fadmin();
               
                f.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!");
            }
          
        }
        internal bool Login(string username, string password)
        {
            string query = "USP_Login @username , @passwword";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;

        }
        internal bool Login1(string username, string password)
        {
            string query = "USP_Login1 @username , @passwword";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;

        }
       

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            ftaoAccount f = new ftaoAccount();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
            this.Show();
        }
    }
}
