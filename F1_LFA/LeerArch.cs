using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_LFA
{
    public class LeerArch
    {
        public static void Leer()
        {
            string filePath = @"C:\Users\luisp\Desktop\Landivar\Quinto Año\Lenguajes formales y automatas\Lab\Gram\GRAMATICA.txt";

            List<string> texto = new List<string>();

            int a = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string contenido;

                while ((contenido = reader.ReadLine()) != null)
                {
                    texto.Add(contenido);
                    a++;
                    //Console.WriteLine(contenido);
                }
            }
            int Iter = 0;
            int Recor = 0;
            int FinIter = 0;
            int Error = 0;

            while(Recor <= a)
            {

                if (Convert.ToString(texto[Recor].Trim()) == "SETS")
                {
                    while (Recor != a)
                    {
                        Recor++;
                        if (Convert.ToString(texto[Recor].Trim()) == "TOKENS")
                        {
                            break; 
                        }
                        if (Convert.ToString(texto[Recor].Trim()) != "")
                        {
                            Identificador.getIdentificador(texto[Recor], Recor); 
                        }

                    }
                }
                if (Convert.ToString(texto[Recor].Trim()) == "TOKENS")
                {
                    while(Recor!= a)
                    {
                        Recor++;
                        if (Convert.ToString(texto[Recor].Trim())== "ACTIONS")
                        {
                            break; 
                        }
                    }

                }

                //CONTINUAR CON LAS EXPRESIONES REGULARES 

            }
        }
    }









    
}
