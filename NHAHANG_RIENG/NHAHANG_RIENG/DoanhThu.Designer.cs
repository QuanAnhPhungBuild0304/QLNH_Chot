﻿namespace NHAHANG_RIENG
{
    partial class DoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btThongke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_out = new System.Windows.Forms.DateTimePicker();
            this.dtp_in = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongke = new System.Windows.Forms.DataGridView();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN_HOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN_THANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECHECKIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECHECKOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbTrangHientai = new System.Windows.Forms.TextBox();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btInReport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTongthuThucte = new System.Windows.Forms.TextBox();
            this.txbLuotkhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTongthuHoadon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btQuaylai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThongke
            // 
            this.btThongke.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btThongke.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongke.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btThongke.Location = new System.Drawing.Point(596, 18);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(91, 38);
            this.btThongke.TabIndex = 4;
            this.btThongke.Text = "Thống kê";
            this.btThongke.UseVisualStyleBackColor = false;
            this.btThongke.Click += new System.EventHandler(this.btThongke_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ:";
            // 
            // dtp_out
            // 
            this.dtp_out.CustomFormat = "dd/MM/yyyy";
            this.dtp_out.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_out.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_out.Location = new System.Drawing.Point(461, 22);
            this.dtp_out.Name = "dtp_out";
            this.dtp_out.Size = new System.Drawing.Size(129, 26);
            this.dtp_out.TabIndex = 1;
            // 
            // dtp_in
            // 
            this.dtp_in.CustomFormat = "dd/MM/yyyy ";
            this.dtp_in.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_in.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_in.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_in.Location = new System.Drawing.Point(225, 22);
            this.dtp_in.Name = "dtp_in";
            this.dtp_in.Size = new System.Drawing.Size(125, 26);
            this.dtp_in.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btThongke);
            this.groupBox1.Controls.Add(this.dtp_out);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_in);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn khoảng thời gian";
            // 
            // dgvThongke
            // 
            this.dgvThongke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongke.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.TONGTIEN_HOADON,
            this.TONGTIEN_THANHTOAN,
            this.GIAMGIA,
            this.DATECHECKIN,
            this.DATECHECKOUT});
            this.dgvThongke.Location = new System.Drawing.Point(8, 19);
            this.dgvThongke.Name = "dgvThongke";
            this.dgvThongke.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvThongke.Size = new System.Drawing.Size(836, 167);
            this.dgvThongke.TabIndex = 0;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.DefaultCellStyle = dataGridViewCellStyle1;
            this.NAME.HeaderText = "TÊN BÀN";
            this.NAME.Name = "NAME";
            // 
            // TONGTIEN_HOADON
            // 
            this.TONGTIEN_HOADON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TONGTIEN_HOADON.DataPropertyName = "TONGTIEN_HOADON";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TONGTIEN_HOADON.DefaultCellStyle = dataGridViewCellStyle2;
            this.TONGTIEN_HOADON.HeaderText = "TỔNG TIỀN HÓA ĐƠN";
            this.TONGTIEN_HOADON.Name = "TONGTIEN_HOADON";
            // 
            // TONGTIEN_THANHTOAN
            // 
            this.TONGTIEN_THANHTOAN.DataPropertyName = "TONGTIEN_THANHTOAN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TONGTIEN_THANHTOAN.DefaultCellStyle = dataGridViewCellStyle3;
            this.TONGTIEN_THANHTOAN.HeaderText = "TỔNG TIỀN THANH TOÁN";
            this.TONGTIEN_THANHTOAN.Name = "TONGTIEN_THANHTOAN";
            this.TONGTIEN_THANHTOAN.Width = 180;
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.DataPropertyName = "GIAMGIA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIAMGIA.DefaultCellStyle = dataGridViewCellStyle4;
            this.GIAMGIA.HeaderText = "GIẢM GIÁ (%)";
            this.GIAMGIA.Name = "GIAMGIA";
            this.GIAMGIA.Width = 120;
            // 
            // DATECHECKIN
            // 
            this.DATECHECKIN.DataPropertyName = "DATECHECKIN";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATECHECKIN.DefaultCellStyle = dataGridViewCellStyle5;
            this.DATECHECKIN.HeaderText = "BẮT ĐẦU";
            this.DATECHECKIN.Name = "DATECHECKIN";
            this.DATECHECKIN.Width = 120;
            // 
            // DATECHECKOUT
            // 
            this.DATECHECKOUT.DataPropertyName = "DATECHECKOUT";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATECHECKOUT.DefaultCellStyle = dataGridViewCellStyle6;
            this.DATECHECKOUT.HeaderText = "KẾT THÚC";
            this.DATECHECKOUT.Name = "DATECHECKOUT";
            this.DATECHECKOUT.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbTrangHientai);
            this.groupBox2.Controls.Add(this.btnSau);
            this.groupBox2.Controls.Add(this.btnTruoc);
            this.groupBox2.Controls.Add(this.btnCuoi);
            this.groupBox2.Controls.Add(this.btnDau);
            this.groupBox2.Controls.Add(this.dgvThongke);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(844, 238);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng dữ liệu";
            // 
            // txbTrangHientai
            // 
            this.txbTrangHientai.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txbTrangHientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTrangHientai.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txbTrangHientai.Location = new System.Drawing.Point(377, 208);
            this.txbTrangHientai.Name = "txbTrangHientai";
            this.txbTrangHientai.Size = new System.Drawing.Size(37, 22);
            this.txbTrangHientai.TabIndex = 8;
            this.txbTrangHientai.Text = "1";
            this.txbTrangHientai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTrangHientai.TextChanged += new System.EventHandler(this.txbTrangHientai_TextChanged);
            // 
            // btnSau
            // 
            this.btnSau.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSau.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSau.Location = new System.Drawing.Point(720, 206);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(34, 26);
            this.btnSau.TabIndex = 9;
            this.btnSau.Text = ">>";
            this.btnSau.UseVisualStyleBackColor = false;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruoc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTruoc.Location = new System.Drawing.Point(680, 206);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(34, 26);
            this.btnTruoc.TabIndex = 12;
            this.btnTruoc.Text = "<<";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCuoi.Location = new System.Drawing.Point(760, 206);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(30, 26);
            this.btnCuoi.TabIndex = 11;
            this.btnCuoi.UseVisualStyleBackColor = false;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnDau
            // 
            this.btnDau.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDau.Location = new System.Drawing.Point(642, 206);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(32, 26);
            this.btnDau.TabIndex = 10;
            this.btnDau.UseVisualStyleBackColor = false;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btInReport);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txbTongthuThucte);
            this.groupBox3.Controls.Add(this.txbLuotkhach);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbTongthuHoadon);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(0, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(844, 65);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // btInReport
            // 
            this.btInReport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btInReport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btInReport.Location = new System.Drawing.Point(663, 21);
            this.btInReport.Name = "btInReport";
            this.btInReport.Size = new System.Drawing.Size(147, 38);
            this.btInReport.TabIndex = 14;
            this.btInReport.Text = "In DS hóa đơn";
            this.btInReport.UseVisualStyleBackColor = false;
            this.btInReport.Click += new System.EventHandler(this.btInReport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng thu thực tế";
            // 
            // txbTongthuThucte
            // 
            this.txbTongthuThucte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongthuThucte.Location = new System.Drawing.Point(498, 32);
            this.txbTongthuThucte.Name = "txbTongthuThucte";
            this.txbTongthuThucte.ReadOnly = true;
            this.txbTongthuThucte.Size = new System.Drawing.Size(136, 26);
            this.txbTongthuThucte.TabIndex = 10;
            this.txbTongthuThucte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbLuotkhach
            // 
            this.txbLuotkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLuotkhach.Location = new System.Drawing.Point(146, 32);
            this.txbLuotkhach.Name = "txbLuotkhach";
            this.txbLuotkhach.ReadOnly = true;
            this.txbLuotkhach.Size = new System.Drawing.Size(84, 26);
            this.txbLuotkhach.TabIndex = 8;
            this.txbLuotkhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lượt khách";
            // 
            // txbTongthuHoadon
            // 
            this.txbTongthuHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongthuHoadon.Location = new System.Drawing.Point(281, 32);
            this.txbTongthuHoadon.Name = "txbTongthuHoadon";
            this.txbTongthuHoadon.ReadOnly = true;
            this.txbTongthuHoadon.Size = new System.Drawing.Size(150, 26);
            this.txbTongthuHoadon.TabIndex = 9;
            this.txbTongthuHoadon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền hóa đơn";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btDangXuat);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Location = new System.Drawing.Point(96, 54);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(748, 89);
            this.panel6.TabIndex = 59;
            // 
            // btDangXuat
            // 
            this.btDangXuat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDangXuat.BackgroundImage = global::NHAHANG_RIENG.Properties.Resources.settings;
            this.btDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangXuat.Location = new System.Drawing.Point(681, 41);
            this.btDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(62, 46);
            this.btDangXuat.TabIndex = 50;
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Location = new System.Drawing.Point(490, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(253, 37);
            this.panel9.TabIndex = 49;
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.lbstatus);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(161, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(92, 37);
            this.panel11.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Xin chào ad:";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.ForeColor = System.Drawing.Color.Red;
            this.lbstatus.Location = new System.Drawing.Point(82, 7);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(0, 19);
            this.lbstatus.TabIndex = 42;
            this.lbstatus.Click += new System.EventHandler(this.lbstatus_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(125, 24);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(416, 55);
            this.label21.TabIndex = 0;
            this.label21.Text = "GoGo Restaurant";
            // 
            // btQuaylai
            // 
            this.btQuaylai.BackgroundImage = global::NHAHANG_RIENG.Properties.Resources.food;
            this.btQuaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuaylai.Location = new System.Drawing.Point(0, 54);
            this.btQuaylai.Name = "btQuaylai";
            this.btQuaylai.Size = new System.Drawing.Size(98, 89);
            this.btQuaylai.TabIndex = 5;
            this.btQuaylai.UseVisualStyleBackColor = true;
            this.btQuaylai.Click += new System.EventHandler(this.btQuaylai_Click);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 543);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btQuaylai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_in;
        private System.Windows.Forms.Button btThongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_out;
        private System.Windows.Forms.Button btQuaylai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongke;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbTrangHientai;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTongthuThucte;
        private System.Windows.Forms.TextBox txbLuotkhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTongthuHoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btInReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN_HOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN_THANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECHECKIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECHECKOUT;
    }
}