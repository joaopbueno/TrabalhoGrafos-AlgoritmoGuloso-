using System;
using System.Collections.Generic;
using System.Text;

namespace Trab_Grafos
{
    public class Guloso
    {

        static int V ; // Número de vértices no grafo
        public Guloso(int v)
        {
            V = v;
        }

        // Função para encontrar o vértice com a distância mínima
        static int MinDistancia(int[] distancia, bool[] visitado)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < V; v++)
                if (visitado[v] == false && distancia[v] <= min)
                {
                    min = distancia[v];
                    minIndex = v;
                }

            return minIndex;
        }

        public static void AlgoritmoGuloso(int[,] grafo, int origem, int destino)
        {
            int[] distancia = new int[V]; // Distâncias do vértice de origem
            bool[] visitado = new bool[V]; // Conjunto de vértices visitados

            for (int i = 0; i < V; i++)
            {
                distancia[i] = int.MaxValue;
                visitado[i] = false;
            }

            distancia[origem] = 0; // Distância da origem até ela mesma é 0

            for (int count = 0; count < V - 1; count++)
            {
                int u = MinDistancia(distancia, visitado);

                visitado[u] = true;

                for (int v = 0; v < V; v++)
                    if (!visitado[v] && grafo[u, v] != 0 && distancia[u] != int.MaxValue && distancia[u] + grafo[u, v] < distancia[v])
                        distancia[v] = distancia[u] + grafo[u, v];
            }

            ArquivoTXT.salvarGrafo(distancia);
            Console.WriteLine($"A menor distância do vértice {origem} para o vértice {destino} é {distancia[destino]}");
        }
    }
}
