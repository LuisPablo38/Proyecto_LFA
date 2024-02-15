using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace F1_LFA
{
    public class CHARSET
    {
        public static void RevCharset(string linea, int b)
        {
            if (Regex.IsMatch(linea, "(( )*CHR[(]([0-9]+)[)]([..] | [+]))+"))
            {
                Console.WriteLine("Sintaxis correcta");
            }
            else
            {
                Console.WriteLine("No cumple con la sintaxis");
            }
        }
    }
}
