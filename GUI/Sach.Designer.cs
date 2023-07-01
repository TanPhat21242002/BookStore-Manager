namespace GUI
{
    partial class Sach
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnApDung = new System.Windows.Forms.Button();
            this.pnlThongTinSanPham = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CboDauSach = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.pnlThongTinSanPham.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dgvSach);
            this.panel4.Location = new System.Drawing.Point(757, 13);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 536);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("UVN Hai Long", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách Sách";
            // 
            // dgvSach
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(23, 64);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSach.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSach.RowTemplate.Height = 30;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(678, 449);
            this.dgvSach.TabIndex = 71;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellContentClick);
            this.dgvSach.Click += new System.EventHandler(this.dgvSach_Click);
            // 
            // btnApDung
            // 
            this.btnApDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnApDung.FlatAppearance.BorderSize = 0;
            this.btnApDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDung.ForeColor = System.Drawing.Color.White;
            this.btnApDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApDung.Location = new System.Drawing.Point(496, 487);
            this.btnApDung.Margin = new System.Windows.Forms.Padding(4);
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.Size = new System.Drawing.Size(163, 43);
            this.btnApDung.TabIndex = 68;
            this.btnApDung.Text = "Tìm kiếm";
            this.btnApDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApDung.UseVisualStyleBackColor = false;
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // pnlThongTinSanPham
            // 
            this.pnlThongTinSanPham.Controls.Add(this.label8);
            this.pnlThongTinSanPham.Controls.Add(this.CboDauSach);
            this.pnlThongTinSanPham.Controls.Add(this.panel2);
            this.pnlThongTinSanPham.Controls.Add(this.panel7);
            this.pnlThongTinSanPham.Controls.Add(this.btnApDung);
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
            this.pnlThongTinSanPham.Location = new System.Drawing.Point(13, 13);
            this.pnlThongTinSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.pnlThongTinSanPham.Name = "pnlThongTinSanPham";
            this.pnlThongTinSanPham.Size = new System.Drawing.Size(726, 565);
            this.pnlThongTinSanPham.TabIndex = 72;
            this.pnlThongTinSanPham.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThongTinSanPham_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(74, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 31);
            this.label8.TabIndex = 94;
            this.label8.Text = "Tên Sách";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // CboDauSach
            // 
            this.CboDauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDauSach.FormattingEnabled = true;
            this.CboDauSach.Location = new System.Drawing.Point(200, 104);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 49);
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(173, 490);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(315, 39);
            this.panel7.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, -33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 69;
            this.label5.Text = "Tên Sách";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.Location = new System.Drawing.Point(190, 291);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(255, 34);
            this.txtSoLuong.TabIndex = 87;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label18.Location = new System.Drawing.Point(82, 294);
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
            this.label7.Location = new System.Drawing.Point(42, 490);
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
            this.btnLamMoiThongTin.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnNgungKinhDoanh.Location = new System.Drawing.Point(170, 399);
            this.btnNgungKinhDoanh.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnCapNhatSP.Location = new System.Drawing.Point(426, 399);
            this.btnCapNhatSP.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtNXB.Location = new System.Drawing.Point(193, 195);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(252, 34);
            this.txtNXB.TabIndex = 60;
            // 
            // txtnamxb
            // 
            this.txtnamxb.BackColor = System.Drawing.Color.White;
            this.txtnamxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamxb.ForeColor = System.Drawing.Color.Black;
            this.txtnamxb.Location = new System.Drawing.Point(193, 152);
            this.txtnamxb.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
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
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 73;
            // 
            // Sach
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
            this.Name = "Sach";
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
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btnApDung;
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}