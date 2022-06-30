using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.ModelContext;
using _2.BLL.IService;
using _1.DAL.IService;
using _1.DAL.Repository;

namespace _2.BLL.Service
{
    public class QlNhanVienService : IQLNhanVienService
    {
        private INhanvienRepository _nhanvienService;
        public QlNhanVienService()
        {
            _nhanvienService = new NhanvienRepository();
        }
        public void AddNV(NhanVien nhanvien)
        {
            _nhanvienService.Add(nhanvien);
        }

        public void DeleteNV(NhanVien nhanVien)
        {
            _nhanvienService.Delete(nhanVien);
        }

        public void EditNV(NhanVien nhanVien)
        {
            _nhanvienService.Edit(nhanVien);
        }

        public IEnumerable<NhanVien> GetAll()
        {
            var LNhanvien = _nhanvienService.Getall();
            return LNhanvien;
        }
    }
}
