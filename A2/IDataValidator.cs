using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public interface IDataValidator
    {
        bool ValidateInt(string input);
        bool ValidateFloat(string input);
        bool ValidateBool(string input);
        bool ValidateEmail(string email);
        bool ValidatePhoneNumber(string phoneNumber);
        bool ValidateDate(string dateString);
    }
}
