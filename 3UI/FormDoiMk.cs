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
    public partial class FormDoiMk : Form
    {
        private IQLNhanVienService _service;
        public FormDoiMk()
        {
            InitializeComponent();
            _service = new QlNhanVienService();
            if (InfomationLogin.landau)
                Lblandau.Visible = true;
        }

        private void BtnDoiMk_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _service.GetAll().Where(p => p.MaNV == InfomationLogin.manv).FirstOrDefault();
                if (TbxMkMoi.Text != TbxXacNhanMk.Text)
                    throw new Exception("Xác nhận mật khẩu phải khớp với mật khẩu mới");
                result.MatKhau = TbxMkMoi.Text;
                _service.EditNV(result);
                MessageBox.Show("Đổi mật khẩu thành công");
                BtnThoat_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TbxXacNhanMk.Focus();
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormQL().Show();
        }
    }
}
