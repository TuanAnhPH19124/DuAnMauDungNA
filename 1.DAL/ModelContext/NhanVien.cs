using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.ModelContext;

namespace _1.DAL.ModelContext
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            SanPhams = new HashSet<HangHoa>();
            KhachHangs = new HashSet<KhachHang>();
        }

        [Required(ErrorMessage ="Yêu cầu id")]
        public int Id { get; set; }

        [Key]
        [Required(ErrorMessage ="Yêu cầu mã nhân viên")]
        [StringLength(maximumLength: 10, MinimumLength = 3, ErrorMessage = "Mã nhân viên phải nằm trong khoảng 3 đến 10 kí tự")]
        public string MaNV { get; set; }

        [StringLength(50, ErrorMessage = "Email dài quá bạn cho ngắn hơn đi")]
        [EmailAddress(ErrorMessage = "Email của bạn không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Yêu cầu tên nhân viên")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "Tên nhân viên phải nằm trong khoảng 2 đến 50 kí tự")]
        public string TenNV { get; set; }
        public bool VaiTro { get; set; }
        public bool TinhTrang { get; set; }
        
        [StringLength(50)]
        public string MatKhau { get; set; }

        [InverseProperty(nameof(HangHoa.MaNVNavigation))]
        public virtual ICollection<HangHoa> SanPhams { get; set; }

        [InverseProperty(nameof(KhachHang.MaNVNavigation))]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
