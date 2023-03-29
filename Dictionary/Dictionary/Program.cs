namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMenu();
        }

        public static void MyMenu()
        {
            Shop shop = new Shop(20);
            Player player = new Player(10);

            bool keepGoing = true;
            Console.WriteLine();
            Console.WriteLine("Welcome To The Shop Simulator----!");
            player.DisplayCoins();
            Console.WriteLine("Please enter a command | To exit the program input \"q\"");

            while (keepGoing)
            {
                Console.WriteLine();
                string userInput = UserInput();
                string[] words = userInput.Split(' ');

                switch (words[0].ToLower())   // handle user input
                {
                    case "buy": 
                    case "b":
                        if (words.Length != 2)  //check command format
                        {
                            Console.WriteLine("Invalid Format");
                            break;
                        }
                        shop.BuyItem(words[1], ref player);
                        break;

                    case "sell":
                    case "s":
                        break;

                    case "inventory":
                    case "i":
                        shop.DisplayInventory();
                        break;

                    case "collection":
                    case "c":
                        break;

                    case "q":
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