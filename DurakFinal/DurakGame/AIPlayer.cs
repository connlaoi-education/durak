using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakGame
{
    class AIPlayer : Player
    {
        public override void Attack(Game game)
        {
            if(PlayableCards.Count > 0)
            {
                this.Play(this.PlayableCards[0], game.River);
                this.firstTurn = false;
            }
            else
            {
                this.Pass(game);
            }
        }

        public override void Defend(Game game)
        {
            if (PlayableCards.Count > 0)
            {
                if(PlayableCards[0].Rank == game.River[0].Rank && this.firstTurn)
                {
                    game.Transfer();
                    MessageBox.Show("Your Opponent Transferred! You are now defending.", "Transfer Warning");
                }
                this.Play(this.PlayableCards[0], game.River);
                this.firstTurn = false;
            }
            else
            {
                Take(game);
            }
        }
    }
}
