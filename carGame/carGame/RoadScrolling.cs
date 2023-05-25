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
        public PictureBox roadPicture;
        const int START_Y_POS = -680;

        public RoadScrolling()
        {
            roadPicture = new PictureBox();
            roadPicture.Image = Properties.Resources.road;
            roadPicture.Size = new Size(500, 690);
            //picBox = roadPicture;
        }

        public void MakeScroll()
        {
            position.Y += 1 * scrollSpeed;

            // road picuture return to first positon when beyond window
            roadPicture.Location = position;
            if (position.Y > 680)
                position.Y = START_Y_POS;
        }
    }
}
