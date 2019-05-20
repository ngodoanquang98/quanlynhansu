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
using QLNS.GUI;

namespace QLNS
{
    public partial class FrmDangNhap : Form
    {
        BindingSource ListND = new BindingSource();
        public FrmDangNhap()
        {
            InitializeComponent();
            ListND.DataSource = NguoiDung.Instance.LayDL();
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

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if(txtMK.Text == "" || txtTenDN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại tài khoản!");
                return;
            }
            foreach(NguoiDung nd in ListND)
            {
                long a;
                if (!long.TryParse(txtTenDN.Text, out a)) {
                    MessageBox.Show("Vui lòng nhập lại tài khoản!");
                    return;
                 }
                if(a == nd.MaND && txtMK.Text == nd.MatKhau)
                {
                    NhatKyDAO dao = new NhatKyDAO();
                    dao.Insert(a);
                    FrmChinh frm = new FrmChinh();
                    frm.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Vui lòng nhập lại tài khoản!");
        }
    }
}
