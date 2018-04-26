using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace JeremyCards
{
    public class PlayingCard : ICloneable,
                               IComparable
    {
        #region FIELDS AND PROPERTIES

        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = true;

        /// <summary>
        /// Trump mySuit to use if useTrumps is true.
        /// </summary>
        public static CardSuit trump = CardSuit.Clubs;

        /// <summary>
        /// Suit Property
        /// Used to set or get the PlayingCard Suit
        /// </summary>
        protected CardSuit mySuit;
        public CardSuit Suit
        {
            get { return mySuit; } // return the mySuit
            set { mySuit = value;  } // set the mySuit
        }

        /// <summary>
        /// CardRank Property
        /// Used to set or get the PlayingCard Rank
        /// </summary>
        protected CardRank myRank;
        public CardRank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }

        /// <summary>
        /// CardValue Property
        /// Used to set or get the PlayingCard Value
        /// </summary>
        protected int myValue;
        public int CardValue
        {
            get { return myValue; }
            set { myValue = value; }
        }

        /// <summary>
        /// Alternate Value Property
        /// Used to set or get an alternate value for certain games. Set to null by default.
        /// </summary>
        protected int? altValue = null; // nullable type
        public int? AlternateValue
        {
            get { return altValue; }
            set { altValue = value; }
        }

        /// <summary>
        /// FaceUp Property
        /// Used to set or get whether the PlayingCard is face up.
        /// Set to false by default.
        /// </summary>
        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public PlayingCard(CardRank myRank = CardRank.Ace, CardSuit mySuit = CardSuit.Hearts)
        {
            //Set the myRank, mySuit
            this.myRank = myRank;
            this.mySuit = mySuit;
            // Set the default PlayingCard value
            this.myValue = (int)myRank;
        }

        #endregion

        #region PUBLIC METHODS

        /// <summary>
        /// CompareTo Method
        /// PlayingCard-specific comparison method used to sort PlayingCard instances
        /// </summary>
        /// <param name="ojb">The object this PlayingCard is being compared to</param>
        /// <returns>an integer that indicates whether this PlayingCard precedes, follows or occurs in the sequence</returns>
        public virtual int CompareTo(object obj)
        {
            // is the argument null?
            if (obj == null)
            {
                throw new ArgumentNullException("Unable to compare a PlayingCard to a null object.");
            }
            // convert the argument to a PlayingCard
            PlayingCard compareCard = obj as PlayingCard;
            // if the conversion worked
            if (compareCard != null)
            {
                //compare based on the value first, then mySuit
                int thisSort = this.myValue * 10 + (int)this.mySuit;
                int compareCardSort = compareCard.myValue * 10 + (int)compareCard.mySuit;
                return (thisSort.CompareTo(compareCardSort));
            }
            else
            {
                throw new ArgumentException("Object being compared cannot be converted to a PlayingCard.");
            }
        } //end of CompareTo

        /// <summary>
        /// Clone Method
        /// To support the ICloneable interface. Used for deep copying in PlayingCard collection classes.
        /// </summary>
        /// <returns>A copy of the PlayingCard as a System.Object</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// ToString: Overrides System.Object.ToString()
        /// </summary>
        /// <returns>The name of the PlayingCard as a string</returns>
        public override string ToString()
        {
            string cardString; // holds the playing PlayingCard name

            if(faceUp)
            {
                if(myRank == CardRank.Joker)
                {
                    // set the PlayingCard name string to {Red|Black} Joker
                    if (mySuit == CardSuit.Clubs || mySuit == CardSuit.Spades)
                    {
                        cardString = "Black Joker";
                    }
                    else
                    {
                        cardString = "Red Joker";
                    }
                }
                //otherwise PlayingCard is face up but not a joker
                else
                {
                    cardString = myRank.ToString() + " of " + mySuit.ToString();
                }
            }
            else
            {
                cardString = "Face Down";
            }
            return cardString;
        }

        /// <summary>
        /// Equals: Overrides System.Object.Equals()
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true if PlayingCard values are equal</returns>
        public override bool Equals(object obj)
        {
            PlayingCard card2 = (PlayingCard)obj;
            return (this.mySuit == card2.mySuit) && (this.myRank == card2.myRank);
        }

        /// <summary>
        /// GetHashCode: Overrides System.Object.GetHashCode()
        /// </summary>
        /// <returns>PlayingCard value * 100 + Suit number * 10 + 1 if face up</returns>
        public override int GetHashCode()
        {
            return this.myValue * 100 + (int)this.mySuit * 10 + ((this.faceUp) ? 1 : 0); ;
        }

        public Image GetCardImage()
        {
            string imageName;
            Image cardImage;

            if (!faceUp)
            {
                imageName = "back";
            }
            else if (myRank == CardRank.Joker)
            {
                if (mySuit == CardSuit.Clubs || mySuit == CardSuit.Spades)
                {
                    imageName = "black_joker";
                }
                else
                {
                    imageName = "red_joker";
                }
            }
            else
            {
                imageName = myRank.ToString().ToLower() + "_of_" + mySuit.ToString().ToLower();
            }
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

            return cardImage;
        }

        #endregion

        #region RELATIONAL OPERATORS

        public static bool operator ==(PlayingCard card1, PlayingCard card2)
        {
            return (card1.mySuit == card2.mySuit) && (card1.myRank == card2.myRank);
        }

        public static bool operator !=(PlayingCard card1, PlayingCard card2)
        {
            return !(card1 == card2);
        }


        public static bool operator >(PlayingCard card1, PlayingCard card2)
        {
            if (card1.mySuit == card2.mySuit)
            {
                return (card1.myRank > card2.myRank);
            }
            else
            {
                if (useTrumps && (card2.mySuit == PlayingCard.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <(PlayingCard card1, PlayingCard card2)
        {
            return !(card1 >= card2);
        }

        public static bool operator >=(PlayingCard card1, PlayingCard card2)
        {
            if (card1.mySuit == card2.mySuit)
            {
                return (card1.myRank >= card2.myRank);
            }
            else
            {
                if (useTrumps && (card2.mySuit == PlayingCard.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <=(PlayingCard card1, PlayingCard card2)
        {
            return !(card1 > card2);
        }
        #endregion
    }
}
