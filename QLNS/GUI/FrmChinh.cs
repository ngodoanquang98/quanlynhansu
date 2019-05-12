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
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HideBtn(Button a, Button b, Button c)
        {
            a.Hide();
            System.Threading.Thread.Sleep(300);
            b.Hide();
            System.Threading.Thread.Sleep(300);
            c.Hide();
            System.Threading.Thread.Sleep(300);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form frm = new FrmChamCong();
            frm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form frm = new FrmQLNS();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmLuong();
            frm.Show();
            this.Hide();
        }

        private void btnQLNS_Click_1(object sender, EventArgs e)
        {
            HideBtn(btnLuong, btnChamCong, btnCTy);
            Form frm = new FrmQLNS();
            frm.Show();
            this.Hide();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            HideBtn(btnChamCong, btnCTy, btnQLNS);
            Form frm = new FrmLuong();
            frm.Show();
            this.Hide();
        }

        private void btnChamCong_Click_1(object sender, EventArgs e)
        {
            HideBtn(btnCTy, btnQLNS, btnLuong);
            Form frm = new FrmChamCong();
            frm.Show();
            this.Hide();
        }

        private void btnCTy_Click(object sender, EventArgs e)
        {
            HideBtn(btnQLNS, btnLuong, btnChamCong);
            Form frm = new FrmCTy();
            frm.Show();
            this.Hide();
        }
    }
}
