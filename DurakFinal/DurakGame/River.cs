using JeremyCards;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame
{
    public class River : ObservableCollection<PlayingCard>
    {
        public new void Add(PlayingCard card)
        {
            bool rankExists = false;
            for(int i = 0; i < this.Count; i++)
            {
                if(this[i].Rank == card.Rank)
                {
                    rankExists = true;
                }
            }
            if(!rankExists)
            {
                ranks.Add(card.Rank);
            }
            base.Add(card);
        }

        private List<CardRank> ranks = new List<CardRank>();

        public List<CardRank> Ranks
        {
            get { return ranks; }
            set { ranks = value; }
        }

        public void Drain(Player player)
        {

        }

    }
}
