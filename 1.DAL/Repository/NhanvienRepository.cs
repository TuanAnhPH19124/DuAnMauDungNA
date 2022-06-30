using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.IService;
using _1.DAL.ModelContext;

namespace _1.DAL.Repository
{
    public class NhanvienRepository : INhanvienRepository
    {
        DatabaseContext context;
        public NhanvienRepository()
        {
            context = new DatabaseContext();
        }
        public void Add(NhanVien nhanVien)
        {
            context.NhanViens.Add(nhanVien);
            context.SaveChanges();
        }

        public void Delete(NhanVien nhanVien)
        {
            context.NhanViens.Remove(nhanVien);
            context.SaveChanges();
        }

        public void Edit(NhanVien nhanVien)
        {
            var local = context.Set<NhanVien>().Local.FirstOrDefault(e => e.MaNV.Equals(nhanVien.MaNV));
            if (local != null)
            {
                context.Entry(local).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            context.Entry(nhanVien).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public IEnumerable<NhanVien> Getall()
        {
            var LNhanvien = context.NhanViens.ToList();
            return LNhanvien;
        }
    }
}
