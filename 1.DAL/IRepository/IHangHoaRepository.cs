using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.ModelContext;

namespace _1.DAL.IRepository
{
    public interface IHangHoaRepository
    {
        void Add(HangHoa hangHoa);
        void Update(HangHoa hangHoa);
        void Delete(HangHoa hangHoa);

        IEnumerable<HangHoa> GetAll();
    }
}
