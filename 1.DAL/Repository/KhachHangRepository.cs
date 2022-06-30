using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IRepository;
using _1.DAL.ModelContext;

namespace _1.DAL.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private DatabaseContext _context;
        public KhachHangRepository()
        {
            _context = new DatabaseContext();
        }
        public void Add(KhachHang khach)
        {
            _context.KhachHangs.Add(khach);
            _context.SaveChanges();
        }

        public void Delete(KhachHang khach)
        {
            _context.KhachHangs.Remove(khach);
            _context.SaveChanges();
        }

        public void Edit(KhachHang khach)
        {
            _context.KhachHangs.Update(khach);
            _context.SaveChanges();
        }

        public IEnumerable<KhachHang> GettAll()
        {
            return _context.KhachHangs.ToList();
        }
    }
}
