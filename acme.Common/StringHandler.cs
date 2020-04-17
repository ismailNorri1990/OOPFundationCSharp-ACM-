using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static String InsertSpaces(this string source)
        {
            string result = String.Empty;

            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char Letter in source)
                {
                    if (char.IsUpper(Letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += Letter; 
                }
            }
            result = result.Trim();

            return result;
        }
    }
}
