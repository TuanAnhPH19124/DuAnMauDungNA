using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.ModelContext;

namespace _2.BLL.IService
{
    public interface IQLNhanVienService
    {
        void AddNV(NhanVien nhanvien);
        void DeleteNV(NhanVien nhanVien);
        void EditNV(NhanVien nhanVien);

        IEnumerable<NhanVien> GetAll();
    }
}
