using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.BLL.IService;
using _2.BLL.Service;

namespace _3UI.Dataannotation
{
    public class NhanVienDataanotation : HangHoaDataannotation
    {
        private IQLNhanVienService _Service = new QlNhanVienService();
        public void CheckEmailExitsting(string email)
        {
            string errorMessage = "";
            var value = _Service.GetAll().Where(p => p.Email == email).FirstOrDefault();
            if (value != null)
            {
                errorMessage = "Email này đã tồn tại vui lòng chọn email khác";
                throw new Exception(errorMessage);
            }
        }
    }
}
