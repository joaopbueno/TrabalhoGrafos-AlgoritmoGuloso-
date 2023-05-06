using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Trab_Grafos
{
    internal static class ArquivoTXT
    {
        public static int[,] lerGrafo(string arquivo)
        {
            string texto = @"C:\Users\Usuario\Desktop\Grafos\tp01_grafos\"+arquivo+".txt";
            string text;
            using (StreamReader sr = new StreamReader(texto))
            {
                text = sr.ReadToEnd();
            }

            string[] matriz = text.Split('\n');

            int[,] grafo = new int[matriz.Length, matriz.Length];
            int cont = 0;

            foreach (string num in matriz)
            {
                int cont2 = 0;
                string[] nums = num.Split(' ');
                foreach (var valor in nums)
                {
                    grafo[cont, cont2] = int.Parse(valor);
                    cont2++;
                }
                cont++;
            }

            return grafo;
        }

        public static void salvarGrafo(int[] arquivo)
        {
            string texto = @"C:\Users\Usuario\Desktop\Grafos\tp01_grafos\4_cidades_gabarito_gulosoTESTE.txt";

            using (StreamWriter sw = new StreamWriter(texto))
            {
                foreach(int num in arquivo)
                {
                    sw.WriteLine(num);
                }
            }
        }
    }
}
