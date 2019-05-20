using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.GUI
{
    public partial class FrmLuong : Form
    {
        public FrmLuong()
        {
            InitializeComponent();
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
    }
}
