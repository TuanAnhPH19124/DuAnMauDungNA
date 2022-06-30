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
    public partial class FormQuenMk : Form
    {
        private IQLNhanVienService _service;
        public FormQuenMk()
        {
            InitializeComponent();
            _service = new QlNhanVienService();
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _service.GetAll().Where(p => p.Email == TbxEmail.Text && p.MaNV == TbxMaNv.Text).FirstOrDefault();
                if (result != null)
                {
                    if (result.TinhTrang == false)
                        throw new Exception("Xin lỗi tài khoản này không thể truy cập vui lòng liên hệ chủ cửa hàng để biết thêm chi tiết");            
                    else
                    {
                        InfomationLogin.manv = result.MaNV;
                        InfomationLogin.ten = result.TenNV;
                        InfomationLogin.vaitro = result.VaiTro;
                        InfomationLogin.landau = result.MatKhau == "123" ? true : false;
                        new FormDoiMk().Show();
                        this.Hide();
                    }
                }
                else
                    throw new Exception("Thông tin bạn nhập không chính xác vui lòng kiểm tra lại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
