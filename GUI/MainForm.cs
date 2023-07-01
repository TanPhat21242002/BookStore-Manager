using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace GUI
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        int PanelWidth;
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            PanelWidth = panelLeft.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerifyDatabaseExists();
        }
        private static void VerifyDatabaseExists()
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
            }
        }
     
        private void MainForm_Load(object sender, EventArgs e)
        {
           // btnKhachHang.PerformClick();
          
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void activeButton(object sender)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    disableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void disableButton()
        {
            foreach (Control previousBtn in panelLeft.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelControls.Controls.Add(childForm);
            this.panelControls.Tag = childForm;
            childForm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {

        }
        private void btnHoaDon_Click_1(object sender, EventArgs e)
        {
            HoaDon frm = new HoaDon();
            OpenChildForm(frm, sender);
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
          
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnSach_Click(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            KhachHang frm = new KhachHang();
            OpenChildForm(frm,sender);

        }

        private void btnSach_Click_1(object sender, EventArgs e)
        {
            Sach frm = new Sach();
            OpenChildForm(frm, sender);
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            DauSach frm = new DauSach();
            OpenChildForm(frm, sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien frm = new NhanVien();
            OpenChildForm(frm, sender);
        }

        private void btnBanSach_Click(object sender, EventArgs e)
        {
            BanSach frm = new BanSach();
            OpenChildForm(frm, sender);
        }
    }
}
