using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A2
{
    public class Sanitizer : ISanitizer
    {
        public string sanitizeInput(string input)
        {
            if (input == null)
                return null;

            var sanitized_input = input.Replace("'", "''");

            string[] blacklistedPatterns =
            [
            // Patterns to identify and remove (or replace) potentially harmful SQL syntax
            @"--", // SQL comment
            @";",  // End of SQL statement
            @"/*", // Start of SQL block comment
            @"*/", // End of SQL block comment
            @"xp_", // Potential dangerous extended stored procedure
            ];

            foreach (var pattern in blacklistedPatterns)
            {
                sanitized_input = Regex.Replace(sanitized_input, Regex.Escape(pattern), string.Empty,
                RegexOptions.IgnoreCase);
            }

            return sanitized_input;
        }
    }
}
