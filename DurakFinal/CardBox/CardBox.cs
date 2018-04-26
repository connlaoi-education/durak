/**
 * CardBox.cs - The CardBox Class
 * 
 * 
 * @author  Jeremy Power
 * @version 1.0
 * @since   3/23/2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JeremyCards;

namespace CardBox
{
    /// <summary>
    /// A control to use in a Windows Forms Application that displays a card.
    /// </summary>
    public partial class CardBox: UserControl
    {
        #region FIELDS AND PROPERTIES

        /// <summary>
        /// Card Property: sets/gets the underlying Card object.
        /// </summary>
        private PlayingCard myCard;
        public PlayingCard Card
        {
            set
            {
                myCard = value;
                UpdateCardImage();
            }
            get { return myCard; }
        }

        public CardSuit Suit
        {
            set
            {
                Card.Suit = value;
                UpdateCardImage();
            }
            get { return Card.Suit; }
        }

        public CardRank Rank
        {
            set
            {
                Card.Rank = value;
                UpdateCardImage();
            }
            get { return Card.Rank; }
        }

        public bool FaceUp
        {
            set
            {
                if(myCard.FaceUp != value)
                {
                    myCard.FaceUp = value;

                    UpdateCardImage();

                    if (CardFlipped != null)
                        CardFlipped(this, new EventArgs());
                }
            }
            get { return Card.FaceUp; }
        }

        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            {
                if(myOrientation != value)
                {
                    myOrientation = value;
                    this.Size = new Size(Size.Height, Size.Width);
                    // update the card image
                    UpdateCardImage();
                    
                }
            }
            get { return myOrientation; }
        }

        private void UpdateCardImage()
        {
            pbMyPictureBox.Image = myCard.GetCardImage();

            if(myOrientation == Orientation.Horizontal)
            {
                pbMyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Constructor (Default): Constructors the control with a new card, oriented vertically
        /// </summary>
        public CardBox()
        {
            InitializeComponent();
            myOrientation = Orientation.Vertical;
            myCard = new PlayingCard();
        }

        /// <summary>
        /// Constructor (PlayingCard, Orientation): Constructs the control using parameters
        /// </summary>
        /// <param name="card">Underlying PlayingCard Object</param>
        /// <param name="orientation">Orientation enumeration, Vertical by default</param>
        public CardBox(PlayingCard card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();
            myOrientation = orientation;
            myCard = card;
        }

        #endregion

        #region EVENTS AND EVENT HANDLERS
        
        /// <summary>
        /// An event handler for the load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage();
        }

        /// <summary>
        /// An event the client program can handle when the card flips face down
        /// </summary>
        public event EventHandler CardFlipped;

        /// <summary>
        /// An event the client program can handle when the user clicks the control
        /// </summary>
        new public event EventHandler Click;

        /// <summary>
        /// An event handler for the user clicking the picturebox control
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMyPictureBox_Click(object sender, EventArgs e)
        {
            if(Click != null)
            {
                Click(this, e);
            }
        }

        #endregion

        #region OTHER METHODS

        public override string ToString()
        {
            return myCard.ToString();
        }

        #endregion

    }
}
