using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IRepository;
using _1.DAL.ModelContext;

namespace _1.DAL.Repository
{
    public class HangHoaRepository : IHangHoaRepository
    {
        private DatabaseContext _conText;
        public HangHoaRepository()
        {
            _conText = new DatabaseContext();
        }
        public void Add(HangHoa hangHoa)
        {
            _conText.HangHoas.Add(hangHoa);
            _conText.SaveChanges();
        }

        public void Delete(HangHoa hangHoa)
        {
            _conText.HangHoas.Remove(hangHoa);
            _conText.SaveChanges();
        }

        public IEnumerable<HangHoa> GetAll()
        {
            return _conText.HangHoas.ToList();
        }

        public void Update(HangHoa hangHoa)
        {
            var local = _conText.Set<HangHoa>().Local.FirstOrDefault(e => e.MaHang.Equals(hangHoa.MaHang));
            if (local != null)
            {
                _conText.Entry(local).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            _conText.Entry(hangHoa).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _conText.SaveChanges();
        }
    }
}
