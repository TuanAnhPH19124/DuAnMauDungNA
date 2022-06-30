using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.ModelContext;

namespace _2.BLL.IService
{
    public interface IQLKhachHangService
    {
        void EditKH(KhachHang khach);
        void AddKH(KhachHang khachHang);
        void DeleteKH(KhachHang khachHang);

        IEnumerable<KhachHang> GetAll();

    }
}
