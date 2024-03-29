using System;

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    internal class Tests
    {

        public static void TestValidation()
        {
            DataValidator data = new DataValidator();

            Console.WriteLine("Email validation:");
            Console.WriteLine(data.ValidateEmail("user%example.com@example.org"));
            Console.WriteLine(data.ValidateEmail("ma.h.saraf.onemore@hostname.com.edu"));
            Console.WriteLine(data.ValidateEmail("user123@example.co.uk"));

            Console.WriteLine("\nPhone number validation:");
            Console.WriteLine(data.ValidatePhoneNumber("123-456-7890"));
            Console.WriteLine(data.ValidatePhoneNumber("+40 755 515 676"));
            Console.WriteLine(data.ValidatePhoneNumber("+1 123-456-7890"));
            Console.WriteLine(data.ValidatePhoneNumber("1 (800) 555-1234"));

            Console.WriteLine("\nDate validation:");
            Console.WriteLine(data.ValidateDate("2021-12-31"));
            Console.WriteLine(data.ValidateDate("2021-12-32"));
            Console.WriteLine(data.ValidateDate("01/15/2022"));
            Console.WriteLine(data.ValidateDate("15.01.2024"));


            Sanitizer sanitizer = new Sanitizer();
            Console.WriteLine("\nSanitizing input:");
            Console.WriteLine(sanitizer.sanitizeInput("abc'; DROP TABLE users; --"));
            Console.WriteLine();
        }
        
    }
}
