using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.DAL;
using QLNS.BLL;
using System.Data.SqlClient;

namespace QLNS.GUI
{
    public partial class FrmQLNS : Form
    {
        BindingSource ListNv = new BindingSource();
        SqlConnection sqlConnection = new SqlConnection();
        public FrmQLNS()
        {
            InitializeComponent();
            string connString = @"Data Source=DESKTOP-34CKI58\HOAI;Initial Catalog=QLNS;Integrated Security=True";
            sqlConnection.ConnectionString = connString;
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaCV,TenCV FROM ChucVu", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbChucVu.DisplayMember = "TenCV";
            cbbChucVu.ValueMember = "MaCV";
            cbbChucVu.DataSource = dt;
            adapter = new SqlDataAdapter("SELECT MaTT,TenTT FROM TrangThai", sqlConnection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            cbbTrangThai.DisplayMember = "TenTT";
            cbbTrangThai.ValueMember = "MaTT";
            cbbTrangThai.DataSource = data;
            adapter = new SqlDataAdapter("SELECT MaPB,TenPB FROM PhongBan", sqlConnection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbbPhongBan.DisplayMember = "TenPB";
            cbbPhongBan.ValueMember = "MaPB";
            cbbPhongBan.DataSource = dataTable;
            adapter = new SqlDataAdapter("SELECT MaLHD,TenLHD FROM LoaiHopDong", sqlConnection);
            DataTable dT = new DataTable();
            adapter.Fill(dT);
            cbbLoaiHD.DisplayMember = "TenLHD";
            cbbLoaiHD.ValueMember = "MaLHD";
            cbbLoaiHD.DataSource = dT;
            adapter = new SqlDataAdapter("SELECT MaLCB,Luong FROM LuongCoBan", sqlConnection);
            DataTable da = new DataTable();
            adapter.Fill(da);
            cbbLCB.DisplayMember = "Luong";
            cbbLCB.ValueMember = "MaLCB";
            cbbLCB.DataSource = da;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(1);
            }
        }

        private void picAva_Click(object sender, EventArgs e)
        {
            DialogResult result = openFile.ShowDialog();

            //Kiểm tra xem người dùng đã chọn file chưa
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFile.FileName);

                // Gán ảnh
                picAva.BackgroundImage = img;
            }
        }

        private void TabConDSNV_Click(object sender, EventArgs e)
        {

            ListNv.DataSource = NhanVienDAO.Instance.LayDL();
            dgvNhanVien.DataSource = ListNv;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtTimKiem.Text;
            dgvNhanVien.DataSource = ListNv;
            ListNv.DataSource = NhanVienDAO.Instance.SearchKH(str);
        }
        private void XoaTrang()
        {
            txtCMT.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtNoiO.Text = "";
            txtQue.Text = "";
            lblMaNV.Text = "";
            lblSoHD.Text = "";
        }
        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (txtCMT.Text == null || txtHoTen.Text == null)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu");
                return;
            }
            long a, b, c, d;
            long lcb,n;
            long.TryParse(cbbPhongBan.SelectedValue.ToString(), out a);
            long.TryParse(cbbLoaiHD.SelectedValue.ToString(), out b);
            long.TryParse(cbbTrangThai.SelectedValue.ToString(), out c);
            long.TryParse(cbbChucVu.SelectedValue.ToString(), out n);
            long.TryParse(cbbLCB.SelectedValue.ToString(), out lcb);
            if (long.TryParse(lblMaNV.Text, out d))
            {
                NhanVien nv = new NhanVien(d, txtHoTen.Text, a, txtQue.Text, dtpNgaySinh.Value,
                     txtEmail.Text, txtSDT.Text,txtCMT.Text, dtpNBD.Value, lcb,n);
                NhanVienDAO nvb = new NhanVienDAO();
                if (!nvb.Update(nv)) MessageBox.Show("Sai cmnr!");
                else MessageBox.Show("Sửa nhân viên thành công!");

            }
            else
            {
                NhanVien nv = new NhanVien(0, txtHoTen.Text, a, txtQue.Text, dtpNgaySinh.Value,
                     txtEmail.Text, txtSDT.Text,txtCMT.Text, dtpNBD.Value, lcb,n);

                NhanVienDAO bll = new NhanVienDAO();
                ChiTietTT tt = new ChiTietTT(c, 0, dtpNBBTT.Value, "");
                HopDong hd = new HopDong(0, 0, lcb, dtpNBD.Value);
                if (bll.Insert(nv, hd, tt)) MessageBox.Show("Sai cmnr");
                else
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    XoaTrang();
                }
            }

        }

        private void DgvNhanVien_DoubleClick(object sender, EventArgs e)
        { 
            int index = dgvNhanVien.Rows.IndexOf(dgvNhanVien.SelectedRows[0]);

            lblMaNV.Text = dgvNhanVien.Rows[index].Cells["MaNV"].Value.ToString();
            txtCMT.Text = dgvNhanVien.Rows[index].Cells["CMT"].Value.ToString();
            dtpNBD.Value = DateTime.Parse(dgvNhanVien.Rows[index].Cells["NgayBatDau"].Value.ToString());
            dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[index].Cells["NgaySinh"].Value.ToString());
            txtEmail.Text = dgvNhanVien.Rows[index].Cells["email"].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[index].Cells["HoTen"].Value.ToString();
            txtQue.Text = dgvNhanVien.Rows[index].Cells["QueQuan"].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[index].Cells["SDT"].Value.ToString();
            cbbPhongBan.SelectedValue = dgvNhanVien.Rows[index].Cells["MaPB"].Value.ToString();
            cbbLCB.SelectedValue = dgvNhanVien.Rows[index].Cells["MaLCB"].Value.ToString();
        }

        private void BtnTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChinh frm = new FrmChinh();
            frm.Show();
        }
        private void btnLuong_Click(object sender, EventArgs e)
        {
            Form frm = new FrmQLNS();
            frm.Show();
            this.Hide();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            Form frm = new FrmChamCong();
            frm.Show();
            this.Hide();
        }
    }
}
