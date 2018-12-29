using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    public class BallStatus : EventArgs
    {
        public double X { get; set; }
        public double Y { get; set; }

        public bool IsHitted { get; set; }

        public bool IsHomeRun
        {
            get
            {
                return Math.Abs(X) >= 88.4 && Y >= 88.4;
            }
        }

        public override string ToString()
        {
            return string.Format("\n{0}外野 X方向{1}公尺, Y方向{2}公尺\n"
                , X < 0 ? "左" : "右", Math.Abs(X), Y);
        }
    }
}