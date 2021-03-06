﻿using QuanLiNS.DAO;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],DiaChi as [Địa chỉ],SoDienThoai as [Số điện thoại],Ngaysinh as [Ngày sinh],GioiTinh as [Giới tính],CMND,DanToc as [Dân tộc],GhiChu as [Ghi chú] from NhanVien";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
            // Hiển thị Tên tài khoản , luôn luôn update khi tải form
            string str = @"Data Source=DESKTOP-43K34AM\SQLEXPRESS;Initial Catalog=QuanLiNS;Integrated Security=True";
            SqlConnection sqlconnect = new SqlConnection(str);
            sqlconnect.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Ten hien thi] FROM Account join NhanVien on Account.MaNV=NhanVien.MaNV where Account.UserName= '" +Userinfo.username+ "'", sqlconnect);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())  { Userinfo.tenhienthi = dr[0].ToString();lbtenhienthi.Text = "Xin chào " + Userinfo.tenhienthi + " !!!"; }
            sqlconnect.Close();
            
        }
        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TitleTable.Text = "Phòng ban";
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],[Tên phòng] from NhanVien as NV join PhongBan on NV.MaPB=PhongBan.MaPB";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void trìnhĐộHọcVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TitleTable.Text = "Trình độ học vấn";
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],[Trình Độ Học Vấn] from NhanVien as NV join TDHV on NV.MaTDHV=TDHV.MaTDHV";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TitleTable.Text = "Chức vụ";
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],ChucVu as [Chức vụ] from NhanVien as NV join ChucVu on NV.MaCV=ChucVu.MaChucVu";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TitleTable.Text = "Lương";
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],TienLuong as [Lương] from NhanVien as NV join Luong on NV.Maluong = Luong.MaLuong";
          dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],DiaChi as [Địa chỉ],SoDienThoai as [Số điện thoại],Ngaysinh as [Ngày sinh],GioiTinh as [Giới tính],CMND,DanToc as [Dân tộc],GhiChu as [Ghi chú] from NhanVien";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if( MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            //  {
            //     this.Close();
            //  }
           
            this.Close();
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            fAccount f = new fAccount();
            f.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            update f = new update();
            f.ShowDialog();
            this.Show();
        }

        private void bảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            editPB f = new editPB();
            f.ShowDialog();
            this.Show();
        }

        private void bảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditBangLuong f = new EditBangLuong();
            f.ShowDialog();
            this.Show();
        }

        private void bảngTrìnhĐộHọcVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TDHV f = new TDHV();
            f.ShowDialog();
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDesignerAccount f = new fDesignerAccount();
            f.ShowDialog();
            lbtenhienthi.Text ="Xin chào  "+ Userinfo.tenhienthi + "!!!";
            this.Show();
           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
