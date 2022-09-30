using System;

namespace Rock_Paper
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool playagain = true;
            string player;
            string computer;
            string answer;

            while (playagain)
            {
                player = "";
                computer = "";
                answer = "";
                
                while (player !="ROCK" && player !="PAPER" && player !="SCISSORS")
                {


                    Console.ForegroundColor = ConsoleColor.DarkGreen;
               Console.WriteLine("Enter ROCK,PAPER or SCISSORS:");
                player = Console.ReadLine();
                player = player.ToUpper();
            }
                
                //int randomNum=random.Next(1,4)
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;


                }

                Console.WriteLine("Player : " + player);
                Console.WriteLine("Computer : " + computer);

                switch (player)
                {
                    case "ROCK":

                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Its a Draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU LOSE");
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        break;
                    case "PAPER":

                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("ITS A DRAW");
                        }
                        else
                        {
                            Console.WriteLine("YOU LOSE!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("YOU LOSE");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("YOU WIN!");
                        }
                        else
                        {
                            Console.WriteLine("ITS A DRAW");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again Y or N");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                if (answer == "Y")
                {
                    playagain = true;
                }
                else 
                {
                    playagain = false;
                    

                }
                Console.WriteLine("Thanks for Playing");
            
            }
            
        }
    }
}
