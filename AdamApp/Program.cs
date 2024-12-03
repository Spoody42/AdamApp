using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());    // Action remove //

          //  Greeting(); //2

           string feedback;
       //   feedback = PlayGuessingGameV2();
       //     Finish();
        } // end of Main
          //
          // Console.WriteLine(feedback);
         //  PlayGames();
        //    //1

       

        

        /// <summary>
        /// Play Guessing Game
        /// Get computers random number
        /// Get user hiess
        /// Check guess and Get Feedback
        /// Display feedback
        /// </summary>
        static public string PlayGuessingGameV1(int answer)
        {
            int userGuess;
            int max = 10;
            string prompt = $"Guess a number between 0 and {max}: ";
            string feedback;

            userGuess = GetInt(prompt, max);
            feedback = CheckGuess(userGuess, answer);
            return feedback;
        }

        private static string CheckGuess(int userGuess, int answer)
        {
            string feedback = "";
            if (userGuess == answer)
                feedback = "Congraulations you guessed correctly";
            else if (userGuess > answer)
                feedback = "Error you guessed too high you lose";
            else if (userGuess < answer)
                feedback = "Error you guessed too low you lose";

            return feedback;
        }// end of CheckGuess

       
        static Random random = new Random();
        private static int GenerateNumber(int max)
        {
            int num = random.Next(0, max);
            return num;
        }// end of GenerateNumber

        private static int GetInt(string prompt, int max)
        {
            string text = "";
            int num;
            text = GetText(prompt);
            num = int.Parse(text);
            return num;
        }


        // end of GetText

        // PlayGuessingGameV1

        static public string PlayGuessingGameV2()
        {
            int max = 10;
            string prompt = $"Guess a number between 0 and {max}";
            string feedback = "";
            int attempt = 0;
            int answer = 0;
            answer = GenerateNumber(max);
            do
            {
                attempt = attempt + 1;
                feedback = PlayGuessingGameV1(answer);
                Console.WriteLine(feedback);
           
            } while ((attempt <= 3) && (feedback.StartsWith("Error")));
            
            if (!feedback.StartsWith("Error"))
                feedback = $"You win as you're guessing correctly in {attempt} attempts(s) \n";
            else
                feedback = $"You lost as you didnt guess correctly in 3 attempts \n";
            return feedback;
        } //end of PlayGuessingGameV2

            static public void PlayGames()
            {
                string choice;
                string feedback = "";
                do
                {
                    choice = GetMenuChoice("1 - Guessing Game, 2- Dice, 3 - Ten Sided Dice, 4 - Twenty Sided Dice, 5 - High Card Wins, 6 - Blackjack");
                if (choice == "1")
                    feedback = PlayGuessingGameV2();
                else if (choice == "2")
                    feedback = PlayDiceGame();
                else if (choice == "3")
                    feedback = PlayTenSidedDiceGame();
                else if (choice == "4")
                    feedback = PlayTwentySidedDiceGame();
                    Console.Write("/n" + feedback);
                } while (choice != "0");

               
            }// end of PlayGames

        private static string GetMenuChoice(string availableGames)
        {
            string choice;
            string[] games = availableGames.Split(',');
            string menu = "";
            for(int i =0; i <= (games.Length - 1); i++)
            {
                menu += games[i] + "\n";
            }
            menu += "Enter menu choice 1, 2 ,3 or 0 to exit:  ";
            choice = GetText(menu);
            return choice;
            // end of getMenuChoice
        }

        public static string PlayTenSidedDiceGame()
        {
            try
            {
                TenSidedDice playerDice = new TenSidedDice("Blue"); //1
                TenSidedDice computerDice = new TenSidedDice("Red"); //2
                PlayerScore = playerDice.Num;
                ComputerScore = computerDice.Num;
                feedback = FindGameWinner();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not implemented correctly " + ex.Message, "Exception Error");
            }
            return feedback;
        }// end of PLayTenSidedDiceGame

        public static string PlayTwentySidedDiceGame()
        {
            string feedback = "";
            try
            {
                TwentySidedDice playerDice = new TwentySidedDice("Blue");
                TwentySidedDice computerDice = new TwentySidedDice("Red");
                PlayerScore = playerDice.Num;
                ComputerScore = computerDice.Num;
                feedback = $"Player rolled {playerDice} Computer rolled {computerDice} \nResult: ";
                feedback += FindGameWinner();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly " + ex.Message, "Exception Error");
            }
            return feedback;
        } // end of PlayTwentySidedDiceGame

        // Global variables
        static string feedback = "";
        public static string PlayerName = "";
        public static int PlayerScore = 0;
        public static int ComputerScore = 0;
        public static string Winner = "";
        public static string PlayDiceGame()
        {
            string feedback = "";
            try
            {
                Dice playerDice = new Dice("Blue"); //a
                Dice computerDice = new Dice("Red");
                PlayerScore = playerDice.Num; //b
                ComputerScore = computerDice.Num;
                feedback = $"Player rolled {playerDice} computer rolled {computerDice} \nResult: ";
                feedback += FindGameWinner();
            }
            catch (Exception ex)
            {
                feedback = "Not Implemented correctly";
            }
            return feedback;
        } //end of PlayDiceGame

        public static string FindGameWinner()
        {
            string feedback = "";
            if (PlayerScore == ComputerScore)
            {
                feedback = $"Draw as{PlayerScore} was equal to {ComputerScore}";
             // Winner = "Draw";
            }
            else if (PlayerScore > ComputerScore)
            {
                feedback = $"{PlayerName} wins as your score {PlayerScore} is higher than {ComputerScore}";
                Winner = PlayerName;
            }
            else if (ComputerScore > PlayerScore)
            {
                feedback = $"Computer wins as your score {PlayerScore} is lower than {ComputerScore}";
            }
            return feedback + "\n\n";
        } // end of FindGameWinner

        static public string GetText(string prompt)
    {
        string text = "";
        do
        {
            Console.Write(prompt);
            text = Console.ReadLine();
            if (text == "")
                Console.WriteLine("You must enter a name, try again/n");
        } while (text == "");
        return text;
       }

        static public void Greeting()
        {
            string message = "Welcome ";
           string name;
           name = GetText("What is your name? ");
          Console.WriteLine(message + name);
        }// end of Greeting


        static public void Finish()
        {
            Console.WriteLine("Press enter key to exit the app");
            Console.Read();

        } // end of Finish




    } // end of the world nothing goes beyond here
}

