using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.ModelContext;

namespace _1.DAL.IRepository
{
    public interface IKhachHangRepository
    {
        void Add(KhachHang khach);
        void Edit(KhachHang khach);
        void Delete(KhachHang khach);

        IEnumerable<KhachHang> GettAll();
    }
}
