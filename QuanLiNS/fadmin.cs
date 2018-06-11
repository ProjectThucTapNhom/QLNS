using QuanLiNS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNS
{
    public partial class fadmin : Form
    {
        public fadmin()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            update f = new update();
            f.ShowDialog();
            this.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editPB f = new editPB();
            f.ShowDialog();
            this.Show();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBangLuong f = new EditBangLuong();
            f.ShowDialog();
            this.Show();
        }

        private void trìnhĐộHọcVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TDHV f = new TDHV();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLíAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLiAccount f = new fQuanLiAccount();
            f.ShowDialog();
            this.Show();

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            f.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbAboutTable.Text = "Bảng nhân viên";
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],DiaChi as [Địa chỉ],SoDienThoai as [Số điện thoại],Ngaysinh as [Ngày sinh],GioiTinh as [Giới tính],CMND,DanToc as [Dân tộc],GhiChu as [Ghi chú] from NhanVien";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void thayĐổiTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDesignerAccountAdmin f = new fDesignerAccountAdmin();
            f.ShowDialog();
            lbtenhienthi.Text = "Xin chào " + Userinfo.tenhienthi + " !!!";
        }

        private void lươngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbAboutTable.Text = "Bảng lương";
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],TienLuong as [Lương] from NhanVien as NV join Luong on NV.Maluong = Luong.MaLuong";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void chứcVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbAboutTable.Text = "Bảng chức vụ";
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],ChucVu as [Chức vụ] from NhanVien as NV join ChucVu on NV.MaCV=ChucVu.MaChucVu";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void phòngBanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbAboutTable.Text = "Bảng phòng ban";
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],[Tên phòng] from NhanVien as NV join PhongBan on NV.MaPB=PhongBan.MaPB";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void trìnhĐộHọcVấnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbAboutTable.Text = "Bảng trình độ học vấn";
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],[Trình Độ Học Vấn] from NhanVien as NV join TDHV on NV.MaTDHV=TDHV.MaTDHV";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void fadmin_Load(object sender, EventArgs e)
        {
            // Hiển thị xin chào
            string str = @"Data Source=DESKTOP-43K34AM\SQLEXPRESS;Initial Catalog=QuanLiNS;Integrated Security=True";
            SqlConnection sqlconnect = new SqlConnection(str);
            sqlconnect.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Tên hiển thị] FROM Admin join NhanVien on Admin.MaNV=NhanVien.MaNV where Admin.UserName= '" + Userinfo.username + "'", sqlconnect);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) { Userinfo.tenhienthi = dr[0].ToString(); lbtenhienthi.Text = "Xin chào " + Userinfo.tenhienthi + " !!!"; }
            sqlconnect.Close();
            //Hiểm thị bảng nhân viên
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],DiaChi as [Địa chỉ],SoDienThoai as [Số điện thoại],Ngaysinh as [Ngày sinh],GioiTinh as [Giới tính],CMND,DanToc as [Dân tộc],GhiChu as [Ghi chú] from NhanVien";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void xemBảngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
