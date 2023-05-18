using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace carGame
{
    class RoadScrolling : Form
    {
        public Point position;
        int scrollSpeed = 10;

        public RoadScrolling()
        {
            position.Y = -500;
            PictureBox roadPicture = new PictureBox();
            roadPicture.Image = Properties.Resources.road1;
            roadPicture.Size = new Size(500, 630);
            //MainForm m = new MainForm();
            //m.AddToControl(roadPicture);
        }

        public void MakeScroll(PictureBox pic)
        {
            position.Y += 1 * scrollSpeed;
            pic.Location = position;
            if (position.Y > 490)
                position.Y = -500;
        }
    }
}
