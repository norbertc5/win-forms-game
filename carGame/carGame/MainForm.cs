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
			///this.Controls.Add(roadObjects[0]);
			roadObjects[1] = new RoadScrolling();
			//this.Controls.Add(roadObjects[1]);
			//this.Controls.Add(roadObjects[0]);
			roadObjects[0].position = new Point(0, 0);
			//this.Controls.Add();
		}

        private void Timer_Tick(object sender, EventArgs e)
        {
			roadObjects[0].MakeScroll(pictureBox1);
			roadObjects[1].MakeScroll(pictureBox2);
		}

		public void AddToControl(PictureBox obj)
        {
			this.Controls.Add(obj);
		}
    }
}
