using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeremyCards
{
   public class Deck : ICloneable
   {
      public event EventHandler LastCardDrawn;

        private Cards cards = new Cards();

      public Cards Cards
        {
            get { return cards; }
            set
            {
                cards = value;
            }
        }

      private int myDeckSize = 52;
    
      public Deck()
      {
            if(myDeckSize == 52)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 2; rankVal < 15; rankVal++)
                    {
                        Cards.Add(new PlayingCard((CardRank)rankVal, (CardSuit)suitVal));
                    }
                }
            }
            else if(myDeckSize == 36)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 6; rankVal < 15; rankVal++)
                    {
                        Cards.Add(new PlayingCard((CardRank)rankVal, (CardSuit)suitVal));
                    }
                }
            }
            else if(myDeckSize == 20)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 10; rankVal < 15; rankVal++)
                    {
                        Cards.Add(new PlayingCard((CardRank)rankVal, (CardSuit)suitVal));
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Deck Size");
            }
      }

      private Deck(Cards newCards)
      {
         Cards = newCards;
      }
    
      public Deck(int deckSize)
        {
            myDeckSize = deckSize;
            if (myDeckSize == 52)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 2; rankVal < 15; rankVal++)
                    {
                        Cards.Add(new PlayingCard((CardRank)rankVal, (CardSuit)suitVal));
                    }
                }
            }
            else if (myDeckSize == 36)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 6; rankVal < 15; rankVal++)
                    {
                        Cards.Add(new PlayingCard((CardRank)rankVal, (CardSuit)suitVal));
                    }
                }
            }
            else if (myDeckSize == 20)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 10; rankVal < 15; rankVal++)
                    {
                        Cards.Add(new PlayingCard((CardRank)rankVal, (CardSuit)suitVal));
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Deck Size");
            }
        }

        /// <summary>
        /// Nondefault constructor. Allows a trump CardSuit to be used.
        /// </summary>
        public Deck(bool useTrumps, CardSuit trump, int deckSize)
         : this(deckSize)
      {
         PlayingCard.useTrumps = useTrumps;
         PlayingCard.trump = trump;
            myDeckSize = deckSize;
      }

      public PlayingCard GetCard(int cardNum)
      {
         if (cardNum >= 0 && cardNum <= (myDeckSize - 1))
         {
            if ((cardNum == (myDeckSize - 1)) && (LastCardDrawn != null))
               LastCardDrawn(this, EventArgs.Empty);
                PlayingCard cardToDraw = Cards[cardNum];
                Cards.RemoveAt(cardNum);
            return cardToDraw;
         }
         else
            throw new CardOutOfRangeException(Cards.Clone() as Cards);
      }

      public void Shuffle()
      {
         Cards newDeck = new Cards();
         bool[] assigned = new bool[myDeckSize];
         Random sourceGen = new Random();
         for (int i = 0; i < myDeckSize; i++)
         {
            int sourceCard = 0;
            bool foundCard = false;
            while (foundCard == false)
            {
               sourceCard = sourceGen.Next(myDeckSize);
               if (assigned[sourceCard] == false)
                  foundCard = true;
            }
            assigned[sourceCard] = true;
            newDeck.Add(Cards[sourceCard]);
         }
         newDeck.CopyTo(Cards);
      }

      public object Clone()
      {
         Deck newDeck = new Deck(Cards.Clone() as Cards);
         return newDeck;
      }

      public int getDeckSize()
        {
            return Cards.Count;
        }
   }
}
