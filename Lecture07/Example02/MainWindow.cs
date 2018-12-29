using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animation2D;

namespace Example02
{
    public partial class MainWindow : Form
    {
        private Person elsa;
        private double distance;
        private double moveDistance;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize Person
            elsa = new Person()
            {
                name = "Elsa",
                position = new Position()
                {
                    x = personPictureBox.Location.X,
                    y = personPictureBox.Location.Y
                },
                theta = 0
            };
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(distanceTextBox.Text, out distance);
            if (!success)
            {
                MessageBox.Show("移動距離，輸入錯誤，請重新輸入");
                distanceTextBox.Text = string.Empty;
                distanceTextBox.Focus();
                return;
            }
            elsa.TurnRight(90);
            elsa.MoveForward(distance);
            animationTimer.Enabled = !animationTimer.Enabled;
            startButton.Text =
                animationTimer.Enabled ? "Pause" : "Start";
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            int x = personPictureBox.Location.X;
            int y = personPictureBox.Location.Y;
            int dx = (int)(10.0 * Math.Cos(elsa.theta * Math.PI / 180.0));
            int dy = (int)(10.0 * Math.Sin(elsa.theta * Math.PI / 180.0));
            startButton.Enabled = moveDistance >= distance;
            if (moveDistance + 10 <= distance)
            {
                moveDistance += 10;
                personPictureBox.Location = new Point(x + dx, y + dy);
            }
            else
            {
                distance = 0;
                moveDistance = 0;
                animationTimer.Enabled = false;
            }
        }
    }
}