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

        public MyUndirectedGraph(int size)
        {
            nodes = new List<Node>();
            edges = new int[size, size];    // default value == 0
        }
    }
}
