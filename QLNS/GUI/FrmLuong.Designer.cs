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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 38);
            this.panel3.TabIndex = 14;
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLuong.FlatAppearance.BorderSize = 0;
            this.btnLuong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLuong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuong.Location = new System.Drawing.Point(496, 1);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(153, 34);
            this.btnLuong.TabIndex = 14;
            this.btnLuong.Text = "Quản lý lương";
            this.btnLuong.UseVisualStyleBackColor = false;
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChamCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChamCong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnChamCong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChamCong.Location = new System.Drawing.Point(332, 3);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(158, 34);
            this.btnChamCong.TabIndex = 13;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnQLNS
            // 
            this.btnQLNS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQLNS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQLNS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQLNS.FlatAppearance.BorderSize = 0;
            this.btnQLNS.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnQLNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnQLNS.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQLNS.Location = new System.Drawing.Point(154, 3);
            this.btnQLNS.Name = "btnQLNS";
            this.btnQLNS.Size = new System.Drawing.Size(176, 34);
            this.btnQLNS.TabIndex = 12;
            this.btnQLNS.Text = "Quản lý nhân sự";
            this.btnQLNS.UseVisualStyleBackColor = false;
            this.btnQLNS.Click += new System.EventHandler(this.btnQLNS_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTrangChu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnTrangChu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTrangChu.Location = new System.Drawing.Point(3, 3);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(145, 34);
            this.btnTrangChu.TabIndex = 11;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(765, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.MaximumSize = new System.Drawing.Size(35, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(2);
            this.btnExit.Size = new System.Drawing.Size(35, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 40F);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 61);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản lý lương";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 341);
            this.panel2.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 306);
            this.panel5.TabIndex = 1;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 35);
            this.panel4.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2019, 5, 17, 21, 12, 4, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(275, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(89, 7);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 23);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm :";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // TongNgay
            // 
            this.TongNgay.DataPropertyName = "TongNgay";
            this.TongNgay.HeaderText = "Tổng số ngày";
            this.TongNgay.Name = "TongNgay";
            // 
            // TongDem
            // 
            this.TongDem.DataPropertyName = "TongDem";
            this.TongDem.HeaderText = "Tổng số đêm";
            this.TongDem.Name = "TongDem";
            // 
            // TienBaoHiem
            // 
            this.TienBaoHiem.DataPropertyName = "TienBaoHiem";
            this.TienBaoHiem.HeaderText = "Tiền bảo hiểm";
            this.TienBaoHiem.Name = "TienBaoHiem";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // FrmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLuong";
            this.Text = "FrmLuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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