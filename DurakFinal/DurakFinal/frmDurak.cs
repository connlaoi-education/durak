using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DurakGame;
using JeremyCards;

namespace DurakFinal
{

    public partial class frmDurak : Form
    {
        Game game;
        public frmDurak()
        {
            InitializeComponent();
        }

        private void frmDurak_Load(object sender, EventArgs e)
        {

        }

        private void newGame20ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            game = new Game(20);
            StartGame();
            pnlStart.Visible = false;
        }
        private void newGame36CardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new Game(36);
            StartGame();
            pnlStart.Visible = false;
        }

        private void newGame52CardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new Game(52);
            StartGame();
            pnlStart.Visible = false;
        }
        private void StartGame()
        {
            pnlRiver.Controls.Clear();
            pnlOppHand.Controls.Clear();
            pnlPlayerHand.Controls.Clear();
            game.GameWon += GameWon;
            game.GameLost += GameLost;
            game.Deck.Cards.CollectionChanged += UpdateDeckSize;
            game.Players[0].StatusChanged += PlayerStatusHandler;
            game.Players[1].StatusChanged += AIStatusHandler;
            DetermineRandomAttacker();
            game.Players[0].Hand.CollectionChanged += PlayerHandHandler;
            game.Players[1].Hand.CollectionChanged += AIHandHandler;
            game.River.CollectionChanged += UpdateRiver;
            game.River.CollectionChanged += PlayerHandHandler;
            cbxTrump.Card = game.trumpCard;
            cbxTrump.FaceUp = true;
            game.Players[0].DrawToSix(game.Deck);
            game.Players[1].DrawToSix(game.Deck);

            if(game.Players[1].Status == Statuses.Attacking)
            {
                game.Players[1].Attack(game);
            }
        }

        public void GameWon(object sender, EventArgs e)
        {
            WinMessage();
        }
        public void GameLost(object sender, EventArgs e)
        {
            LoseMessage();
        }

        public void WinMessage()
        {
            if (game.Players[0].Status != Statuses.Won && game.Players[1].Status != Statuses.Won)
            {
                MessageBox.Show("You Won! Press OK to return to title screen.", "Game Won");
                game.Players[0].Status = Statuses.Won;
                SwapForms();
            }
        }

        public void LoseMessage()
        {
            if (game.Players[0].Status != Statuses.Won && game.Players[1].Status != Statuses.Won)
            {
                MessageBox.Show("You Lost! Press OK to return to title screen.", "Game Lost");
                game.Players[1].Status = Statuses.Won;
                SwapForms();
            }
        }

        public void UpdateRiver(object sender, EventArgs e)
        {
            pnlRiver.Controls.Clear();
            
            int offset = 0;
            for(int i = 0; i < game.River.Count; i++)
            {
                CardBox.CardBox cbx = new CardBox.CardBox
                {
                    Visible = true,
                    Card = game.River[i],
                    Width = cbxRiver.Width,
                    Height = cbxRiver.Height,
                    Left = cbxRiver.Left + ((i * (cbxRiver.Width / 3)) + offset),
                    Top = cbxRiver.Top
                };
                offset += 10;
                this.pnlRiver.Controls.Add(cbx);
            }
        }

        public void PlayerHandHandler(object sender, EventArgs e)
        {
            pnlPlayerHand.Controls.Clear();
            game.Players[0].UpdatePlayableCards(game);
            game.Players[1].UpdatePlayableCards(game);
            int offset = 0;
            for (int j = 0; j < game.Players[0].Hand.Count; j++)
            {
                CardBox.CardBox cbx = new CardBox.CardBox
                {
                    Visible = true,
                    Card = game.Players[0].Hand[j],
                    Width = cbxHand.Width,
                    Height = cbxHand.Height,
                    Left = cbxHand.Left + ((j * (cbxHand.Width / 3)) + offset)
                };
                if (game.Players[0].Hand.Count > 13)
                {
                    cbx.Width = cbx.Width - pnlPlayerHand.Width / game.Players[0].Hand.Count;
                    cbx.Height = cbx.Height - (pnlPlayerHand.Width / game.Players[0].Hand.Count);
                    offset -= 5;
                    cbx.Left = cbxHand.Left + ((j * (cbxHand.Width / 10)) + offset);
                }
                offset += 10;
                cbx.Click += HandClickHandler;
                this.pnlPlayerHand.Controls.Add(cbx);

                if (game.Players[0].PlayableCards.Contains(game.Players[0].Hand[j]))
                {
                    cbx.Top = cbxHand.Top - 20;
                }
                else
                {
                    cbx.Top = cbxHand.Top;
                }
            }
            if(!game.Players[0].firstTurn)
            {
                if (game.Players[0].Status == Statuses.Attacking)
                {
                    btnOkay.Enabled = true;
                }
                else
                {
                    btnOkay.Enabled = false;
                }
            }
            if (game.Players[0].Status == Statuses.Defending)
            {
                btnTake.Enabled = true;
            }
            else
            {
                btnTake.Enabled = false;
            }

        }

        public void HandClickHandler(object sender, EventArgs e)
        {
            CardBox.CardBox cardBoxClicked = (CardBox.CardBox)sender;
            PlayingCard cardClicked = cardBoxClicked.Card;
            if(game.Players[0].PlayableCards.Contains(cardClicked))
            {

                if (game.Players[0].Status == Statuses.Attacking)
                {
                    game.Players[0].Play(cardClicked, game.River);
                    game.Players[0].firstTurn = false;
                }
                else if ((game.Players[0].Status == Statuses.Defending) && game.Players[0].firstTurn)
                {
                    if (cardClicked.Rank == game.River[0].Rank)
                    {
                        game.Transfer();
                        MessageBox.Show("You transferred to your opponent, you are now attacking!", "Transfer Warning");
                    }
                    game.Players[0].Play(cardClicked, game.River);
                    game.Players[0].firstTurn = false;
                }
                else
                {
                    game.Players[0].Play(cardClicked, game.River);
                }



                if (game.Players[1].Status == Statuses.Attacking)
                {
                    game.Players[1].Attack(game);
                    game.Players[1].firstTurn = false;
                }
                else if(game.Players[1].Status == Statuses.Defending)
                {
                    game.Players[1].Defend(game);
                }
            }

            if(game.Players[0].Hand.Count == 0 && game.River.Count == 0 && game.Deck.Cards.Count == 0)
            {
                WinMessage();
            }

            if (game.Players[1].Hand.Count == 0 && game.River.Count == 0 && game.Deck.Cards.Count == 0)
            {
                LoseMessage();
            }

        }
        public void AIHandHandler(object sender, EventArgs e)
        {
            pnlOppHand.Controls.Clear();
            game.Players[0].UpdatePlayableCards(game);
            game.Players[1].UpdatePlayableCards(game);

            int offset = 0;
            for (int j = 0; j < game.Players[1].Hand.Count; j++)
            {
                PictureBox pbx = new PictureBox
                {
                    Visible = true,
                    BackgroundImage = new Bitmap(DurakFinal.Properties.Resources.back),
                    Width = pbxOppHand.Width,
                    Height = pbxOppHand.Height,
                    Left = pbxOppHand.Left + ((j * (pbxOppHand.Width) / 3) + offset),
                    Top = pbxOppHand.Top,
                    BackgroundImageLayout = ImageLayout.Stretch
                };
                if (game.Players[1].Hand.Count > 13)
                {
                    pbx.Width = pbx.Width - pnlPlayerHand.Width / game.Players[1].Hand.Count;
                    pbx.Height = pbx.Height - (pnlPlayerHand.Width / game.Players[1].Hand.Count);
                    offset -= 5;
                    pbx.Left = pbxOppHand.Left + ((j * (pbxOppHand.Width / 10)) + offset);
                }
                offset += 10;
                this.pnlOppHand.Controls.Add(pbx);
            }
        }

        public void PlayerStatusHandler(object sender, EventArgs e)
        {
            Player handlePlayer = (Player)sender;
            lblPlayerStatus.Text = "Your Status: " + handlePlayer.Status;
        }
        public void AIStatusHandler(object sender, EventArgs e)
        {
            Player handlePlayer = (Player)sender;
            lblOppStatus.Text = "Opponent Status: " + handlePlayer.Status;
        }
        
        private void UpdateDeckSize(object sender, EventArgs e)
        {
            if(game.Deck.getDeckSize() == 0)
            {
                cbxDeck.Visible = false;
            }
            else
            {
                cbxDeck.Visible = true;
            }

            lblCardsRemaining.Text = "Cards Remaining: " + game.Deck.getDeckSize().ToString();
        }
        
        private void DetermineRandomAttacker()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 0)
            {
                game.Players[0].Status = Statuses.Attacking;
                game.Players[1].Status = Statuses.Defending;
            }
            else
            {
                game.Players[1].Status = Statuses.Attacking;
                game.Players[0].Status = Statuses.Defending;
            }
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            game.Players[0].Pass(game);
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            game.Players[0].Take(game);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart20_Click(object sender, EventArgs e)
        {
            game = new Game(20);
            StartGame();
            SwapForms();
        }

        private void btnStart36_Click(object sender, EventArgs e)
        {
            game = new Game(36);
            StartGame();
            SwapForms();
        }

        private void btnStart52_Click(object sender, EventArgs e)
        {
            game = new Game(52);
            StartGame();
            SwapForms();
        }

        public void SwapForms()
        {
            if(pnlStart.Visible)
            {
                pnlStart.Visible = false;
            }
            else
            {
                pnlStart.Visible = true;
            }
        }
    }
}
