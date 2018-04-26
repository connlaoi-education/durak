using JeremyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakGame
{
    public class Game
    {

        public event System.EventHandler GameWon;
        public event System.EventHandler GameLost;

        public PlayingCard trumpCard;
        public CardSuit trumpSuit;
        private Deck deck;
        public Deck Deck
        {
            get { return deck; }
            set { deck = value; }
        }

        private List<Player> myPlayers = new List<Player>();
        public List<Player> Players
        {
            get { return myPlayers; }
            set { Players = value; }
        }
        private River river = new River();
        public River River
        {
            get { return river; }
            set { river = value; }
        }


        protected virtual void OnGameWon()
        {
            GameWon?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnGameLost()
        {
            GameLost?.Invoke(this, EventArgs.Empty);
        }


        public Game()
        {
            Players.Clear();
            Player userPlayer = new Player();
            AIPlayer computer = new AIPlayer();
            Players.Add(userPlayer);
            Players.Add(computer);

            Deck = new Deck(true, CardSuit.Clubs, 52);
            Deck.Shuffle();
            trumpCard = Deck.GetCard(0);
            trumpSuit = trumpCard.Suit;
            River.Clear();
        }

        public Game(int deckSize)
        {
            Players.Clear();
            Player userPlayer = new Player();
            AIPlayer computer = new AIPlayer();
            Players.Add(userPlayer);
            Players.Add(computer);

            deck = new Deck(true, CardSuit.Clubs, deckSize);
            Deck.Shuffle();
            trumpCard = Deck.GetCard(0);
            trumpSuit = trumpCard.Suit;
            River.Clear();
        }

        public void SwapTurns()
        {
            if (this.Players[0].Status != Statuses.Won && this.Players[1].Status != Statuses.Won)
            {
                if (Players[0].Status == Statuses.Attacking)
                {
                    Players[0].Status = Statuses.Defending;
                    Players[1].Status = Statuses.Attacking;
                }
                else if (Players[0].Status == Statuses.Defending)
                {
                    Players[0].Status = Statuses.Attacking;
                    Players[1].Status = Statuses.Defending;
                }
            }
        }

        public void EndTurn()
        {
            foreach(Player player in Players)
            {
                player.DrawToSix(Deck);
            }
            this.Players[1].firstTurn = true;
            River.Clear();
            if (Players[1].Status == Statuses.Attacking)
            {
                Players[1].Attack(this);
            }


            if (this.Players[0].Hand.Count == 0 && this.River.Count == 0 && this.Deck.Cards.Count == 0)
            {
                OnGameWon();
            }

            if (this.Players[1].Hand.Count == 0 && this.River.Count == 0 && this.Deck.Cards.Count == 0)
            {
                OnGameLost();
            }
        }

        public void Transfer()
        {
            SwapTurns();
            Players[0].firstTurn = false;
            Players[1].firstTurn = false;
        }
    }
}