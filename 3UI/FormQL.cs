using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3UI
{
    public partial class FormQL : Form
    {
        private Button currBtn;
        private Random rand;
        private Form activeForm;
        private int tempIndex;
        public FormQL()
        {
            InitializeComponent();
            rand = new Random();
            BtnReset.Visible = false;
            if (InfomationLogin.vaitro == false)
            {
                BtnNhanVien.Visible = false;
                BtnCaiDat.Visible = false;
            }
            LbTenNv.Text = InfomationLogin.vaitro ? "QT: " + InfomationLogin.ten : "NV: " + InfomationLogin.ten;
            LbMaNv.Text = "Mã NV: " + InfomationLogin.manv;
        }

        private Color Selectthemcolor()
        {
            int index = rand.Next(ThemColor.colors.Count);
            while (tempIndex == index)
            {
                index = rand.Next(ThemColor.colors.Count);
            }
            tempIndex = index;
            string color = ThemColor.colors[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currBtn != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Selectthemcolor();
                    currBtn = (Button)btnSender;
                    currBtn.BackColor = color;
                    currBtn.ForeColor = Color.White;
                    currBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    PanelTitleBar.BackColor = color;
                    PanelLogo.BackColor = ThemColor.ChangeColorBrightness(color, -0.3);
                    ThemColor.PrimaryColor = color;
                    ThemColor.SecondaryColor = ThemColor.ChangeColorBrightness(color, -0.3);
                    BtnReset.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(41, 45, 62);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelGiaoDienCN.Controls.Add(childForm);
            this.panelGiaoDienCN.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTiTelBar.Text = childForm.Text;
        }

        private void BtnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLHangHoa(), sender);
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLNhanVien(), sender);
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLKhachHang(), sender);
        }

        private void BtnCaiDat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe(), sender);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTiTelBar.Text = "HOME";
            PanelTitleBar.BackColor = Color.FromArgb(63, 67, 82);
            PanelLogo.BackColor = Color.FromArgb(27, 30, 41);
            currBtn = null;
            BtnReset.Visible = false;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            new FormDangNhap().Show();
            this.Hide();
        }
    }
}
