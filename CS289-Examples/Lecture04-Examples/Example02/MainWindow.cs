using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code.Orz;

namespace Example02
{
    public partial class MainWindow : Form
    {
        private Person elsa;
        private double distance = 0;

        public MainWindow()
        {
            InitializeComponent();
            elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    X = pictureBox1.Location.X,
                    Y = pictureBox1.Location.Y
                },
                Theta = 0
            };
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            elsa.MoveForward(20);
            int x = (int)elsa.Pos.X;
            int y = (int)elsa.Pos.Y;
            this.pictureBox1.Location
                 = new System.Drawing.Point(x, y);
            distance += 20;
            if (distance > 0 && distance % 300 == 0)
                elsa.TurnRight(90);
        }
    }
}