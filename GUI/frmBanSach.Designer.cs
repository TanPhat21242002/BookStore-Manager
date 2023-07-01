namespace GUI
{
    partial class frmBanSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanSach));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlThongTinSanPham = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Them = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTienKHTra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.pnlThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(4, 17);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 49);
            this.panel4.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UVN Hai Long", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(239, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông tin Bán Sách";
            // 
            // pnlThongTinSanPham
            // 
            this.pnlThongTinSanPham.Controls.Add(this.txtSDT);
            this.pnlThongTinSanPham.Controls.Add(this.dgvCTHD);
            this.pnlThongTinSanPham.Controls.Add(this.txtTienThua);
            this.pnlThongTinSanPham.Controls.Add(this.label9);
            this.pnlThongTinSanPham.Controls.Add(this.txtTienKHTra);
            this.pnlThongTinSanPham.Controls.Add(this.label6);
            this.pnlThongTinSanPham.Controls.Add(this.btnHuy);
            this.pnlThongTinSanPham.Controls.Add(this.btnThanhToan);
            this.pnlThongTinSanPham.Controls.Add(this.lblTongTien);
            this.pnlThongTinSanPham.Controls.Add(this.label5);
            this.pnlThongTinSanPham.Controls.Add(this.panel4);
            this.pnlThongTinSanPham.Location = new System.Drawing.Point(24, 32);
            this.pnlThongTinSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlThongTinSanPham.Name = "pnlThongTinSanPham";
            this.pnlThongTinSanPham.Size = new System.Drawing.Size(725, 661);
            this.pnlThongTinSanPham.TabIndex = 75;
            this.pnlThongTinSanPham.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThongTinSanPham_Paint);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(121, 102);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(465, 30);
            this.txtSDT.TabIndex = 104;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenDauSach,
            this.Gia,
            this.SoLuong,
            this.Tong,
            this.Xoa,
            this.Them});
            this.dgvCTHD.GridColor = System.Drawing.Color.Silver;
            this.dgvCTHD.Location = new System.Drawing.Point(4, 175);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCTHD.MultiSelect = false;
            this.dgvCTHD.Name = "dgvCTHD";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCTHD.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCTHD.RowTemplate.Height = 30;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(701, 290);
            this.dgvCTHD.TabIndex = 103;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "MaSP";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = false;
            this.MaSach.Width = 125;
            // 
            // TenDauSach
            // 
            this.TenDauSach.HeaderText = "Tên Sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            this.TenDauSach.Width = 144;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Đơn Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 90;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 60;
            // 
            // Tong
            // 
            this.Tong.HeaderText = "Tổng";
            this.Tong.MinimumWidth = 6;
            this.Tong.Name = "Tong";
            this.Tong.Width = 80;
            // 
            // Xoa
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Xoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Xoa.HeaderText = "-";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "-";
            this.Xoa.Width = 25;
            // 
            // Them
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.DefaultCellStyle = dataGridViewCellStyle4;
            this.Them.HeaderText = "+";
            this.Them.MinimumWidth = 6;
            this.Them.Name = "Them";
            this.Them.Text = "+";
            this.Them.Width = 25;
            // 
            // txtTienThua
            // 
            this.txtTienThua.BackColor = System.Drawing.Color.White;
            this.txtTienThua.Enabled = false;
            this.txtTienThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThua.ForeColor = System.Drawing.Color.Black;
            this.txtTienThua.Location = new System.Drawing.Point(271, 559);
            this.txtTienThua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(251, 34);
            this.txtTienThua.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(169, 566);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 101;
            this.label9.Text = "Tiền thừa:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTienKHTra
            // 
            this.txtTienKHTra.BackColor = System.Drawing.Color.White;
            this.txtTienKHTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKHTra.ForeColor = System.Drawing.Color.Black;
            this.txtTienKHTra.Location = new System.Drawing.Point(271, 521);
            this.txtTienKHTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienKHTra.Name = "txtTienKHTra";
            this.txtTienKHTra.Size = new System.Drawing.Size(251, 34);
            this.txtTienKHTra.TabIndex = 100;
            this.txtTienKHTra.TextChanged += new System.EventHandler(this.txtTienKHTra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(71, 528);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 25);
            this.label6.TabIndex = 102;
            this.label6.Text = "Tiền khách hàng trả:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Gray;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(369, 603);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(168, 42);
            this.btnHuy.TabIndex = 98;
            this.btnHuy.Text = "Hủy (F12)";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Gray;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(121, 603);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(240, 42);
            this.btnThanhToan.TabIndex = 97;
            this.btnThanhToan.Text = "Thanh toán (F9)";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTongTien.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTongTien.Location = new System.Drawing.Point(268, 476);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(32, 36);
            this.lblTongTien.TabIndex = 95;
            this.lblTongTien.Text = "0";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(127, 485);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 96;
            this.label5.Text = "Tổng hóa đơn:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("UVN Hai Long", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(244, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(282, 45);
            this.label12.TabIndex = 1;
            this.label12.Text = "Danh sách Bán Sách";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.dgvSach);
            this.panel5.Location = new System.Drawing.Point(772, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(717, 661);
            this.panel5.TabIndex = 74;
            // 
            // dgvSach
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(23, 70);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSach.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSach.RowTemplate.Height = 30;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(677, 551);
            this.dgvSach.TabIndex = 71;
            this.dgvSach.Click += new System.EventHandler(this.dgvSach_Click);
            // 
            // frmBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1505, 721);
            this.Controls.Add(this.pnlThongTinSanPham);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBanSach";
            this.Text = "BanSach";
            this.Load += new System.EventHandler(this.BanSach_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlThongTinSanPham.ResumeLayout(false);
            this.pnlThongTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlThongTinSanPham;
        private System.Windows.Forms.TextBox txtTienThua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTienKHTra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewButtonColumn Them;
        private System.Windows.Forms.TextBox txtSDT;
    }
}