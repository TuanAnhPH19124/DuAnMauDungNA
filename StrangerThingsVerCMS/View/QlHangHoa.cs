using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.ModelContext;
using _2.BLL.IService;
using _2.BLL.Service;

namespace _3.UI.View
{
    public partial class QlHangHoa : Form
    {
        private IQLHangHoaService _service;
        private HangHoa hangHoa;
        public QlHangHoa()
        {
            InitializeComponent();
            _service = new QLHangHoaService();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QlHangHoa_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void LoadDataSource()
        {
            dataGridView1.DataSource = _service.GetAll();
            for (int i = 3; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            hangHoa = matchTheValue();
            _service.AddHH(hangHoa);
        }

        private HangHoa matchTheValue()
        {
           
            var hanghoa = new HangHoa();
            hangHoa.Mahang = Guid.NewGuid();
            hangHoa.Tenhang = TbxTenSP.Text;
            hangHoa.Soluong = int.Parse(TbxSoLuongSP.Text);
            hangHoa.Dongianhap = decimal.Parse(TbxGiaNhapSP.Text);
            hangHoa.Dongiaban = decimal.Parse(TbxGiaBanSP.Text);
            hangHoa.Ghichu = TbxGhiChuSP.Text;
            hangHoa.Hinhanh = ImageToByteArray(PbxAnhSP.Image);
            return hanghoa;
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void PbxAnhSP_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                if (dialog.ShowDialog() == DialogResult.OK)
                    PbxAnhSP.Image = new Bitmap(dialog.FileName);
            }
        }
    }
}
