using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempoMusic
{
    public class Player
    {
        public int score;
        public int hp;
        public int position;
        PictureBox box = new PictureBox();

        public Player(GameForm form, Point position)
        {
            this.position = position.X;
            box.Load("Images//Pig2.png");
            box.SizeMode = PictureBoxSizeMode.AutoSize;
            box.Location = position;
            form.Controls.Add(box);

        }

        // 能夠原地跳躍
    }
}
