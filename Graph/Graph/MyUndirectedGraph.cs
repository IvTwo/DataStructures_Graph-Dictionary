using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class MyUndirectedGraph
    {
        private List<Node> nodes;
        private int[,] edges;  // adjacency matrix
        private int size;

        public MyUndirectedGraph(int s)
        {
            size = s;
            nodes = new List<Node>();
            edges = new int[s, s];    // default value == 0
        }

        // generate a random UndirectedGraph of "size"
        public void RandomGraph()
        {
            // generate "size" nodes and add them to nodes(list)
            for (int i = 1; i <= size; i++)
            {
                nodes.Add(new Node(i));
            }

            // create random "edges" by filling the edges 2D array with 1s & 0s
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                for (int j = 0; j < edges.GetLength(1); j++)
                {
                    var rand = new Random();

                    if (rand.Next(0,2) == 1)
                    {
                        edges[i, j] = 1;
                    }
                }
            }
        }

        public void AdjacencyMatrix()
        {
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                for (int j = 0; j < edges.GetLength(1); j++)
                {
                    Console.Write(edges[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }

        public void AddEdge()
        {

        }

        public void DeleteEdge()
        {

        }
    }
}
