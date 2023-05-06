using System;
using System.Collections.Generic;
using System.IO;

namespace Trab_Grafos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do arquivo: ");
            string arquivo = Console.ReadLine();
            Console.Write("Aresta de origem: ");
            int origem = int.Parse(Console.ReadLine());
            Console.Write("Aresta de destino: ");
            int destino = int.Parse(Console.ReadLine());


            int[,] grafo = ArquivoTXT.lerGrafo(arquivo);

            Guloso algoritmoGuloso = new Guloso(grafo.GetLength(0));

            Guloso.AlgoritmoGuloso(grafo, origem, destino);

            Console.WriteLine("FINALIZADO");
        }
    }
}
