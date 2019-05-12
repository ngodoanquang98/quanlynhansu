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
    public partial class FrmChamCong : Form
    {
        public FrmChamCong()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnLuong_Click(object sender, EventArgs e)
        {
            Form frm = new FrmLuong();
            frm.Show();
            this.Hide();
        }
    }
}
