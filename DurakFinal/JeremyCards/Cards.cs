using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeremyCards
{
   public class Cards : ObservableCollection<PlayingCard>, ICloneable
   {
      /// <summary>
      /// Utility method for copying card instances into another Cards
      /// instance—used in Deck.Shuffle(). This implementation assumes that
      /// source and target collections are the same size.
      /// </summary>
      public void CopyTo(Cards targetCards)
      {
         for (int index = 0; index < this.Count; index++)
         {
            targetCards[index] = this[index];
         }
      }

      public object Clone()
      {
         Cards newCards = new Cards();
         foreach (PlayingCard sourceCard in this)
         {
            newCards.Add((PlayingCard)sourceCard.Clone());
         }
         return newCards;
      }
   }
}
