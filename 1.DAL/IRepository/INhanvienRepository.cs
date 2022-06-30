using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.ModelContext;
namespace _1.DAL.IService
{
    public interface INhanvienRepository
    {
        void Add(NhanVien nhanVien);
        void Edit(NhanVien nhanVien);
        void Delete(NhanVien nhanVien);

        IEnumerable<NhanVien> Getall();
    }
}
