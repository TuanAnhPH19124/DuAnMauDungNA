using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.ModelContext;
using _2.BLL.IService;
using _1.DAL.IRepository;
using _1.DAL.Repository;

namespace _2.BLL.Service
{
    public class QLKhachHangService : IQLKhachHangService
    {
        private IKhachHangRepository _repository;
        public QLKhachHangService()
        {
            _repository = new KhachHangRepository();
        }
        public void AddKH(KhachHang khachHang)
        {
            _repository.Add(khachHang);
        }

        public void DeleteKH(KhachHang khachHang)
        {
            _repository.Delete(khachHang);
        }

        public void EditKH(KhachHang khach)
        {
            _repository.Edit(khach);
        }

        public IEnumerable<KhachHang> GetAll()
        {
            return _repository.GettAll();
        }
    }
}
