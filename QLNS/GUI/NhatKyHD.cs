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
using System.Data.SqlClient;

namespace QLNS.GUI
{
    public partial class NhatKyHD : Form
    {
        BindingSource ListNK = new BindingSource();
        public NhatKyHD()
        {
            InitializeComponent();
            LayDL();
        }

        private void LayDL()
        {
            ListNK.DataSource = NhatKyDAO.Instance.LayDL();
            dataGridView1.DataSource = ListNK;
        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ListNK.DataSource = NhatKyDAO.Instance.TimKiemNgay(dateTimePicker1.Value);
            dataGridView1.DataSource = ListNK;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                LayDL();
            }
            else
            {
                long a;
                long.TryParse(textBox1.Text, out a);
                ListNK.DataSource = NhatKyDAO.Instance.TimKiemMa(a);
                dataGridView1.DataSource = ListNK;
            }
        }

        private void NhatKyHD_Load(object sender, EventArgs e)
        {

        }
    }
}