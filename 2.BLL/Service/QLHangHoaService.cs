using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IRepository;
using _1.DAL.ModelContext;
using _2.BLL.IService;
using _1.DAL.Repository;
using _1.DAL.IService;

namespace _2.BLL.Service
{
    public class QLHangHoaService : IQLHangHoaService
    {
        private IHangHoaRepository _hangHoaRepository;
        private INhanvienRepository _nhanvienRepository;
        public QLHangHoaService()
        {
            _hangHoaRepository = new HangHoaRepository();
            _nhanvienRepository = new NhanvienRepository();
        }
        public void AddHH(HangHoa hanghoa)
        {
            _hangHoaRepository.Add(hanghoa);
        }

        public void DeleteHH(HangHoa hangHoa)
        {
            _hangHoaRepository.Delete(hangHoa);
        }

        public void EditHH(HangHoa hangHoa)
        {
            _hangHoaRepository.Update(hangHoa);
        }

        public IEnumerable<HangHoa> GetAll()
        {
            return _hangHoaRepository.GetAll();
        }

        public IEnumerable<ThongKeSPNhap> GetAllSPNhap()
        {
            var result = from h in GetAll()
                         join n in _nhanvienRepository.Getall()
                         on h.MaNV equals n.MaNV
                         select new ThongKeSPNhap { Manvs = n.MaNV, Tennvs = n.TenNV, Mahangs = h.MaHang, Tenhangs = h.TenHang, Soluongs = h.SoLuong };
            return result.ToList();
            
        }
    }
}
