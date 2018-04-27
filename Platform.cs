using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempoMusic
{
    public class Platform : GameObject
    {
        int addScore;
        public override void collide(Player player)
        {
            player.score += addScore;
        }

        public Platform(int addScore, int position, GameForm form) : base("Images//plate.png", position, form)
        {
            this.addScore = addScore;
        }

    }
}
