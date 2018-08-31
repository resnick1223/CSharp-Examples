using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballGame
{
    public class Pitcher
    {
        public void Say(object sender, EventArgs e)
        {
            MessageBox.Show("阿，被擊中了");
        }

        public void SayOther(object sender, EventArgs e)
        {
            MessageBox.Show("可惡阿");
            BallStatus status = e as BallStatus;
            if (status.IsHomeRun)
                MessageBox.Show("居然全壘打,我要被換下去了");
        }
    }
}