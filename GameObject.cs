using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempoMusic
{
    public abstract class GameObject
    {
        public PictureBox box = new PictureBox();
        public abstract void collide(Player player);
        public int position;
        public GameForm form;

        Point location;

        // 載入圖片
        public GameObject(string imageSource, int position,GameForm form)
        {
            box.Load(imageSource);
            box.SizeMode = PictureBoxSizeMode.AutoSize;
            this.position = position;
            this.form = form;
            form.Controls.Add(box);
        }
    }
}
