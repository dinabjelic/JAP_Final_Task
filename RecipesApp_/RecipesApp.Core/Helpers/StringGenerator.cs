using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Core.Helpers
{
    public class StringGenerator
    {
        public static Random random = new Random();

        public static string GenerateDescripton()
        {
            var chars = "abcdefghijklmnoprstuvzswADBKDWJSHWASJKWISLAJMASWD";
            var stringChars = new char[8];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalstring = new string(stringChars);
            return finalstring;
        }
    }
}
