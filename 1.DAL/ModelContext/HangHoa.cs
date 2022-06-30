using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.ModelContext
{
    public class HangHoa
    {
        [Key]
        public int MaHang { get; set; }

        [Required(ErrorMessage = "Cần nhập tên hàng")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Tên hàng phải có đủ kí tự từ 3 đến 50")]
        public string TenHang { get; set; }

        [Required(ErrorMessage = "Số lượng yêu cầu")]
        [Range(minimum: 0, maximum: 1000000, ErrorMessage = "Số lượng không được bé hơn 0")]
        public int SoLuong { get; set; }

        [Required(ErrorMessage = "Giá bán yêu cầu")]
        [Range(minimum: 0, maximum: 1000000, ErrorMessage = "Giá bán không được bé hơn 0")]
        public float DonGiaBan { get; set; }

        [Required(ErrorMessage = "Giá nhập yêu cầu")]
        [Range(minimum: 0, maximum: 1000000, ErrorMessage = "Giá nhập không được bé hơn 0")]
        public float DonGiaNhap { get; set; }

        [Required(ErrorMessage = "Yêu cầu hình ảnh")]
        [StringLength(400)]
        public string HinhAnh { get; set; }

        [Required(ErrorMessage ="Yêu cầu ghi chú")]
        [StringLength(20)]
        public string GhiChu { get; set; }

        [Required(ErrorMessage = "Yêu cầu mã nhân viên")]
        [StringLength(20)]
        public string MaNV { get; set; }
        //
        [ForeignKey(nameof(MaNV))]
        [InverseProperty(nameof(NhanVien.SanPhams))]
        public virtual NhanVien MaNVNavigation { get; set; }
    }
}
