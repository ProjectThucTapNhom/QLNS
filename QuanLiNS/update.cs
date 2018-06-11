using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLiNS.DAO;

namespace QuanLiNS
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }
     
        private void HienThiNhanVien()
        {
            string Query = "select MaNV as [Mã nhân viên],HoTen as [Họ tên],DiaChi as [Địa chỉ],SoDienThoai as [Số điện thoại],Ngaysinh as [Ngày sinh],GioiTinh as [Giới tính],CMND,DanToc as [Dân tộc],GhiChu as [Ghi chú],MaPB as [Mã phòng ban], MaCV as [Mã chức vụ], MaTDHV as [Trình độ học vấn], MaLuong as [Mã lương]  from NhanVien";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.TextLength != 0)
            {
               DateTime date = DateTime.Parse(txtDate.Text);
                string sdt = txtSdt.Text, id = txtID.Text, hoten = txtName.Text, diachi = txtDiaChi.Text, gioitinh = txtGioiTinh.Text, CMND = txtCMND.Text, dantoc = txtDanToc.Text, ghichu = txtGhiChu.Text, mapb = txtPhongBan.Text, macv = txtCV.Text, matdhv = txtTDHV.Text, maluong = txtMaLuong.Text;
                string Query = "insert into NhanVien values( @id , @hoten , @diachi , @sdt , @date , @gioitinh , @CMND , @dantoc , @ghichu , @mapb , @macv , @matdhv , @maluong )";
                DataTable result = DataProvider.Instance.ExecuteQuery(Query, new object[] { id, hoten, diachi, sdt, date, gioitinh, CMND, dantoc, ghichu, mapb, macv, matdhv, maluong });
            }
            HienThiNhanVien();
        }
        
        private void update_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.TextLength != 0)
            {
                DateTime date = DateTime.Parse(txtDate.Text);
                string sdt=txtSdt.Text, id=txtID.Text, hoten = txtName.Text, diachi = txtDiaChi.Text, gioitinh= txtGioiTinh.Text, CMND=txtCMND.Text, dantoc=txtDanToc.Text,ghichu=txtGhiChu.Text, mapb=txtPhongBan.Text,macv=txtCV.Text,matdhv=txtTDHV.Text,maluong=txtMaLuong.Text;
                string Query = "update NhanVien set  HoTen=  @hoten  ,DiaChi=  @diachi  ,SoDienThoai=  @sdt  ,Ngaysinh=  @date  ,GioiTinh= @gioitinh ,CMND= @CMND ,DanToc= @dantoc ,GhiChu= @ghichu ,MaPB= @mapb ,MaCV= @macv ,MaTDHV= @matdhv ,MaLuong= @maluong where     MaNV= @id ";
                DataTable result = DataProvider.Instance.ExecuteQuery(Query, new object[] { hoten, diachi, sdt, date, gioitinh, CMND, dantoc, ghichu, mapb, macv, matdhv, maluong, id });
            }
            HienThiNhanVien();
        }
        int dong;
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtID.Text = dgv.Rows[dong].Cells[0].Value.ToString();
            txtName.Text= dgv.Rows[dong].Cells[1].Value.ToString();
            txtDiaChi.Text= dgv.Rows[dong].Cells[2].Value.ToString();
            txtSdt.Text= dgv.Rows[dong].Cells[3].Value.ToString();
            txtDate.Text= dgv.Rows[dong].Cells[4].Value.ToString();
            txtGioiTinh.Text= dgv.Rows[dong].Cells[5].Value.ToString();
            txtCMND.Text= dgv.Rows[dong].Cells[6].Value.ToString();
            txtDanToc.Text= dgv.Rows[dong].Cells[7].Value.ToString();
            txtGhiChu.Text= dgv.Rows[dong].Cells[8].Value.ToString();
            txtPhongBan.Text= dgv.Rows[dong].Cells[9].Value.ToString();
            txtCV.Text= dgv.Rows[dong].Cells[10].Value.ToString();
            txtTDHV.Text= dgv.Rows[dong].Cells[11].Value.ToString();
            txtMaLuong.Text= dgv.Rows[dong].Cells[12].Value.ToString();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string id = txtID.Text;
                string Query = "delete from NhanVien Where MaNV='" + id + "'";
                dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
            }
            HienThiNhanVien();
        }

        

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (txtID.Text != "")
            {
                dong = e.RowIndex;
                txtID.Text = dgv.Rows[dong].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[dong].Cells[1].Value.ToString();
                txtDiaChi.Text = dgv.Rows[dong].Cells[2].Value.ToString();
                txtSdt.Text = dgv.Rows[dong].Cells[3].Value.ToString();
                txtDate.Text = dgv.Rows[dong].Cells[4].Value.ToString();
                txtGioiTinh.Text = dgv.Rows[dong].Cells[5].Value.ToString();
                txtCMND.Text = dgv.Rows[dong].Cells[6].Value.ToString();
                txtDanToc.Text = dgv.Rows[dong].Cells[7].Value.ToString();
                txtGhiChu.Text = dgv.Rows[dong].Cells[8].Value.ToString();
                txtPhongBan.Text = dgv.Rows[dong].Cells[9].Value.ToString();
                txtCV.Text = dgv.Rows[dong].Cells[10].Value.ToString();
                txtTDHV.Text = dgv.Rows[dong].Cells[11].Value.ToString();
                txtMaLuong.Text = dgv.Rows[dong].Cells[12].Value.ToString();
                    DateTime date = DateTime.Parse(txtDate.Text);
                    string sdt = txtSdt.Text, id = txtID.Text, hoten = txtName.Text, diachi = txtDiaChi.Text, gioitinh = txtGioiTinh.Text, CMND = txtCMND.Text, dantoc = txtDanToc.Text, ghichu = txtGhiChu.Text, mapb = txtPhongBan.Text, macv = txtCV.Text, matdhv = txtTDHV.Text, maluong = txtMaLuong.Text;
                    string Query = "update NhanVien set  HoTen=  @hoten  ,DiaChi=  @diachi  ,SoDienThoai=  @sdt  ,Ngaysinh=  @date  ,GioiTinh= @gioitinh ,CMND= @CMND ,DanToc= @dantoc ,GhiChu= @ghichu ,MaPB= @mapb ,MaCV= @macv ,MaTDHV= @matdhv ,MaLuong= @maluong where     MaNV= @id ";
                    DataTable result = DataProvider.Instance.ExecuteQuery(Query, new object[] { hoten, diachi, sdt, date, gioitinh, CMND, dantoc, ghichu, mapb, macv, matdhv, maluong, id });
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string id = txtSearch.Text;
            string Query = "select *from NhanVien Where Hoten like N'" + id + "%'";
            dgv.DataSource = DataProvider.Instance.ExecuteQuery(Query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
