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
    public partial class TDHV : Form
    {
        public TDHV()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            string query = "select MaTDHV as [Mã trình độ học vấn],[Trình độ học vấn] from TDHV";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmatdhv.Text != null)
            {
                string query = "insert  into TDHV values ( @a , @b )  ";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { txtmatdhv.Text, txttdhv.Text });
            }
            hienthi();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtmatdhv !=null)
            {
                string query = "update TDHV set [Trình Độ Học Vấn]= @a where MaTDHV= @b ";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { txttdhv.Text, txtmatdhv.Text });
            }
            hienthi();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string i = txtmatdhv.Text;
                string query = "delete from TDHV where MaTDHV='" + i + "' ";
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
            }
            hienthi();
        }
        int dong;
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dong >= 0)
            {
                txtmatdhv.Text = dgv.Rows[dong].Cells[0].Value.ToString();
                txttdhv.Text = dgv.Rows[dong].Cells[1].Value.ToString();
            }
        }

        private void TDHV_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if( dong >=0)
            {
                txtmatdhv.Text = dgv.Rows[dong].Cells[0].Value.ToString();
                txttdhv.Text = dgv.Rows[dong].Cells[1].Value.ToString();
                string query = "update TDHV set [Trình Độ Học Vấn]= @a where MaTDHV= @b ";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { txttdhv.Text, txtmatdhv.Text });
              
            }
        }
    }
}
