using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BLL.IService;
using _2.BLL.Service;

namespace _3UI
{
    public partial class FormDangNhap : Form
    {
        private IQLNhanVienService _service;
     
        public FormDangNhap()
        {
            InitializeComponent();
            _service = new QlNhanVienService();
            TbxEmail.Text = Properties.Settings.Default.Email;
            TbxMatkhau.Text = Properties.Settings.Default.Password;
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var exsits = _service.GetAll().Where(p => p.Email == TbxEmail.Text && p.MatKhau == TbxMatkhau.Text).FirstOrDefault();
                if (exsits != null)
                {
                    InfomationLogin.ten = exsits.TenNV;
                    InfomationLogin.manv = exsits.MaNV;
                    InfomationLogin.vaitro = exsits.VaiTro;
                    if (exsits.MatKhau == "123")
                    {
                        InfomationLogin.landau = true;
                        new FormDoiMk().Show();
                    }
                    else if (exsits.TinhTrang == false)
                        throw new Exception("Xin lỗi tài khoản này không thể truy cập vui lòng liên hệ chủ cửa hàng để biết thêm chi tiết");
                    else
                        new FormQL().Show();
                    RememberMe();
                    this.Hide();
                }
                else
                    throw new Exception("Tài khoản hoặc mật khẩu không đúng vui lòng kiểm tra lại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RememberMe()
        {
            if (CbNhoMk.Checked)
            {
                Properties.Settings.Default.Email = TbxEmail.Text;
                Properties.Settings.Default.Password = TbxMatkhau.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Email = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.Save();
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LlbQuenMk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormQuenMk().Show();
            this.Hide();
        }
    }
}
