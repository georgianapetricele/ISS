
using System;
using System.Text.RegularExpressions;


/*
    Basic Data Validation Module: Create a module to validate and sanitize input data for
common data types and formats (email, phone numbers, dates) and sanitize inputs to
remove harmful characters used in SQL injection. Phone numbers may include “+- ()”
characters.
 */

namespace A2
{

    class Program
    {
        static void Main(string[] args)
        {
            Tests.TestValidation();
            UI ui = new UI();
            ui.ui();

        }

    }
}