namespace Topics__1_7__Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int money = 100;
            int wins = 0;
            int losses = 0;
            int ties = 0;
            //int rock = 1;
            //int paper = 2;
            //int scissors = 3;
            string numchoice;
            int choice;
            bool playing = true;

            string computerString = "";
            string choiceInput = "";

            while (playing && money > 0)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Welcome to Rock, Paper, Scissors.");
                Console.WriteLine("=================================");
                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
                Console.Clear();
                //Console.WriteLine("Your money: $" + money);
                //Console.WriteLine();
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("4. Quit");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                choiceInput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Your Money: $" + money);
               
                if (choiceInput == "4")
                {
                    playing = false;
                    break;
                }
                //if (choiceInput != "1" || choiceInput != "2" || choiceInput != "3" || choiceInput != "4" || choiceInput != "ROCK" || choiceInput != "PAPER" || choiceInput != "SCISSORS" || choiceInput != "QUIT")
                //{
                //    Console.WriteLine("Please choose 1, 2, 3, or 4.");
                //    continue;
                //}
                else
                {
                    Console.WriteLine("Invalid Choice");
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
                if (choiceInput == "1"||choiceInput.ToUpper() == "ROCK")
                {
                    choiceInput = "ROCK";
                    Console.WriteLine("You chose Rock!");
                    Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)");
                }
                else if (choiceInput == "2" || choiceInput.ToUpper() == "PAPER")
                {
                    choiceInput = "PAPER";
                    Console.WriteLine("You chose Paper");
                    Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)");
                }
                else if (choiceInput == "3" || choiceInput.ToUpper() == "SCISSORS")
                {
                    choiceInput = "SCISSORS";
                    Console.WriteLine("You chose Scissors");
                    Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                }

                if (computerChoice == 1)
                {
                    computerString = "ROCK";
                    Console.WriteLine("Computer chose Rock.");
                    Console.WriteLine("    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)");
                }
                else if (computerChoice == 2)
                {
                    computerString = "PAPER";
                    Console.WriteLine("Computer chose Paper!");
                    Console.WriteLine("    _______\r\n---'   ____)______\r\n          ________)\r\n          _________)\r\n         _________)\r\n---.____________)");
                }
                else
                {
                    computerString = "SCISSORS";
                    Console.WriteLine("Computer chose Scissors.");
                    Console.WriteLine("    _______\r\n---'   ____)_____\r\n          _______)\r\n       ___________)\r\n      (____)\r\n---.__(___)");
                }
                Console.WriteLine();
                
                // Looks for a tie
                if (choiceInput.ToUpper() == computerString)
                {
                    Console.WriteLine("Woah! It's a Tie!");
                    Console.WriteLine();
                    Console.WriteLine("Your bet was refunded.");
                    ties++;
                    Console.WriteLine("PRESS ENTER TO CONTINUE");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if ((choiceInput == "ROCK" && computerString == "SCISSORS") || (choiceInput == "PAPER" && computerString == "ROCK") || (choiceInput == "SCISSORS" && computerString == "PAPER"))
                {
                    Console.WriteLine("Congrats! You won!");
                    money = money + bet;
                    wins++;
                    Console.WriteLine("PRESS ENTER TO CONTINUE");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Sorry, pal. You got beat.");
                    Console.WriteLine();
                    Console.WriteLine("You lost $" + bet + ".");
                    money = money - bet;
                    losses++;
                    Console.WriteLine();
                    Console.WriteLine("PRESS ENTER TO CONTINUE");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (playing)
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine("STATISTICS:");
                    Console.WriteLine("Money remaining: $" + money);
                    Console.WriteLine("Wins: " + wins);
                    Console.WriteLine("Losses: " + losses);
                    Console.WriteLine("Ties: " + ties);
                    Console.WriteLine("=======================");
                }
                

                if (money == 0) 
                {
                    Console.WriteLine("You ran out of money.");
                    Console.WriteLine();
                    Console.WriteLine("Get out of my casino.");
                    playing = false;
                }
            }

            Console.WriteLine("=======================");
            Console.WriteLine("Please Come Again.");
            Console.WriteLine("=======================");
            Console.WriteLine("You Finished With:");
            Console.WriteLine("Final Money: $" + money);
            Console.WriteLine("Final Wins: " + wins);
            Console.WriteLine("Final Losses: " + losses);
            Console.WriteLine("Final Ties: " + ties);
            Console.WriteLine("=======================");
            Console.WriteLine();
            if (money > 100)
            {
                Console.WriteLine("Lucky! You made a profit!");
            }
            else if (money < 100)
            {
                Console.WriteLine("You lost money. :(");
            }
            else if (money == 100) 
            {
                Console.WriteLine("You broke even. Cool.");
            }
        }
    }
}
