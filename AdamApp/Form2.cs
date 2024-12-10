using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ResetInterface()
        {
            TbxPlayerName.Text = "";       //a
            CbxGame.SelectedIndex = -1;     //b
            CbxGame.Enabled = false;        //c
            BtnPlayGame.Enabled = false;    //d
            LsvGameStatistics.Clear();
        }
       
        /// <summary>
        /// FillCbxGame combo-boxc with available Games from String array
        /// a) Declare Array of available Games,
        /// b) clear existing CbxGame combo-box Items
        /// c) Add each game in array to CbxGame Items
        /// </summary>
        
        public void FillCbxGame()
        {
            String[] availableGames = { "Dice", "Ten Sided Dice", "Twenty Sided Dice", "High Card Wins", "Blackjack" };
            CbxGame.Items.Clear();          //b
            foreach (string game in availableGames)
                CbxGame.Items.Add(game);            //c
        } // end of FillCbxGame()

        private void Form2_Load(object sender, EventArgs e)
        {
            FillCbxGame();      // a
            ResetInterface();   // b

            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            this.BtnFindOverallWinner.Click += new System.EventHandler(this.BtnFindOverallWinner_Click);
            this.TbxPlayerName.TextChanged += new System.EventHandler(this.TbxPlayerName_TextChanged);
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(this.CbxGame_SelectedIndexChanged);
        }

        private void CbxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxGame.SelectedIndex != -1)
                BtnPlayGame.Enabled = true;
        } // end of CbxGame_SelectedIndexChanged            // a

        private void TbxPlayerName_TextChanged(object sender, EventArgs e)
        {
            if (TbxPlayerName.Text.Length > 1)
                CbxGame.Enabled = true;
        } // end of TbxPlayerName_TextChanged

        private void BtnFindOverallWinner_Click(object sender, EventArgs e)
        {
            DisplayOverallGameResult();
        } // end of BtnFindOverallWinner_Click

        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            Program.PlayerName = TbxPlayerName.Text.TrimEnd(); //a
            GameName = CbxGame.SelectedItem.ToString(); //b
            PlayGame(GameName);
        } // end of BtnPlayGame_Click


        private void DisplayGameResult(string gameName, string feedback)
        {
            if (gameName != "Blackjack")
            {
                string[] row = { GameName, Program.PlayerScore.ToString(), Program.ComputerScore.ToString(), Program.Winner };
                var listViewItem = new ListViewItem(row);
                LsvGameStatistics.Items.Add(listViewItem);
                MessageBox.Show(feedback, $"{gameName} Result");
            } else
            MessageBox.Show(feedback, $"{gameName} Next Step");
        
        } // end of DisplayOverallGameResult


        // Global Variables
        public string GameName = "";
        private void DisplayOverallGameResult()
        {
            int playerWins = 0;
            int computerWins = 0;
            string result = "";

            int numOfGames = LsvGameStatistics.Items.Count;

            foreach (ListViewItem element in LsvGameStatistics.Items)
            {
                result = element.SubItems[3].Text;

                if (result.StartsWith(Program.PlayerName))
                    playerWins += 1;
                else if (result.StartsWith("Computer"))
                    computerWins += 1;
            } // end for
            if (playerWins > computerWins)
                result = $"{Program.PlayerName} wins as they won{playerWins} games which is higher than {computerWins}";
            else if (playerWins < computerWins)
                result = $"Computer wins as they {computerWins} games which is higher than {playerWins}";
            else if (playerWins == computerWins)
                result = $"Draw as both won {computerWins} games";

            MessageBox.Show(result, "Overall Result");
        } //  endd of DisplayOverallGameResult

        public void PlayGame(string gameName)
        {
            string feedback = "";
            try
            {
                switch (GameName) //b
                {
                    case "Guessing Game":
                        feedback = Program.PlayGuessingGameV2(); break; // a
                    case "Dice":
                        feedback = Program.PlayDiceGame(); break;
                    case "Ten Sided Dice":
                        feedback = Program.PlayTenSidedDiceGame(); break; // b
                    case "Twenty Sided Dice":
                        feedback = Program.PlayTwentySidedDiceGame(); break; // c
                    case "High Card Wins":
                        feedback = PlayHighCardWinsGame(); break; // d
                    case "Blackjack":
                        feedback = PlayBlackjackGame(); break; // e

                    default:
                        MessageBox.Show("Game not implemented", "Error"); // e
                        break; //
                } // end switch

                DisplayGameResult(gameName, feedback);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly " + ex.Message, "Exception Error"); // a
            }
        } // end of PlayGame

        // Playing Card Games
        Deck mainDeck = null; // new

        private string PlayHighCardWinsGame()
        {
            if (mainDeck == null) mainDeck = new Deck(); // 1

            PlayingCard playerCard = mainDeck.Deal(); // 2
            Program.PlayerScore = playerCard.Value; // 3
            LblPlayerScore.Text = Program.PlayerScore.ToString(); // 4
            PlayingCard computerCard = mainDeck.Deal(); // 5
            Program.ComputerScore = computerCard.Value; // 6
            LblComputerScore.Text = Program.ComputerScore.ToString(); // 7

            return Program.FindGameWinner();

        }// end of PlayingHighCardGame

        Hand ComputerHand = null; // 2a
        Hand PlayerHand = null; // 2b

        /// <summary>
        /// 1) This is the deck class being used for a new deck
        /// 2) This is the player hand being added for a new hand
        /// 3) 
        /// </summary>


        public void DealaPlayerCard() // 2c
        {
            if (mainDeck == null)
                mainDeck = new Deck();  // 1
            if (PlayerHand == null)
                PlayerHand = new Hand();    // 2

            PlayingCard playerCard = mainDeck.Deal(); // 3
            PlayerHand.AddCardToHand(playerCard);     // 4
            DisplayPlayerCard(playerCard);            // 5
        }
        public void DealaComputerCard() // 2c
        {
            if (mainDeck == null)
                mainDeck = new Deck();  // 1
            if (ComputerHand == null)
                ComputerHand = new Hand();    // 2

            PlayingCard playerCard = mainDeck.Deal(); // 3
            ComputerHand.AddCardToHand(playerCard);     // 4
            DisplayComputerCard(playerCard);            // 5
        }
        private void DisplayPlayerCard(PlayingCard card)  // moved
        {
            try
            {
                LsvPlayerHand.Items.Add(new ListViewItem(new[] { card.Face.ToString(), card.Suit.ToString() }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Display Card Error");
            }
        } // end DisplayPlayerCard

        private void DisplayComputerCard(PlayingCard card)  // moved
        {
            try
            {
                LsvComputerHand.Items.Add(new ListViewItem(new[] { card.Face.ToString(), card.Suit.ToString() }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Display Card Error");
            }
        } // end DisplayPlayerCard
        public string PlayBlackjackGame() // 2d
        {
            DealaPlayerCard();
            DealaPlayerCard();

            Program.PlayerScore = PlayerHand.GetHandValue();           // 2
            LblPlayerScore.Text = Program.PlayerScore.ToString();     // 3
            return "Select Hit or Stand";
        }
 
        private void BtnHit_Click(object sender, EventArgs e)
        {
            try
            {
                DealaPlayerCard();
                Program.PlayerScore = PlayerHand.GetHandValue();           // 2
                LblPlayerScore.Text = Program.PlayerScore.ToString();     // 3
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Display BtnHit Error");
            }
        }

        private void BtnStand_Click(object sender, EventArgs e)
        {
            string feedback = "";
            try
            {
                DealaComputerHand();    // 1
                feedback = FindBlackjackGameWinner(); // 2
                DisplayGameResult("Blackjack", feedback);        // 3
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stand Error");
            }
        } // end BtnStand_Click

        private void DealaComputerHand()
        {
            throw new NotImplementedException();
        }

        private string FindBlackjackGameWinner()
        {
            string feedback = "";
            if ((Program.PlayerScore > Program.ComputerScore))
            {
                feedback = $"{Program.PlayerName} loses because {Program.PlayerName} is lower than Computer";
            }
            else if ((Program.PlayerScore <= 21) && (Program.ComputerScore > 21))
            {
                feedback = $"{Program.PlayerName} wins because have a higher number than Computer";
            }
            
          
            return feedback;
        } // end FindBlackjackGameWinner

    } // END OF CODE
}
