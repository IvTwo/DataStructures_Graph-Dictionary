using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Node
    {
        private int data;
        //private List<Node> connections;

        public Node(int d)
        {
            data = d;
            //connections = new List<Node>();
        }

        //// returns true if a node(parameter) is adjacent to this node
        //public bool CheckAdjacency(Node node)
        //{
        //    if (connections.Contains(node))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
