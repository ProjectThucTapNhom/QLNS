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
    public partial class fQuanLiAccount : Form
    {
        public fQuanLiAccount()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "insert into Account values(N'" + txtusername.Text + "',N'" + txttenhienthi.Text + "',N'" + txtpassword.Text + "'," + txtmanv.Text + " )";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            hienthi();
        }
        private void hienthi()
        {
            string query = " Select MaNV as [Mã nhân viên] , [Ten hien thi] as [Tên hiển thị] , UserName , Password  from  Account " ;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            dgv.DataSource = result;
        }
        private void fQuanLiAccount_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            string query = " update Account set UserName=N'" + txtusername.Text + "',[Ten hien thi]=N'" + txttenhienthi.Text + "',Password=N'" + txtpassword.Text + "' where MaNV=" + txtmanv.Text ;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            hienthi();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Account where MaNV="+txtmanv.Text+"";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            hienthi();
        }
        int dong;
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dong != -1)
            {
                txtmanv.Text = dgv.Rows[dong].Cells[0].Value.ToString();
                txttenhienthi.Text = dgv.Rows[dong].Cells[1].Value.ToString();
                txtusername.Text = dgv.Rows[dong].Cells[2].Value.ToString();
                txtpassword.Text = dgv.Rows[dong].Cells[3].Value.ToString();
            }
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (txtmanv.Text != "")
            {
                dong = e.RowIndex;
                txtmanv.Text = dgv.Rows[dong].Cells[0].Value.ToString();
                txttenhienthi.Text = dgv.Rows[dong].Cells[1].Value.ToString();
                txtusername.Text = dgv.Rows[dong].Cells[2].Value.ToString();
                txtpassword.Text = dgv.Rows[dong].Cells[3].Value.ToString();
                if (txtmanv.Text != "" && txttenhienthi.Text != "" && txtpassword.Text != "")
                {
                    string query = " update Account set UserName=N'" + txtusername.Text + "',[Ten hien thi]=N'" + txttenhienthi.Text + "',Password=N'" + txtpassword.Text + "' where MaNV=" + txtmanv.Text;
                    DataTable r = DataProvider.Instance.ExecuteQuery(query);
                }
            }
        }
        
    }
}
