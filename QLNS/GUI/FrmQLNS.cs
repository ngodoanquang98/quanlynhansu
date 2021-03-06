﻿using System;
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
using System.Text.RegularExpressions;

namespace QLNS.GUI
{
    public partial class FrmQLNS : Form
    {
        BindingSource ListNv = new BindingSource();
        BindingSource ListTN = new BindingSource();
        SqlConnection sqlConnection = new SqlConnection();
        public FrmQLNS()
        {
            InitializeComponent();
            try
            {
                string connString = @"Data Source=QUANG\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
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
                ListTN.DataSource = ThanNhanDAO.Instance.LayDS();
                dgvThanNhan.DataSource = ListTN;
                cbbGT.SelectedIndex = 0;
                dgvThanNhan.Refresh();
            }
            catch(Exception ex)
            {
            }
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

       
        private void TabConDSNV_Click(object sender, EventArgs e)
        {

            ListNv.DataSource = NhanVienDAO.Instance.LayDL();
            dgvNhanVien.DataSource = ListNv;
        }
        private void XoaTrang()
        {
            txtCMT.Text = "16150342";
            txtEmail.Text = "x@gmail.com";
            txtHoTen.Text = "nguyen van ";
            txtQue.Text = "nam dinh";
            lblMaNV.Text = "";
            lblSoHD.Text = "";
            txtSDT.Text = "0981588200";
        }
        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (txtCMT.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "" || txtEmail.Text == "" )
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu");
                return;
            }
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }
            if(txtSDT.TextLength != 10)
            {
                MessageBox.Show("sdt không đúng!");
            }
            Regex regex = new Regex("(09|03|05|08)+([0-9]{8})");
            if (!regex.IsMatch(txtSDT.Text) )
            {
                MessageBox.Show("SDT không hợp lệ!");
                return;
            }
            long a, b, c, d;
            long lcb, n;
            long.TryParse(cbbPhongBan.SelectedValue.ToString(), out a);
            long.TryParse(cbbLoaiHD.SelectedValue.ToString(), out b);
            long.TryParse(cbbTrangThai.SelectedValue.ToString(), out c);
            long.TryParse(cbbChucVu.SelectedValue.ToString(), out n);
            long.TryParse(cbbLCB.SelectedValue.ToString(), out lcb);
            if (long.TryParse(lblMaNV.Text, out d))
            {
                NhanVien nv = new NhanVien(d, txtHoTen.Text, a, txtQue.Text, dtpNgaySinh.Value,
                     txtEmail.Text, txtSDT.Text, txtCMT.Text, dtpNBD.Value, lcb, n, cbbGT.Text);
                NhanVienDAO nvb = new NhanVienDAO();
                if (!nvb.Update(nv)) MessageBox.Show("Sai!");
                else MessageBox.Show("Sửa nhân viên thành công!");

            }
            else
            {
                NhanVien nv = new NhanVien(0, txtHoTen.Text, a, txtQue.Text, dtpNgaySinh.Value,
                     txtEmail.Text, txtSDT.Text, txtCMT.Text, dtpNBD.Value, lcb, n, cbbGT.SelectedText);

                NhanVienDAO bll = new NhanVienDAO();
                ChiTietTT tt = new ChiTietTT(c, 0, dtpNBBTT.Value, "");
                HopDong hd = new HopDong(0, b, 0);
                if (!bll.Insert(nv, hd, tt)) MessageBox.Show("Sai !");
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
            cbbGT.Text = dgvNhanVien.Rows[index].Cells["GioiTinh"].Value.ToString();
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

        private void BtnLuuTN_Click(object sender, EventArgs e)
        {
            if(txtTenTN.Text == "" || txtSDTTN.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
                return;
            }
            long manv,matn;
            long.TryParse(txtMaNV.Text, out manv);
            if (long.TryParse(lblMaTN.Text, out matn)){
                ThanNhan tn = new ThanNhan(matn, manv, txtTenTN.Text, dtpNSTN.Value, txtSDTTN.Text);
                if (ThanNhanDAO.Update(tn)) {
                    MessageBox.Show("Sửa thành công!");
                    XoaTrangTN();
                    ListTN.DataSource = ThanNhanDAO.Instance.LayDS();
                    dgvThanNhan.DataSource = ListTN;
                    dgvThanNhan.Refresh();
                }
                else MessageBox.Show("Sửa thất bại!");
            }
            else {
                ThanNhan tn = new ThanNhan(0, manv, txtTenTN.Text, dtpNSTN.Value, txtSDTTN.Text);
                if (ThanNhanDAO.Insert(tn))
                {
                    MessageBox.Show("Thêm thành công!");
                    XoaTrangTN();
                    ListTN.DataSource = ThanNhanDAO.Instance.LayDS();
                    dgvThanNhan.DataSource = ListTN;
                    dgvThanNhan.Refresh();
                }
                else MessageBox.Show("Thêm thất bại!");
            }
        }
        
        private void XoaTrangTN()
        {
            txtSDTTN.Text = "";
            lblMaTN.Text = "";
            txtMaNV.Text = "";
            txtTenTN.Text = "";
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            XoaTrangTN();
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void TxtTimTN_TextChanged(object sender, EventArgs e)
        {
            long a;
            if(long.TryParse(txtTimTN.Text, out a))
            {
                ListTN.DataSource = ThanNhanDAO.Instance.TimTN(a);
                dgvThanNhan.DataSource = ListTN;
                dgvThanNhan.Refresh();
            }
            
        }

        private void DgvThanNhan_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvThanNhan.Rows.IndexOf(dgvThanNhan.SelectedRows[0]);
            txtTenTN.Text = dgvThanNhan.Rows[index].Cells["TenTN"].Value.ToString();
            txtSDTTN.Text = dgvThanNhan.Rows[index].Cells["SDTTN"].Value.ToString();
            txtMaNV.Text = dgvThanNhan.Rows[index].Cells["MaNVTN"].Value.ToString();
            lblMaTN.Text = dgvThanNhan.Rows[index].Cells["MaTN"].Value.ToString();
            dtpNSTN.Value =DateTime.Parse(dgvThanNhan.Rows[index].Cells["NgaySinhTN"].Value.ToString());
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                string str = txtTimKiem.Text;
                dgvNhanVien.DataSource = ListNv;
                ListNv.DataSource = NhanVienDAO.Instance.SearchKH(str);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FrmChinh frm = new FrmChinh();
                frm.Show();
                //this.Close();
                //Environment.Exit(1);
            }
        }

        private void FrmQLNS_Load(object sender, EventArgs e)
        {

        }

        private void cbbGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}