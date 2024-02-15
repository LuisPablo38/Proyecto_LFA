using System;
using System.Collections.Generic;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_LFA
{
    public class Identificador
    {
        public static void getIdentificador(string line, int b)
        {
            char limitante = '=';
            char blankSpace = ' ';

            string identificador = "";
            string identificadorReal = "";
            string reglaEvaluar = "";

            int index = line.IndexOf(limitante);
            identificador = line.Substring(0, index);

            int index2 = identificador.IndexOf(blankSpace);
            identificadorReal = identificador.Substring(0, index2);

            reglaEvaluar = line.Substring(index + 1);
            LeeSets.REVSETS(identificadorReal, reglaEvaluar, b);


        }
    }
}
