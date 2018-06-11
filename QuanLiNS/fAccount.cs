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
    public partial class fAccount : Form
    {
        public fAccount()
        {
            InitializeComponent();
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            // Tên hiển thị
            lbtenhienthi.Text = Userinfo.tenhienthi + "!!!";
            // Xuất thông tin từ các bảng trong CSDL ra từng label
            string str = @"Data Source=DESKTOP-43K34AM\SQLEXPRESS;Initial Catalog=QuanLiNS;Integrated Security=True";
            SqlConnection sqlconnect = new SqlConnection(str);

            // Xử lí about  Nhân viên
            sqlconnect.Open();
            SqlCommand cmd = new SqlCommand(" select NhanVien.MaNV as [Mã nhân viên],HoTen as [Họ tên],DiaChi as [Địa chỉ],SoDienThoai as [Số điện thoại],Ngaysinh as [Ngày sinh],GioiTinh as [Giới tính],CMND,DanToc as [Dân tộc],GhiChu as [Ghi chú]from NhanVien join Account on NhanVien.MaNV=Account.MaNV where Account.UserName=N'"+Userinfo.username+ "'", sqlconnect);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string masv= dr[0].ToString();
                lb1.Text = dr[0].ToString();
                lb2.Text = dr[1].ToString();
                lb3.Text = dr[2].ToString();
                lb4.Text = dr[3].ToString();
                string t = dr[4].ToString();
                DateTime dt = DateTime.Parse(t);
                string strDateNow = dt.ToString("dd/MM/yyyy");
                lb5.Text = strDateNow;
                lb6.Text = dr[5].ToString();
                lb7.Text = dr[6].ToString();
                lb8.Text = dr[7].ToString();
                lb9.Text = dr[8].ToString();
                sqlconnect.Close();
                sqlconnect.Open();
                SqlCommand cmd1 = new SqlCommand("select ChucVu.ChucVu from NhanVien join ChucVu on NhanVien.MaCV=ChucVu.MaChucVu where NhanVien.MaNV=" + masv , sqlconnect);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    lb10.Text = dr1[0].ToString();
                }
                sqlconnect.Close();
                sqlconnect.Open();
                SqlCommand cmd2 = new SqlCommand("select TDHV.[Trình Độ Học Vấn] from NhanVien join TDHV on NhanVien.MaTDHV=TDHV.MaTDHV where NhanVien.MaNV=" + masv , sqlconnect);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    lb11.Text = dr2[0].ToString();
                }
                sqlconnect.Close();
                sqlconnect.Open();
                SqlCommand cmd3 = new SqlCommand("select PhongBan.[Tên phòng] from NhanVien join PhongBan on NhanVien.MaPB=PhongBan.MaPB where NhanVien.MaNV=" + masv  , sqlconnect);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                if (dr3.Read())
                {
                    lb13.Text = dr3[0].ToString();
                }
                sqlconnect.Close();
                sqlconnect.Open();
                SqlCommand cmd4 = new SqlCommand("select Luong.TienLuong from NhanVien join Luong on NhanVien.MaLuong=Luong.MaLuong where NhanVien.MaNV=" + masv , sqlconnect);
                SqlDataReader dr4 = cmd4.ExecuteReader();
                if (dr4.Read())
                {
                    lb12.Text = dr4[0].ToString();
                }
               
                sqlconnect.Close();
            }



           // Xử lí about admin
            sqlconnect.Close();
            sqlconnect.Open();
            SqlCommand cmdd = new SqlCommand(" select NhanVien.MaNV as [Mã nhân viên],HoTen as [Họ tên],DiaChi as [Địa chỉ],SoDienThoai as [Số điện thoại],Ngaysinh as [Ngày sinh],GioiTinh as [Giới tính],CMND,DanToc as [Dân tộc],GhiChu as [Ghi chú]from NhanVien join Admin on NhanVien.MaNV=Admin.MaNV where Admin.UserName=N'" + Userinfo.username + "'", sqlconnect);
            SqlDataReader drr = cmdd.ExecuteReader();
            if (drr.Read())
            {
                string masv = drr[0].ToString();
                lb1.Text = drr[0].ToString();
                lb2.Text = drr[1].ToString();
                lb3.Text = drr[2].ToString();
                lb4.Text = drr[3].ToString();
                lb5.Text = drr[4].ToString();
                lb6.Text = drr[5].ToString();
                lb7.Text = drr[6].ToString();
                lb8.Text = drr[7].ToString();
                lb9.Text = drr[8].ToString();
                sqlconnect.Close();
                sqlconnect.Open();
                SqlCommand cmd11 = new SqlCommand("select ChucVu.ChucVu from NhanVien join ChucVu on NhanVien.MaCV=ChucVu.MaChucVu where NhanVien.MaNV=" + masv, sqlconnect);
                SqlDataReader dr11 = cmd11.ExecuteReader();
                if (dr11.Read())
                {
                    lb10.Text = dr11[0].ToString();
                }
                sqlconnect.Close();
                sqlconnect.Open();
                SqlCommand cmd21 = new SqlCommand("select TDHV.[Trình Độ Học Vấn] from NhanVien join TDHV on NhanVien.MaTDHV=TDHV.MaTDHV where NhanVien.MaNV=" + masv, sqlconnect);
                SqlDataReader dr21 = cmd21.ExecuteReader();
                if (dr21.Read())
                {
                    lb11.Text = dr21[0].ToString();
                }
                sqlconnect.Close();
                sqlconnect.Open();
                SqlCommand cmd31 = new SqlCommand("select PhongBan.[Tên phòng] from NhanVien join PhongBan on NhanVien.MaPB=PhongBan.MaPB where NhanVien.MaNV=" + masv, sqlconnect);
                SqlDataReader dr31 = cmd31.ExecuteReader();
                if (dr31.Read())
                {
                    lb13.Text = dr31[0].ToString();
                }
                sqlconnect.Close();
                sqlconnect.Open();
                SqlCommand cmd41 = new SqlCommand("select Luong.TienLuong from NhanVien join Luong on NhanVien.MaLuong=Luong.MaLuong where NhanVien.MaNV=" + masv, sqlconnect);
                SqlDataReader dr41= cmd41.ExecuteReader();
                if (dr41.Read())
                {
                    lb12.Text = dr41[0].ToString();
                }

                sqlconnect.Close();
            }
        }
    }
}
