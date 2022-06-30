using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BLL.Service;
using _2.BLL.IService;

namespace _3UI
{
    public partial class FormThongKe : Form
    {
       
        private IQLHangHoaService _hangHoaService;
        public FormThongKe()
        {
            InitializeComponent();
            _hangHoaService = new QLHangHoaService();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            LoadDataThongKeSanPham();
        }

        private void LoadDataThongKeSanPham()
        {

            dataGridView1.DataSource = _hangHoaService.GetAllSPNhap();
            //dataGridView1.Columns[0].HeaderText = "Mã Nhân viên";
            //dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            //dataGridView1.Columns[2].HeaderText = "Số lượng sản phẩm nhập";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbxTimkiem.Text))
                LoadDataThongKeSanPham();
            else
                dataGridView1.DataSource = _hangHoaService.GetAllSPNhap().Where(p => p.Manvs.ToLower().Trim() == TbxTimkiem.Text.ToLower().Trim() || p.Tenhangs.Contains(TbxTimkiem.Text)).ToList();
        }

        private void TbxTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);

        }
    }
}
