namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            userInterface();
        }

        public static void userInterface()
        {
            Player player = new Player(100, 10);

            Console.WriteLine();
            Console.WriteLine("Welcome to the Inventory Simulator----!");
            Console.WriteLine();
            Console.WriteLine("\t1. Buy\n" + "\t2. Sell\n" + "\t3. Inventory\n" +
                                "\t4. Collection\n" + "\t5. Quit\n");

            bool keepGoing = true;
            while (keepGoing) 
            {
                switch (UserInput()) // handle user input
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        player.DisplayInventory();
                        break;

                    case "4":
                        break;

                    case "5":
                        keepGoing = false;
                        break;

                    default:
                        Console.WriteLine("---");
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
        }

        // return the user input
        public static string UserInput()
        {
            Console.Write("\t * Your Input: ");
            return Console.ReadLine();
        }

    }
}