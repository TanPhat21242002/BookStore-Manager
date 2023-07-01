namespace GUI
{
    partial class frmSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.pnlThongTinSanPham = new System.Windows.Forms.Panel();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CboDauSach = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLamMoiThongTin = new System.Windows.Forms.Button();
            this.btnNgungKinhDoanh = new System.Windows.Forms.Button();
            this.btnCapNhatSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtnamxb = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.pnlThongTinSanPham.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dgvSach);
            this.panel4.Location = new System.Drawing.Point(757, 14);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 537);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("UVN Hai Long", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(251, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách Sách";
            // 
            // dgvSach
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(23, 64);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSach.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSach.RowTemplate.Height = 30;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(677, 449);
            this.dgvSach.TabIndex = 71;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            this.dgvSach.Click += new System.EventHandler(this.dgvSach_Click);
            // 
            // pnlThongTinSanPham
            // 
            this.pnlThongTinSanPham.Controls.Add(this.textBox1);
            this.pnlThongTinSanPham.Controls.Add(this.txtTenSach);
            this.pnlThongTinSanPham.Controls.Add(this.label3);
            this.pnlThongTinSanPham.Controls.Add(this.label8);
            this.pnlThongTinSanPham.Controls.Add(this.CboDauSach);
            this.pnlThongTinSanPham.Controls.Add(this.panel2);
            this.pnlThongTinSanPham.Controls.Add(this.txtSoLuong);
            this.pnlThongTinSanPham.Controls.Add(this.label18);
            this.pnlThongTinSanPham.Controls.Add(this.label7);
            this.pnlThongTinSanPham.Controls.Add(this.btnLamMoiThongTin);
            this.pnlThongTinSanPham.Controls.Add(this.btnNgungKinhDoanh);
            this.pnlThongTinSanPham.Controls.Add(this.btnCapNhatSP);
            this.pnlThongTinSanPham.Controls.Add(this.btnThemSP);
            this.pnlThongTinSanPham.Controls.Add(this.txtNXB);
            this.pnlThongTinSanPham.Controls.Add(this.txtnamxb);
            this.pnlThongTinSanPham.Controls.Add(this.txtGia);
            this.pnlThongTinSanPham.Controls.Add(this.label21);
            this.pnlThongTinSanPham.Controls.Add(this.label6);
            this.pnlThongTinSanPham.Controls.Add(this.label20);
            this.pnlThongTinSanPham.Location = new System.Drawing.Point(13, 14);
            this.pnlThongTinSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlThongTinSanPham.Name = "pnlThongTinSanPham";
            this.pnlThongTinSanPham.Size = new System.Drawing.Size(725, 565);
            this.pnlThongTinSanPham.TabIndex = 72;
            this.pnlThongTinSanPham.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThongTinSanPham_Paint);
            // 
            // txtTenSach
            // 
            this.txtTenSach.BackColor = System.Drawing.Color.White;
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenSach.Location = new System.Drawing.Point(192, 94);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(252, 34);
            this.txtTenSach.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(65, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 96;
            this.label3.Text = "Tên sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(67, 343);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 31);
            this.label8.TabIndex = 94;
            this.label8.Text = "Đầu Sách";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // CboDauSach
            // 
            this.CboDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDauSach.FormattingEnabled = true;
            this.CboDauSach.Location = new System.Drawing.Point(192, 343);
            this.CboDauSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboDauSach.Name = "CboDauSach";
            this.CboDauSach.Size = new System.Drawing.Size(245, 37);
            this.CboDauSach.TabIndex = 72;
            this.CboDauSach.SelectedIndexChanged += new System.EventHandler(this.CboDauSach_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(7, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 49);
            this.panel2.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Hai Long", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(239, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Sách";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.Location = new System.Drawing.Point(189, 290);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(255, 34);
            this.txtSoLuong.TabIndex = 87;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label18.Location = new System.Drawing.Point(83, 294);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 31);
            this.label18.TabIndex = 88;
            this.label18.Text = "Số lượng";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(29, 490);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 31);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tên tác giả";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLamMoiThongTin
            // 
            this.btnLamMoiThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLamMoiThongTin.FlatAppearance.BorderSize = 0;
            this.btnLamMoiThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiThongTin.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiThongTin.Location = new System.Drawing.Point(9, 399);
            this.btnLamMoiThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoiThongTin.Name = "btnLamMoiThongTin";
            this.btnLamMoiThongTin.Size = new System.Drawing.Size(159, 46);
            this.btnLamMoiThongTin.TabIndex = 62;
            this.btnLamMoiThongTin.Text = "Làm mới";
            this.btnLamMoiThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoiThongTin.UseVisualStyleBackColor = false;
            this.btnLamMoiThongTin.Click += new System.EventHandler(this.btnLamMoiThongTin_Click);
            // 
            // btnNgungKinhDoanh
            // 
            this.btnNgungKinhDoanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNgungKinhDoanh.FlatAppearance.BorderSize = 0;
            this.btnNgungKinhDoanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgungKinhDoanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgungKinhDoanh.ForeColor = System.Drawing.Color.White;
            this.btnNgungKinhDoanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgungKinhDoanh.Location = new System.Drawing.Point(171, 399);
            this.btnNgungKinhDoanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNgungKinhDoanh.Name = "btnNgungKinhDoanh";
            this.btnNgungKinhDoanh.Size = new System.Drawing.Size(253, 46);
            this.btnNgungKinhDoanh.TabIndex = 63;
            this.btnNgungKinhDoanh.Text = "Xóa mặt hàng";
            this.btnNgungKinhDoanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNgungKinhDoanh.UseVisualStyleBackColor = false;
            this.btnNgungKinhDoanh.Click += new System.EventHandler(this.btnNgungKinhDoanh_Click);
            // 
            // btnCapNhatSP
            // 
            this.btnCapNhatSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCapNhatSP.FlatAppearance.BorderSize = 0;
            this.btnCapNhatSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatSP.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatSP.Location = new System.Drawing.Point(427, 399);
            this.btnCapNhatSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatSP.Name = "btnCapNhatSP";
            this.btnCapNhatSP.Size = new System.Drawing.Size(163, 46);
            this.btnCapNhatSP.TabIndex = 65;
            this.btnCapNhatSP.Text = "Cập nhật";
            this.btnCapNhatSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatSP.UseVisualStyleBackColor = false;
            this.btnCapNhatSP.Click += new System.EventHandler(this.btnCapNhatSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(592, 399);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(117, 46);
            this.btnThemSP.TabIndex = 66;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtNXB
            // 
            this.txtNXB.BackColor = System.Drawing.Color.White;
            this.txtNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.ForeColor = System.Drawing.Color.Black;
            this.txtNXB.Location = new System.Drawing.Point(193, 194);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(252, 34);
            this.txtNXB.TabIndex = 60;
            // 
            // txtnamxb
            // 
            this.txtnamxb.BackColor = System.Drawing.Color.White;
            this.txtnamxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamxb.ForeColor = System.Drawing.Color.Black;
            this.txtnamxb.Location = new System.Drawing.Point(193, 153);
            this.txtnamxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnamxb.Name = "txtnamxb";
            this.txtnamxb.Size = new System.Drawing.Size(252, 34);
            this.txtnamxb.TabIndex = 59;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.Black;
            this.txtGia.Location = new System.Drawing.Point(192, 249);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(253, 34);
            this.txtGia.TabIndex = 72;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label21.Location = new System.Drawing.Point(24, 155);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 31);
            this.label21.TabIndex = 86;
            this.label21.Text = "Năm xuất bản";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(120, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 31);
            this.label6.TabIndex = 73;
            this.label6.Text = "NXB";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label20.Location = new System.Drawing.Point(131, 252);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 31);
            this.label20.TabIndex = 78;
            this.label20.Text = "Giá";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 73;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(189, 490);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 34);
            this.textBox1.TabIndex = 97;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1511, 598);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlThongTinSanPham);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.pnlThongTinSanPham.ResumeLayout(false);
            this.pnlThongTinSanPham.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Panel pnlThongTinSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnLamMoiThongTin;
        private System.Windows.Forms.Button btnNgungKinhDoanh;
        private System.Windows.Forms.Button btnCapNhatSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtnamxb;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox CboDauSach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}