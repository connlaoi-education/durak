using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeremyCards;

namespace DurakGame
{

    public class Hand : ObservableCollection<PlayingCard>
    {

        public void DrawCard(Deck deck)
        {
            if(deck.Cards.Count > 0)
            {
                deck.Cards[0].FaceUp = true;
                this.Add(deck.GetCard(0));
            }
        }
    }
}
