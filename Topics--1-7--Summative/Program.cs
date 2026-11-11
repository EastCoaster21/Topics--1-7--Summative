namespace Topics__1_7__Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int money = 100;
            //int wins = 0;
            //int losses = 0;
            //int ties = 0;
            //int rock = 1;
            //int paper = 2;
            //int scissors = 3;
            int choice;
            bool playing = true;
            while (playing && money > 0)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Welcome to Rock, Paper, Scissors.");
                Console.WriteLine("=================================");
                Console.WriteLine();
                Console.WriteLine("Starting money: $100");
                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Your money: $" + money);
                Console.WriteLine();
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("4. Quit");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                string choiceInput = Console.ReadLine();
                if (!int.TryParse(choiceInput, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                if (choice == 4)
                {
                    playing = false;
                    break;
                }
                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Please choose 1, 2, 3, or 4.");
                    continue;
                }
                Console.Write("How much would you like to bet? ");
                string betInput = Console.ReadLine();
                int bet;
                if (!int.TryParse(betInput, out bet)) 
                {
                    Console.WriteLine("Invalid bet.");
                    continue;
                }
                if (bet <= 0)
                {
                    Console.WriteLine("Yeah, that's not how it works.");
                    continue;
                }
                if (bet > money) 
                {
                    Console.WriteLine("You don't have that much.");
                    continue;
                }
                int computerChoice = random.Next(1, 4);
                Console.WriteLine();
                if (choice == 1)
                {
                    Console.WriteLine("You chose Rock!");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You chose Paper");
                }
                else
                {
                    Console.WriteLine("You chose Scissors");
                }
                if (computerChoice == 1)
                {
                    Console.WriteLine("Computer chose Rock.");
                }
                else if (computerChoice == 2)
                {
                    Console.WriteLine("Computer chose Paper!");
                }
                else
                {
                    Console.WriteLine("Computer chose Scissors.");
                }
                Console.WriteLine();
                if (choice == computerChoice) 
                {
                    Console.WriteLine("Woah! It's a Tie!");
                    Console.WriteLine();
                    Console.WriteLine("Your bet was refunded.");
                }
            }
        }
    }
}
