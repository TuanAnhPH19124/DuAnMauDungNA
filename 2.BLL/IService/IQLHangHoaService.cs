using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.ModelContext;

namespace _2.BLL.IService
{
    public interface IQLHangHoaService
    {
        void AddHH(HangHoa hanghoa);
        void EditHH(HangHoa hangHoa);
        void DeleteHH(HangHoa hangHoa);

        IEnumerable<ThongKeSPNhap> GetAllSPNhap();
        IEnumerable<HangHoa> GetAll();
    }
}
