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
    public partial class EditBangLuong : Form
    {
        public EditBangLuong()
        {
            InitializeComponent();
        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtmaluong != null)
            {
                string query = "insert into Luong values( @a , @b )";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { txtmaluong.Text, txtluong.Text });
            }
            hienthi();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmaluong.Text != null)
            {
                string query = "update Luong set TienLuong= @a where MaLuong= @b ";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { txtluong.Text, txtmaluong.Text });
            }
            hienthi();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string i = txtmaluong.Text;
                string query = "delete from Luong where MaLuong= @a ";
                dgv.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { i });
            }
            hienthi();
        }
        int dong;
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtmaluong.Text = dgv.Rows[dong].Cells[0].Value.ToString();
            txtluong.Text = dgv.Rows[dong].Cells[1].Value.ToString();
        }

        private void EditBangLuong_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        private void hienthi()
        {
            string query = "select MaLuong as [Mã lương], TienLuong as [Tiền lương] from Luong";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtmaluong.Text = dgv.Rows[dong].Cells[0].Value.ToString();
            txtluong.Text = dgv.Rows[dong].Cells[1].Value.ToString();
            if (txtluong.Text!="")
            {
                string query = "update Luong set TienLuong= @a where MaLuong= @b ";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { txtluong.Text, txtmaluong.Text });
            }
        }
        
    }
}
