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
namespace QLNS.GUI
{
    public partial class FrmQLNS : Form
    {
        BindingSource ListNv = new BindingSource();
        public FrmQLNS()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

            ListNv.DataSource = NhanVienBLL.Instance.LayDL();
            dgvNhanVien.DataSource = ListNv;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtTimKiem.Text;
            dgvNhanVien.DataSource = ListNv;
            ListNv.DataSource = NhanVienBLL.Instance.SearchKH(str);
        }

        private void BtnThemMoi_Click(object sender, EventArgs e)
        {
            txtCMT.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtNoiO.Text = "";
            txtQue.Text = "";
            lblMaNV.Text = "";
            lblSoHD.Text = "";
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (txtCMT.Text == null || txtHoTen.Text == null)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu");
                return;
            }
            long a,b,c;
            long.TryParse(cbbPhongBan.Text, out a);
            long.TryParse(cbbLoaiHD.Text, out b);
            long.TryParse(cbbTrangThai.Text, out c);
            NhanVien nv = new NhanVien(0, txtHoTen.Text, a,txtQue.Text, dtpNgaySinh.Value,
                 txtEmail.Text, dtpNBD.ToString(), txtSDT.Text, b, dtpNBD.Value);

            NhanVienBLL bll = new NhanVienBLL();
            bool r = bll.Insert(nv);
            if (!r) MessageBox.Show("Sai cmnr");
        }

        private void DgvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvNhanVien.Rows.IndexOf(dgvNhanVien.SelectedRows[0]);
            txtCMT.Text = dgvNhanVien.Rows[index].Cells["CMT"].Value.ToString();
            dtpNBD.Value = DateTime.Parse(dgvNhanVien.Rows[index].Cells["NgayBatDau"].Value.ToString());
            dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[index].Cells["NgaySinh"].Value.ToString());
            txtEmail.Text = dgvNhanVien.Rows[index].Cells["email"].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[index].Cells["HoTen"].Value.ToString();
            txtQue.Text = dgvNhanVien.Rows[index].Cells["QueQuan"].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[index].Cells["SDT"].Value.ToString();
        }
    }
}
