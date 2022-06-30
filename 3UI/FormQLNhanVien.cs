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
    public partial class FormQLNhanVien : Form
    {
        // fileds
        private IQLNhanVienService _service;
        private NhanVien currentNV;


        // methods
        public FormQLNhanVien()
        {
            InitializeComponent();
            _service = new QlNhanVienService();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataSource();
            LoadThemColor();
        }

        private void LoadThemColor()
        {
            foreach (Control button in panelButtonControl.Controls)
            {
                if (button.GetType() == typeof(Button))
                {
                    Button btn = (Button)button;
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
            dataGridView.Columns[1].HeaderText = "Mã nhân viên";
            dataGridView.Columns[2].HeaderText = "Email";
            dataGridView.Columns[3].HeaderText = "Tên nhân viên";
            for (int i = 4; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Visible = false;
            }
            dataGridView.Columns[0].Visible = false;
        }

        private void BtnClearTbx_Click(object sender, EventArgs e)
        {
            TbxEmailNV.Clear();
            TbxTenNV.Clear();
            TbxMaNV.Clear();
            TbxIdNV.Clear();
            TbxMaNV.Focus();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                currentNV = MatchTextBoxValue();
                new Dataannotation.NhanVienDataanotation().CheckDataannotation(currentNV);
                new Dataannotation.NhanVienDataanotation().CheckEmailExitsting(currentNV.Email);
                _service.AddNV(currentNV);
                MessageBox.Show("thêm thành công");
                LoadDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private NhanVien MatchTextBoxValue()
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Id = int.Parse( TbxIdNV.Text);
            nhanVien.MaNV = TbxMaNV.Text;
            nhanVien.TenNV = TbxTenNV.Text;
            nhanVien.Email = TbxEmailNV.Text;
            nhanVien.VaiTro = RbtnQuanLi.Checked ? true : false;
            nhanVien.TinhTrang = RbtnHoatDong.Checked ? true : false;
            nhanVien.MatKhau = "123";
            return nhanVien;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow.Index != -1)
            {
                string manv = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                PutDataIntoTxtbox(manv);
            }
        }

        private void PutDataIntoTxtbox(string manv)
        {
            var nv = _service.GetAll().Where(p => p.MaNV == manv.Trim()).FirstOrDefault();
            TbxIdNV.Text = nv.Id.ToString();
            TbxEmailNV.Text = nv.Email;
            TbxMaNV.Text = nv.MaNV;
            TbxTenNV.Text = nv.TenNV;
            if (nv.VaiTro)
                RbtnQuanLi.Checked = true;
            else
                RbtnNhanVien.Checked = true;
            if (nv.TinhTrang)
                RbtnHoatDong.Checked = true;
            else
                RbtnKoHoatDong.Checked = true;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                currentNV = getNV();
                new Dataannotation.NhanVienDataanotation().CheckDataannotation(currentNV);
                _service.EditNV(currentNV);
                MessageBox.Show("Sửa thành công");
                LoadDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private NhanVien getNV()
        {
            var nv = _service.GetAll().Where(p => p.MaNV == TbxMaNV.Text).First();
            nv.MaNV = TbxMaNV.Text;
            nv.TenNV = TbxTenNV.Text;
            nv.Email = TbxEmailNV.Text;
            nv.VaiTro = RbtnQuanLi.Checked ? true : false;
            nv.TinhTrang = RbtnHoatDong.Checked ? true : false;
            return nv;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var message = MessageBox.Show("Bạn có chắc muốn xoá?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    currentNV = _service.GetAll().Where(p => p.MaNV == TbxMaNV.Text).FirstOrDefault();
                    _service.DeleteNV(currentNV);
                    MessageBox.Show("Xoá thành công");
                    LoadDataSource();
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var results = _service.GetAll().Where(p => p.MaNV == TbxTimkiem.Text || p.TenNV.Contains(TbxTimkiem.Text)).ToList();
            if (results != null)
                dataGridView.DataSource = results;
            else
                dataGridView.DataSource = _service.GetAll();
        }
    }
}
