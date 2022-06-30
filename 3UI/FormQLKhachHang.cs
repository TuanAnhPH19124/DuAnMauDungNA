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
using _1.DAL.ModelContext;

namespace _3UI
{
    public partial class FormQLKhachHang : Form
    {
        private IQLKhachHangService _service;
        private KhachHang currkhach;

        public FormQLKhachHang()
        {
            InitializeComponent();
            _service = new QLKhachHangService();
        }

        private void FormQLKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataSource();
            LoadThemeColor();
        }

        private void LoadThemeColor()
        {
            foreach (Control btns in panelButtonControl.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemColor.SecondaryColor;
                }
                
            }
            dataGridView.BackgroundColor = ThemColor.SecondaryColor;
        }

        private void LoadDataSource()
        {
            dataGridView.DataSource = _service.GetAll();
            dataGridView.Columns[0].HeaderText = "Số điện thoại";
            dataGridView.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView.Columns[2].HeaderText = "Địa chỉ";
            for (int i = 3; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Visible = false;
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            var results = _service.GetAll().Where(p => p.DienThoai == TbxTimKiem.Text || p.TenKhach.Contains(TbxTimKiem.Text)).ToList();
            if (results != null)
            {
                dataGridView.DataSource = results;
            }
            else
            {
                dataGridView.DataSource = _service.GetAll();
            }
            dataGridView.Columns[0].HeaderText = "Số điện thoại";
            dataGridView.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView.Columns[2].HeaderText = "Địa chỉ";
            for (int i = 3; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Visible = false;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {
                string sdt = dataGridView.CurrentRow.Cells[0].Value.ToString();
                PutDataIntoTxtBox(sdt);
            }
        }

        private void PutDataIntoTxtBox(string? sdt)
        {
            var kh = _service.GetAll().Where(p => p.DienThoai == sdt).First();
            TbxSdtKH.Text = kh.DienThoai;
            TbxTenKH.Text = kh.TenKhach;
            TbxDiaChi.Text = kh.DiaChi;
            TbxGioiTinh.Text = kh.Phai;
            TbxMaNV.Text = kh.MaNV;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                currkhach = NewKhachHang();
                new Dataannotation.NhanVienDataanotation().CheckDataannotation(currkhach);
                _service.AddKH(currkhach);
                MessageBox.Show("Thêm thành công");
                LoadDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private KhachHang NewKhachHang()
        {
            KhachHang khach = new KhachHang();
            khach.DiaChi = TbxDiaChi.Text;
            khach.DienThoai = TbxSdtKH.Text;
            khach.Phai = TbxGioiTinh.Text;
            khach.TenKhach = TbxTenKH.Text;
            khach.MaNV = TbxMaNV.Text;
            return khach;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                currkhach = GetNV(TbxSdtKH.Text);
                new Dataannotation.NhanVienDataanotation().CheckDataannotation(currkhach);
                _service.EditKH(currkhach);
                MessageBox.Show("Sửa thành công");
                LoadDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private KhachHang GetNV(string sdt)
        {
            var khach = _service.GetAll().Where(p => p.DienThoai == sdt).First();
            khach.TenKhach = TbxTenKH.Text;
            khach.DiaChi = TbxDiaChi.Text;
            khach.Phai = TbxGioiTinh.Text;
            return khach;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var message = MessageBox.Show("Bạn có chắc muốn xoà khách hàng này", "Cảnh báo", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    currkhach = _service.GetAll().Where(p => p.DienThoai == TbxSdtKH.Text).First();
                    _service.DeleteKH(currkhach);
                    MessageBox.Show("Xoá thành công");
                    LoadDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TbxDiaChi.Clear();
            TbxTenKH.Clear();
            TbxSdtKH.Clear();
            TbxGioiTinh.Clear();
            TbxMaNV.Clear();
            TbxTenKH.Focus();
        }
    }
}
