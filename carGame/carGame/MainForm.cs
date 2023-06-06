using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace carGame
{
	public partial class MainForm : Form
	{
		RoadScrolling[] roadObjects = new RoadScrolling[2];
		//RoadScrolling r = new RoadScrolling();
		//RoadScrolling r2 = new RoadScrolling();

		public MainForm()
		{
			InitializeComponent();
			roadObjects[0] = new RoadScrolling();
			roadObjects[1] = new RoadScrolling();
			this.Controls.Add(roadObjects[0].roadPicture);
			this.Controls.Add(roadObjects[1].roadPicture);
			roadObjects[0].roadPicture.Location = new Point(0, 0);
			roadObjects[1].roadPicture.Location = new Point(0, -680);
			roadObjects[0].position = roadObjects[0].roadPicture.Location;
			roadObjects[1].position = roadObjects[1].roadPicture.Location;

			// car is transparent
			roadObjects[0].roadPicture.Controls.Add(pictureBox1);
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.BackColor = Color.Transparent;
		}

        private void Timer_Tick(object sender, EventArgs e)
        {
			roadObjects[0].MakeScroll();
			roadObjects[1].MakeScroll();
		}

		public void AddToControl(PictureBox obj)
        {
			this.Controls.Add(obj);
		}
    }
}
