namespace GUI
{
    partial class frmDauSach
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
            this.pnlThongTinSanPham = new System.Windows.Forms.Panel();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhatSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDauSach = new System.Windows.Forms.DataGridView();
            this.pnlThongTinSanPham.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThongTinSanPham
            // 
            this.pnlThongTinSanPham.Controls.Add(this.txtTenSach);
            this.pnlThongTinSanPham.Controls.Add(this.label4);
            this.pnlThongTinSanPham.Controls.Add(this.panel2);
            this.pnlThongTinSanPham.Controls.Add(this.btnCapNhatSP);
            this.pnlThongTinSanPham.Controls.Add(this.btnThemSP);
            this.pnlThongTinSanPham.Controls.Add(this.txtTheLoai);
            this.pnlThongTinSanPham.Controls.Add(this.txtTG);
            this.pnlThongTinSanPham.Controls.Add(this.label21);
            this.pnlThongTinSanPham.Controls.Add(this.label6);
            this.pnlThongTinSanPham.Location = new System.Drawing.Point(23, 24);
            this.pnlThongTinSanPham.Name = "pnlThongTinSanPham";
            this.pnlThongTinSanPham.Size = new System.Drawing.Size(544, 321);
            this.pnlThongTinSanPham.TabIndex = 73;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BackColor = System.Drawing.Color.White;
            this.txtTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenSach.Location = new System.Drawing.Point(187, 87);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(190, 29);
            this.txtTenSach.TabIndex = 92;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(58, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 26);
            this.label4.TabIndex = 93;
            this.label4.Text = "Tên đầu sách";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(5, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 40);
            this.panel2.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Hai Long", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(179, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Đầu sách";
            // 
            // btnCapNhatSP
            // 
            this.btnCapNhatSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCapNhatSP.FlatAppearance.BorderSize = 0;
            this.btnCapNhatSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatSP.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatSP.Location = new System.Drawing.Point(160, 210);
            this.btnCapNhatSP.Name = "btnCapNhatSP";
            this.btnCapNhatSP.Size = new System.Drawing.Size(122, 37);
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
            this.btnThemSP.Location = new System.Drawing.Point(284, 210);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(88, 37);
            this.btnThemSP.TabIndex = 66;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.BackColor = System.Drawing.Color.White;
            this.txtTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.ForeColor = System.Drawing.Color.Black;
            this.txtTheLoai.Location = new System.Drawing.Point(187, 156);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(190, 29);
            this.txtTheLoai.TabIndex = 60;
            // 
            // txtTG
            // 
            this.txtTG.BackColor = System.Drawing.Color.White;
            this.txtTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTG.ForeColor = System.Drawing.Color.Black;
            this.txtTG.Location = new System.Drawing.Point(187, 121);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(190, 29);
            this.txtTG.TabIndex = 59;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label21.Location = new System.Drawing.Point(97, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 26);
            this.label21.TabIndex = 86;
            this.label21.Text = "Tác giả";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(97, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 73;
            this.label6.Text = "Thể loại";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dgvDauSach);
            this.panel4.Location = new System.Drawing.Point(590, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 361);
            this.panel4.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("UVN Hai Long", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(151, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách đầu sách";
            // 
            // dgvDauSach
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDauSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDauSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDauSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDauSach.Location = new System.Drawing.Point(26, 47);
            this.dgvDauSach.MultiSelect = false;
            this.dgvDauSach.Name = "dgvDauSach";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDauSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDauSach.RowHeadersVisible = false;
            this.dgvDauSach.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDauSach.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDauSach.RowTemplate.Height = 30;
            this.dgvDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDauSach.Size = new System.Drawing.Size(404, 297);
            this.dgvDauSach.TabIndex = 71;
            this.dgvDauSach.Click += new System.EventHandler(this.dgvDauSach_Click);
            // 
            // frmDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 392);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlThongTinSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DauSach";
            this.Load += new System.EventHandler(this.DauSach_Load);
            this.pnlThongTinSanPham.ResumeLayout(false);
            this.pnlThongTinSanPham.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDauSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTinSanPham;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhatSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDauSach;
    }
}