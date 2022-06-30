using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.ModelContext
{
    public class KhachHang
    {
        [Key]
        [Required(ErrorMessage = "Yêu cầu số điện thoại")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage ="Số điện thoại phải đủ 10 số")]
        public string DienThoai { get; set; }

        [Required(ErrorMessage = "Yêu cầu tên khách hàng")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tên khách phải nằm trong khoảng 2 đến 50 kí tự")]
        public string TenKhach { get; set; }

        [Required(ErrorMessage ="Yêu cầu địa chỉ")]
        [StringLength(100)]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Yêu cấu giới tính")]
        [StringLength(5)]
        public string Phai { get; set; }

        [StringLength(20)]
        public string MaNV { get; set; }
        //
        [ForeignKey(nameof(MaNV))]
        [InverseProperty(nameof(NhanVien.KhachHangs))]
        public virtual NhanVien MaNVNavigation { get; set; }
    }
}
