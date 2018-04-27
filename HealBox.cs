using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempoMusic
{
    public class HealBox : GameObject
    {
        public int hp;

        public override void collide(Player player)
        {
            player.hp += hp;
        }

        public HealBox(int hp, int position, GameForm form) : base("Images//plate.png", position, form)
        {
            this.hp = hp;
        }
    }
}
