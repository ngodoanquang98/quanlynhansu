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

namespace QLNS.GUI
{
    public partial class FrmLuong : Form
    {
        BindingSource ListLuong = new BindingSource();
        public FrmLuong()
        {
            InitializeComponent();
            dateTimePicker1.ShowUpDown = true;
            if (DateTime.Now.Day == 1) LuongDAO.Instance.TaoDL();
            DataList(DateTime.Now);
        }

        public void DataList(DateTime d)
        {
            ListLuong.DataSource = LuongDAO.Instance.TimKiemNgay(d);
            dataGridView1.DataSource = ListLuong;
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(1);
            }
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem == null)
                DataList(DateTime.Now);
            else
            {
                long a;
                long.TryParse(txtTimKiem.Text, out a);
                ListLuong.DataSource = LuongDAO.Instance.TimKiemMa(a);
                dataGridView1.DataSource = ListLuong;
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ListLuong.DataSource = LuongDAO.Instance.TimKiemNgay(dateTimePicker1.Value);
            dataGridView1.DataSource = ListLuong;
        }
    }
}