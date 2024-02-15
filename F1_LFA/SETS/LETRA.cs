using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace F1_LFA
{
	public class LETRA
	{
		public static void RevLetra(string line, int b)
		{
			if (Regex.IsMatch(line, "(( )*'[A-Z]|[a-z]|[_]'([..]|[+]))+"))
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

