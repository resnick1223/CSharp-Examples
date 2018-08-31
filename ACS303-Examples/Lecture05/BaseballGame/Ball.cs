using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    public class Ball
    {
        public event EventHandler BallInPlay;

        public BallStatus Status { get; set; }
        public string Name { get; set; }

        public void ChangeStatus(Random random)
        {
            Status = new BallStatus();
            Status.IsHitted = random.Next(3) == 0;
            if (Status.IsHitted)
            {
                Status.X = random.Next(-100, 100);
                Status.Y = random.Next(80, 100);
                this.BallInPlay(this, Status);
            }
        }
    }
}