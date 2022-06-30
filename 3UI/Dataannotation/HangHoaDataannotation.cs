using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3UI.Dataannotation
{
    public class HangHoaDataannotation
    {
        public void CheckDataannotation(object entity)
        {
            string errorMessage = "";
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(entity);
            bool isValidate = Validator.TryValidateObject(entity, context, results, true);
            if (isValidate == false)
            {
                foreach (var item in results)
                {
                    errorMessage += "- " + item.ErrorMessage + "\n";
                }
                throw new Exception(errorMessage);
            }
        }
    }
}
