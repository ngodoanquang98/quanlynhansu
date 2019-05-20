using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.DAL;
using QLNS.BLL;

namespace QLNS.GUI
{
    public partial class FrmChamCong : Form
    {
        BindingSource ListCC = new BindingSource();
        SqlConnection sqlConnection = new SqlConnection();
        public FrmChamCong()
        {
            InitializeComponent();
            string connString = @"Data Source=DESKTOP-34CKI58\HOAI;Initial Catalog=QLNS;Integrated Security=True";
            sqlConnection.ConnectionString = connString;
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaCa,TenCa FROM Ca", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbCa.DisplayMember = "TenCa";
            cbbCa.ValueMember = "MaCa";
            cbbCa.DataSource = dt;
            if (DateTime.Now.Hour < 18 && DateTime.Now.Hour > 6) cbbCa.SelectedValue = 1;
            else cbbCa.SelectedValue = 0;
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text == null)
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
                return;
            }
            int b;
            long c;
            int.TryParse(cbbCa.SelectedValue.ToString(), out b);
            long.TryParse(txtMaNV.Text, out c);
            ChamCong cc = new ChamCong(0, dtpNgay.Value, b, c);
            ChamCongDAO dao = new ChamCongDAO();
            if (!dao.Insert(cc)) MessageBox.Show("Sai cmnr!");
            else MessageBox.Show("Thêm thành công!");
            txtMaNV.Text = "";
        }

        private void TabControl1_Click(object sender, EventArgs e)
        {
            ListCC.DataSource = ChamCongDAO.Instance.LayDL(DateTime.Now);
            dataGridView1.DataSource = ListCC;
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ListCC.DataSource = ChamCongDAO.Instance.LayDL(dateTimePicker2.Value);
            dataGridView1.DataSource = ListCC;
            dataGridView1.Refresh();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            long a;
            long.TryParse(textBox1.Text, out a);
            ListCC.DataSource = ChamCongDAO.Instance.LayDL(DateTime.Now);
            dataGridView1.DataSource = ListCC;
            dataGridView1.Refresh();
        }
    }
}
