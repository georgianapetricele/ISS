using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace A2
{
    internal class UI
    {
        public void ui()
        {
            Sanitizer sanitizer = new Sanitizer();
            DataValidator dataValidator = new DataValidator();
            Console.WriteLine("Validate and sanitize input data for common data types and formats");
            while (true)
            {
                Console.WriteLine("\nEnter input: ");
                string input = Console.ReadLine();
                Console.WriteLine("Enter choice: ");
                string choice = Console.ReadLine();
                if(input!=null)
                {
                    switch (choice)
                    {
                        case "int":
                            Console.WriteLine(dataValidator.ValidateInt(input));
                            break;
                        case "float":
                            Console.WriteLine(dataValidator.ValidateFloat(input));
                            break;
                        case "bool":
                            Console.WriteLine(dataValidator.ValidateBool(input));
                            break;
                        case "email":
                            Console.WriteLine(dataValidator.ValidateEmail(input));
                            break;
                        case "phone":
                            Console.WriteLine(dataValidator.ValidatePhoneNumber(input));
                            break;
                        case "date":
                            Console.WriteLine(dataValidator.ValidateDate(input));
                            break;
                        case "exit":
                            Console.WriteLine("Exiting program.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                    Console.WriteLine("Invalid input!");


            }
        }

    }
}
