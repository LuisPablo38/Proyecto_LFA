using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace F1_LFA
{
    public class DIGITO
    {
        public static void RevDigito(string line, int b)
        {
            if (Regex.IsMatch(line, "(( )*'[0-9]'([..]|[+]))+"))
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
