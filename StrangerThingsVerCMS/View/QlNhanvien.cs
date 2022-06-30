using _2.BLL.IService;
using _2.BLL.Service;
using _1.DAL.ModelContext;
using System.Windows.Forms;

namespace _3.UI.View
{
    public partial class QlNhanvien : Form
    {
        private IQLNhanVienService _IQLNV;
        private NhanVien currNV;

        public QlNhanvien()
        {
            InitializeComponent();
            _IQLNV = new QlNhanVienService();
        }

        private void QlNhanvien_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            foreach (var item in _IQLNV.GetAll())
            {
                dataGridView1.Rows.Add(item.Email, item.Tennv, Tinhtrang(item.Tinhtrang));
            }
            
        }

        private string Tinhtrang(int i)
        {
            var tinhtrang = i == 1 ? "Hoạt động" : "Không hoạt động";
            return tinhtrang;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Guid guid = Guid.NewGuid();
                NhanVien nv = new NhanVien();
                nv.Manv = guid;
                nv.Email = TbxEmail.Text;
                nv.Tennv = TbxTennv.Text;
                nv.Diachi = TbxDiachi.Text;
                nv.Vaitro = RdvaitroNv.Checked ? 0 : 1;
                nv.Tinhtrang = RdtinhtrangHd.Checked ? 1 : 0;
                nv.Matkhau = "123";
                _IQLNV.AddNV(nv);
                MessageBox.Show("Thêm thành công!");
                LoadDataSource();
            }
            catch (Exception)
            { 
                throw;
            }
            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        { 
            try
            {
                if (currNV == null)
                    throw new Exception("Hay chọn giá đúng!");
                _IQLNV.DeleteNV(GetCorrectlyNV(currNV));
                MessageBox.Show("Xoá thành công!");
                LoadDataSource();
                currNV = new NhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currNV = new NhanVien();
            


        }

        private void PutInforIntoTheTextBox(NhanVien currNV)
        {
            var nv = GetCorrectlyNV(currNV);
            TbxEmail.Text = nv.Email;
            TbxTennv.Text = nv.Tennv;
            TbxDiachi.Text = nv.Diachi;
            if (nv.Vaitro == 1)
                RdvaitroQt.Checked = true;
            else
                RdvaitroNv.Checked = true;
            if (nv.Tinhtrang == 1)
                RdtinhtrangHd.Checked = true;
            else
                RdtinhtrangKhd.Checked = true;

        }

        private void BtnEdit(object sender, EventArgs e)
        {
            try
            {
                if (currNV == null)
                    throw new Exception("Hay chọn giá đúng!");
                _IQLNV.EditNV(InforMationUpdate(currNV));
                MessageBox.Show("Cập nhật thành công!");
                LoadDataSource();
                currNV = new NhanVien();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
              
            }
        }

        private NhanVien InforMationUpdate(NhanVien email)
        {
            var nv = GetCorrectlyNV(email);
            nv.Email = TbxEmail.Text;
            nv.Tennv = TbxTennv.Text;
            nv.Diachi = TbxDiachi.Text;
            nv.Vaitro = RdvaitroQt.Checked ? 1 : 0;
            nv.Tinhtrang = RdtinhtrangHd.Checked ? 1 : 0;
            return nv;
        }

        private NhanVien GetCorrectlyNV(NhanVien s)
        {
            var Nv = _IQLNV.GetAll().Where(p => p.Email == s.Email).FirstOrDefault();
            return Nv;
        }

        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            var LResult = _IQLNV.GetAll().Where(p => p.Email == TbxTimkiem.Text || p.Tennv == TbxTimkiem.Text).ToList();
            foreach (var item in LResult)
            {
                
            }
            if (TbxTimkiem.Text == "")
                LoadDataSource();
        }

        private void TbxTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnTimkiem_Click(sender, new EventArgs());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    var SelectedNV = dataGridView1.SelectedRows[e.RowIndex].DataBoundItem;
            //    TbxTennv.Text = SelectedNV.Tennv;
            //    TbxDiachi.Text = SelectedNV.Diachi;
            //    RdvaitroQt.Checked = SelectedNV.Vaitro == 1 ? true : RdvaitroNv.Checked = true;
            //    RdtinhtrangHd.Checked = SelectedNV.Tinhtrang == 1 ? true : RdtinhtrangKhd.Checked = true;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error");
            //}
        }
    }
}
