using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.BLL;
using QLNS.DAL;

namespace QLNS.GUI
{
    public partial class FrmCTy : Form
    {
        public FrmCTy()
        {
            InitializeComponent();
            try
            {
                CongTy ct = CongTyDAO.LayDL();
                txtCT.Text = ct.ChuTich;
                txtDC.Text = ct.DiaChi;
                txtHotLine.Text = ct.HotLine;
                txtTen.Text = ct.TenCty;
            }
            catch { }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(1);
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            Form frm = new FrmChinh();
            frm.Show();
            this.Hide();
        }

        private void btnQLNS_Click(object sender, EventArgs e)
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

        private void btnLuong_Click(object sender, EventArgs e)
        {
            Form frm = new FrmLuong();
            frm.Show();
            this.Hide();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == null || txtHotLine.Text == null || txtDC.Text == null || txtCT == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            CongTyDAO DAO = new CongTyDAO();
            CongTy ct = new CongTy(txtTen.Text, txtDC.Text, txtCT.Text, txtHotLine.Text);
            if (DAO.Insert(ct)) MessageBox.Show("Cập nhật thông tin thành công!");
            else MessageBox.Show("Vui lòng nhật lại!");
        }
    }
}
