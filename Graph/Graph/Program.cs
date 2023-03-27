namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMenu();
        }

        // accept user input as a string
        public static void MyMenu()
        {
            int size = 20;  // number of nodes in the graph

            // create UndirectedGraph
            MyUndirectedGraph graph = new MyUndirectedGraph(size);
            graph.RandomGraph();


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
                    case "1":   // print adjacency matrix
                        Console.WriteLine();
                        Console.WriteLine("Adjacency Matrix of the current graph---");
                        Console.WriteLine();
                        graph.PrintAdjacencyMatrix();
                        break;

                    case "2":   // check if a path exists
                        Console.WriteLine();
                        Console.WriteLine("Check if there is a path from node1 to node2");
                        string[] words = UserInput().Split(' ');

                        // if the user inputs more/less than 2 nodes
                        if (words.Length != 2) 
                        {
                            Console.WriteLine("---");
                            Console.WriteLine("Invalid Input!");
                            Console.WriteLine("returning to menu input...");
                            break;
                        }

                        if (graph.CheckPath(int.Parse(words[0])-1, int.Parse(words[1])-1))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Yes: there is a path between " + int.Parse(words[0]) + " & " + int.Parse(words[1]));
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("No: path not found between " + int.Parse(words[0]) + " & " + int.Parse(words[1]));
                        }
                        break;

                    case "3":
                        keepGoing = false;
                        break;

                    default:
                        Console.WriteLine("---");
                        Console.WriteLine("Invalid Input!");
                        Console.WriteLine("returning to menu input...");
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