using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A2
{
    public class DataValidator : IDataValidator
    {

        public bool ValidateInt(string input)
        {
            string intRegex= @"^-?\d+$";
            return Regex.IsMatch(input, intRegex);
        }

        public bool ValidateFloat(string input)
        {
            string floatRegex = @"^-?\d+\.\d+$";
            return Regex.IsMatch(input, floatRegex);
        }


        public bool ValidateBool(string input)
        {
            string boolRegex = @"^(true|false)$";
            return Regex.IsMatch(input, boolRegex);
        }


        public bool ValidateEmail(string email)
        {

            /*
            g
                [a-zA-Z0-9._%+-]+  // one or more characters letters (both uppercase and lowercase), digits, dots, underscores, percentage signs, plus signs, or hyphens.
                @                  // Matches the "@" symbol
                \.                 // Matches a literal dot (.)
                [a-zA-Z]{2,}       // Matches two or more characters that are letters (both uppercase and lowercase).
                (?:                // Start of a non-capturing group
                  \.               // Matches a literal dot (.)
                  [a-zA-Z]{2,}     // Matches two or more characters that are letters (both uppercase and lowercase). This represents the top-level domain (TLD).
                )?                 // End of the non-capturing group. The group is optional, allowing for an optional TLD.
                $                  // End of the string
             */

            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(?:\.[a-zA-Z]{2,})?$";
            return Regex.IsMatch(email, emailRegex);
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            /*
            \+?                // Optional "+" symbol
            \d{ 1,4}?           // Between 1 to 4 digits (country code), non-greedy
            [-.\s] ?            // Optional separator: "-", ".", or whitespace
            \(?\d{ 1,3}?\)?     // Optional opening "(" followed by 1 to 3 digits and optional closing ")"
            [-.\s] ?            // Optional separator: "-", ".", or whitespace
            \d{ 1,4}            // Exactly 1 to 4 digits (area code)
            [-.\s] ?            // Optional separator: "-", ".", or whitespace
            \d{ 1,4}            // Exactly 1 to 4 digits
            [-.\s] ?            // Optional separator: "-", ".", or whitespace
            \d{ 1,9}            // Exactly 1 to 9 digits (line number) */

            string phoneRegex = @"^\+?\d{1,4}?[-.\s]?\(?\d{1,3}?\)?[-.\s]?\d{1,4}[-.\s]?\d{1,4}[-.\s]?\d{1,9}$";
            return Regex.IsMatch(phoneNumber, phoneRegex);
        }

        public bool ValidateDate(string dateString)
        {
            /*
            (?:                    // Non-capturing group to match date formats
              (?:\d{4}-\d{2}-\d{2})   // Date format: YYYY-MM-DD
              |                     // OR
              (?:\d{2}/\d{2}/\d{4})   // Date format: MM/DD/YYYY
              |                     // OR
              (?:\d{2}\.\d{2}\.\d{4}) // Date format: MM.DD.YYYY
            )                      // End of non-capturing group
             */
            string dateRegex = @"^(?:(?:\d{4}-\d{2}-\d{2})|(?:\d{2}/\d{2}/\d{4})|(?:\d{2}\.\d{2}\.\d{4}))$";
            return Regex.IsMatch(dateString, dateRegex);
        }
    }
}
