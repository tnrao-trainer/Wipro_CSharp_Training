// C# program for Floyd Warshall All Pairs Shortest Path algorithm.

using System;

namespace ConsoleApp13
{
    class AllPairShortestPath
    {
        readonly static int INF = 99999, V = 4;

        public void FloydWarshall(int[,] graph)
        {
            int[,] dist = new int[V, V];
            int i, j, k;


            for (i = 0; i < V; i++)
            {
                for (j = 0; j < V; j++)
                {
                    dist[i, j] = graph[i, j];
                }
            }

            for (k = 0; k < V; k++)
            {
                for (i = 0; i < V; i++)
                {
                    for (j = 0; j < V; j++)
                    {
                        if (dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                        }
                    }
                }
            }

            PrintSolution(dist);
        }

        public void PrintSolution(int[,] dist)
        {
            Console.WriteLine(
                "Following matrix shows the shortest "
                + "distances between every pair of vertices");
            for (int i = 0; i < V; ++i)
            {
                for (int j = 0; j < V; ++j)
                {
                    if (dist[i, j] == INF)
                    {
                        Console.Write("INF\t"); 
                    }
                    else
                    {
                        Console.Write(dist[i, j] + "\t");
                    }
                }

                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            const int INF = 99999;
            int[,] graph = { 
                          { 0, 5, INF, 10 },
                          { INF, 0, 3, INF },
                          { INF, INF, 0, 1 },
                          { INF, INF, INF, 0 } };

            AllPairShortestPath a = new AllPairShortestPath();
            a.FloydWarshall(graph);

            Console.ReadLine();
        }
    }
}