using JeremyCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame
{
    public class Player
    {
        public event System.EventHandler StatusChanged;

        private Hand myHand;
        private Statuses status;
        private Hand playableCards;
        public bool firstTurn = true;

        public Hand PlayableCards
        {
            get { return playableCards; }
            set { playableCards = value; }
        }


        protected virtual void OnStatusChaged()
        {
            StatusChanged?.Invoke(this, EventArgs.Empty);
        }


        public Statuses Status
        {
            get { return status; }
            set
            {
                status = value;
                firstTurn = true;
                OnStatusChaged();
            }
        }
        public Hand Hand
        {
            get
            {
                return myHand;
            }
            set
            {
                myHand = value;
            }
        }

        public Player()
        {
            Hand = new Hand();
            PlayableCards = new Hand();
        }

        public void DrawToSix(Deck deck)
        {
            int currentHandSize = (Hand.Count);
            for (int j = 0; j < (6 - currentHandSize); j++)
            {
                Hand.DrawCard(deck);
            }
        }

        public void UpdatePlayableCards(Game game)
        {
            playableCards.Clear();

            if(status == Statuses.Attacking && firstTurn)
            {
                for(int i = 0; i < Hand.Count; i++)
                {
                    playableCards.Add(Hand[i]);
                }
            }
            else if(status == Statuses.Attacking && firstTurn == false)
            {
                for (int i = 0; i < Hand.Count; i++)
                {
                    if(game.River.Ranks.Contains(Hand[i].Rank))
                    {
                        playableCards.Add(Hand[i]);
                    }
                }
            }
            else if(status == Statuses.Defending)
            {
                for (int i = 0; i < Hand.Count; i++)
                {
                    if(game.River.Count > 0)
                    {
                        if (Hand[i].Suit == game.trumpSuit ||
                            ((Hand[i].Rank == game.River[game.River.Count - 1].Rank) && firstTurn == true) ||
                            ((Hand[i].Suit == game.River[game.River.Count - 1].Suit) && Hand[i] > game.River[game.River.Count - 1]))
                        {
                            playableCards.Add(Hand[i]);
                        }
                    }
                }
            }
        }

        public void Play(PlayingCard card, River river)
        {
            int indexToAdd = this.Hand.IndexOf(card);
            river.Add(this.Hand[indexToAdd]);
            this.Hand.RemoveAt(indexToAdd);
        }

        public virtual void Attack(Game game)
        {

        }

        public virtual void Defend(Game game)
        {

        }

        public void Take(Game game)
        {
            if(game.Players[0].Status != Statuses.Won && game.Players[1].Status != Statuses.Won)
            {
                for (int i = 0; i < game.River.Count; i++)
                {
                    this.Hand.Add(game.River[i]);
                }
                game.EndTurn();
            }
        }

        public void Pass(Game game)
        {
                game.River.Clear();
                game.SwapTurns();
                game.EndTurn();
            }
        }
    }
