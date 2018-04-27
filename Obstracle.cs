using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempoMusic
{
    class Obstracle : GameObject
    {
        public int damage;
        public int reduceScore;
        public override void collide(Player player)
        {
            player.hp -= damage;
            player.score -= reduceScore;
        }

        public Obstracle(int damage, int reduceScore,int position, GameForm form) : base("Images//plate.png", position, form)
        {
            this.damage = reduceScore;
            this.reduceScore = reduceScore;
        }
    }
}
