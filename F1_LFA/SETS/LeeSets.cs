using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_LFA
{
	public class LeeSets
	{
		public static void REVSETS(string id, string rule, int b)
		{
			switch (id)
			{
				case "\tLETRA":
					LETRA.RevLetra(rule, b);
					break;
				case "\tDIGITO":
					DIGITO.RevDigito(rule, b);
					break;
				case "\tCHARSET":
					CHARSET.RevCharset(rule, b);
					break;

			}
		}
	}

}
