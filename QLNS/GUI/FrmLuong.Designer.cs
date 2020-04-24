namespace QLNS.GUI
{
    partial class FrmLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLuong));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLuong = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnQLNS = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnLuong);
            this.panel3.Controls.Add(this.btnChamCong);
            this.panel3.Controls.Add(this.btnQLNS);
            this.panel3.Controls.Add(this.btnTrangChu);
            this.panel3.Controls.Add(this.btnExit);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnLuong, "btnLuong");
            this.btnLuong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLuong.FlatAppearance.BorderSize = 0;
            this.btnLuong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLuong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnChamCong, "btnChamCong");
            this.btnChamCong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnChamCong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnQLNS
            // 
            this.btnQLNS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnQLNS, "btnQLNS");
            this.btnQLNS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLNS.FlatAppearance.BorderSize = 0;
            this.btnQLNS.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnQLNS.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQLNS.Name = "btnQLNS";
            this.btnQLNS.UseVisualStyleBackColor = false;
            this.btnQLNS.Click += new System.EventHandler(this.btnQLNS_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnTrangChu, "btnTrangChu");
            this.btnTrangChu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTrangChu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TongNgay,
            this.TongDem,
            this.TienBaoHiem,
            this.Luong});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            resources.ApplyResources(this.MaNV, "MaNV");
            this.MaNV.Name = "MaNV";
            // 
            // TongNgay
            // 
            this.TongNgay.DataPropertyName = "TongNgay";
            resources.ApplyResources(this.TongNgay, "TongNgay");
            this.TongNgay.Name = "TongNgay";
            // 
            // TongDem
            // 
            this.TongDem.DataPropertyName = "TongDem";
            resources.ApplyResources(this.TongDem, "TongDem");
            this.TongDem.Name = "TongDem";
            // 
            // TienBaoHiem
            // 
            this.TienBaoHiem.DataPropertyName = "TienBaoHiem";
            resources.ApplyResources(this.TienBaoHiem, "TienBaoHiem");
            this.TienBaoHiem.Name = "TienBaoHiem";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            resources.ApplyResources(this.Luong, "Luong");
            this.Luong.Name = "Luong";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Controls.Add(this.label2);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Value = new System.DateTime(2019, 5, 17, 21, 12, 4, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtTimKiem
            // 
            resources.ApplyResources(this.txtTimKiem, "txtTimKiem");
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // FrmLuong
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmLuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmLuong_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnQLNS;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienBaoHiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
    }
}