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
    public partial class editPB : Form
    {
        public editPB()
        {
            InitializeComponent();
        }
        private void hienthiphongban()
        {
            string Query = "select [Tên phòng], MaPB as [Mã phòng] from PhongBan";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void editPB_Load(object sender, EventArgs e)
        {
            hienthiphongban();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtmapb.Text != null)
            {
                string query = "insert into PhongBan values( @mapb , @ten )";
                DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { txtmapb.Text, txttenpb.Text });
            }
            hienthiphongban();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmapb.Text != null)
            {
                string mapb = txtmapb.Text; string tenpb = txttenpb.Text;
                string Query = " update PhongBan set  [Tên phòng] =   @tenpb  WHERE MaPB =   @mapb ";
                DataTable Result = DataProvider.Instance.ExecuteQuery(Query,new object[]{ tenpb, mapb });
            }
            hienthiphongban();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string i = txtmapb.Text;
                string Query = "delete from PhongBan Where MaPB='" + i + "'";
                dgv.DataSource= DataProvider.Instance.ExecuteQuery(Query);
            }
            hienthiphongban();
        }
        int dong;
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txttenpb.Text= dgv.Rows[dong].Cells[0].Value.ToString();
            txtmapb.Text = dgv.Rows[dong].Cells[1].Value.ToString();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txttenpb.Text = dgv.Rows[dong].Cells[0].Value.ToString();
            txtmapb.Text = dgv.Rows[dong].Cells[1].Value.ToString();
            if(txttenpb.Text!="")
            {
                string mapb = txtmapb.Text; string tenpb = txttenpb.Text;
                string Query = " update PhongBan set  [Tên phòng] =   @tenpb  WHERE MaPB =   @mapb ";
                DataTable Result = DataProvider.Instance.ExecuteQuery(Query, new object[] { tenpb, mapb });
            }
        }
    }
}
