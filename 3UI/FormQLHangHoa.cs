using _2.BLL.IService;
using _2.BLL.Service;
using _1.DAL.ModelContext;

namespace _3UI
{
    public partial class FormQLHangHoa : Form
    {
        private IQLHangHoaService _service;
        private HangHoa hangHoa;
        private string ImgPath;

       

        public FormQLHangHoa()
        {
            InitializeComponent();
            _service = new QLHangHoaService();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormQLHangHoa_Load(object sender, EventArgs e)
        {
            LoadDataSource();
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in PanelControlButton.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemColor.SecondaryColor;
                }
                
            }
            PbxAnhSP.BackColor = ThemColor.PrimaryColor;
            dataGridView1.BackgroundColor = ThemColor.SecondaryColor;
        }

        private void LoadDataSource()
        {
            dataGridView1.DataSource = _service.GetAll();
            dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            for (int i = 3; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                ImgPath = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                TbxMaSP.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                TbxTenSP.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                TbxSoLuongSP.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                TbxGiaBanSP.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                TbxGiaNhapSP.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                PbxAnhSP.Image = Image.FromFile(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                TbxGhiChuSP.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                TbxMaNv.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private HangHoa MatchTypeValue()
        {
            HangHoa hang = new HangHoa();
            hang.MaHang = Convert.ToInt32(TbxMaSP.Text);
            hang.TenHang = TbxTenSP.Text;
            hang.SoLuong = int.Parse(TbxSoLuongSP.Text);
            hang.GhiChu = TbxGhiChuSP.Text;
            hang.DonGiaNhap = float.Parse(TbxGiaNhapSP.Text);
            hang.DonGiaBan = float.Parse(TbxGiaBanSP.Text);
            if (!string.IsNullOrEmpty(ImgPath))
                hang.HinhAnh = ImgPath;
            hang.MaNV = TbxMaNv.Text;
            return hang;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var HangMoi = BuildHangHoa(hangHoa);
                new Dataannotation.HangHoaDataannotation().CheckDataannotation(HangMoi);
                _service.AddHH(HangMoi);
                MessageBox.Show("Thêm thành công");
                LoadDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private HangHoa BuildHangHoa(HangHoa hangHoa)
        {
            hangHoa = new HangHoa();
            //hangHoa.MaHang = int.Parse(TbxMaSP.Text);
            hangHoa.TenHang = TbxTenSP.Text;
            hangHoa.SoLuong = int.Parse(TbxSoLuongSP.Text);
            hangHoa.GhiChu = TbxGhiChuSP.Text;
            hangHoa.DonGiaNhap = float.Parse(TbxGiaNhapSP.Text);
            hangHoa.DonGiaBan = float.Parse(TbxGiaBanSP.Text);
            hangHoa.HinhAnh = ImgPath;
            hangHoa.MaNV = TbxMaNv.Text;
            return hangHoa;
        } 

        private void PbxAnhSP_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = "(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    PbxAnhSP.Image = Image.FromFile(open.FileName);
                    ImgPath = open.FileName;
                }

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var value = MatchTypeValue();
                new Dataannotation.HangHoaDataannotation().CheckDataannotation(value);
                _service.EditHH(value);
                MessageBox.Show("Sửa thành công");
                LoadDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbxMaSP.Text))
            {
                try
                {
                    hangHoa = new HangHoa();
                    hangHoa.MaHang = int.Parse(TbxMaSP.Text);
                    var value = _service.GetAll().Where(p => p.MaHang == hangHoa.MaHang).First();
                    _service.DeleteHH(value);
                    MessageBox.Show("Xoá thành công");
                    LoadDataSource();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            int value = 0;
            bool Idnv = int.TryParse(TbxTimKiem.Text, out value); 
           
            if (string.IsNullOrEmpty(TbxTimKiem.Text))
            {
                dataGridView1.DataSource = _service.GetAll();
            }
            else
            {
                dataGridView1.DataSource = _service.GetAll().Where(p => p.MaHang == value || p.TenHang.ToLower().Trim().Contains(TbxTimKiem.Text)).ToList();
            }
        }

        private void TbxTimKiem_TextChanged(object sender, EventArgs e)
        {
            BtnTimKiem_Click(sender, new EventArgs());
        }

        private void FormQLHangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}