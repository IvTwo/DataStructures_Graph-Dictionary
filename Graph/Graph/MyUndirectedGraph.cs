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

                    if (rand.Next(0,14) == 1)    // how many connections are made
                    {
                        edges[i, j] = 1;
                        edges[j, i] = 1;
                    }
                }
            }
        }

        public void PrintAdjacencyMatrix()
        {
            for (int i = 0; i < edges.GetLength(0); i++)
            {
                Console.Write((i+1).ToString().PadRight(3) + "| ");

                for (int j = 0; j < edges.GetLength(1); j++)
                {
                    Console.Write(edges[i, j] + "   ");
                }

                if (i == edges.GetLength(0) - 1)
                {
                    Console.WriteLine();
                    Console.Write("   | ");
                    Console.Write("".PadRight(edges.GetLength(1)*4, '-'));
                    Console.WriteLine();
                    Console.Write("     ");
                    for (int k = 0; k < edges.GetLength(1); k++)
                    {
                        Console.Write((k+1).ToString().PadRight(4));
                    }
                }
                Console.WriteLine();
            }
        }

        // check if there is  path from node1 to node2
        // ref: https://www.koderdojo.com/blog/depth-first-search-algorithm-in-csharp-and-net-core
        public bool CheckPath(int startNode, int endNode)
        {
            HashSet<int> visited = new HashSet<int>();  // set of all nodes already visited

            // check if input is valid
            if (startNode > size || endNode > size || startNode < 0 || endNode< 0)
            {
                return false;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(startNode);

            // "stack" is all nodes connected to the start node.
            // once there are no nodes to check exit the while loop
            while (stack.Count > 0)
            {
                int vertex = stack.Pop();   // set top of the stack to vertex (node we arae checking)

                // if the node has already been visited, exit this loop iteration
                if (visited.Contains(vertex))
                    continue;
                
                // otherwise add node to "visited"
                visited.Add(vertex);

                // iterate through adjacency matrix for startNode
                for(int i = 0; i < edges.GetLength(1); i++)
                {
                    // for all adjacent nodes that we have not visited yet --> add to stack
                    if (edges[vertex, i] == 1 && !visited.Contains(i))
                    {
                        stack.Push(i);
                    }
                }
            }

            // if endNode is in the set "visited" then there is a valid path from startNode to endNode --> return true
            if (visited.Contains(endNode))
                return true;
            else
                return false;
        }

        // return true if node1 & node2 are directly adjacent
        public bool CheckAdjacency(int node1, int node2)
        {
            if (edges[node1, node2] == 1)
                return true;
            else
                return false;
        }

        public void AddEdge()
        {

        }

        public void DeleteEdge()
        {

        }
    }
}
