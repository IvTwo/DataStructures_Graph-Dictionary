namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 20;  // number of nodes in the graph

            // create UndirectedGraph
            MyUndirectedGraph graph = new MyUndirectedGraph(size);
            graph.RandomGraph();
            graph.AdjacencyMatrix();
        }

        // accept user input as a string
        public static void MyMenu()
        {
            bool keepGoing = true;
            Console.WriteLine();
            Console.WriteLine("Welcome To The Undirected Graph Showcase----!");
            Console.WriteLine();
            Console.WriteLine("\t1. Print\n" + "\t2. Path\n" + "\t3. Exit\n"); ;

            while (keepGoing)
            {
                Console.WriteLine() ;
                string userInput = UserInput();

                switch (userInput)   // handle user input
                {
                    case "1":
                        
                        break;

                    case "2":
                        
                        break;

                    case "3":

                        break;

                    default:
                        Console.WriteLine("---");
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
        }

        // return the user input |  O(1)
        public static string UserInput()
        {
            Console.Write("\t * Your Input: ");
            return Console.ReadLine();
        }
    }
}