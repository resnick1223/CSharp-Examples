using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballGame
{
    public partial class Game : Form
    {
        private Ball ball;
        private Pitcher pitcher;
        private Umpire umpire;
        private GameStatus status;
        private Random random;
        public GameStatusHandler outEvent;

        public Game()
        {
            InitializeComponent();
            ball = new Ball();
            status = new GameStatus();
            pitcher = new Pitcher();
            umpire = new Umpire();
            random = new Random();
            ball.BallInPlay += pitcher.Say;
            ball.BallInPlay += pitcher.SayOther;
            ball.BallInPlay += this.UpdateResults;
            outEvent += umpire.Say;
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            ball.ChangeStatus(random);
            // 觸發打中(BallInPlay)的條件
            if (ball.Status.IsHitted)
            {
                status.Strikes = 0;
                resultsRichTextBox.Text += string.Format("下一位打者上場\n");
            }
            else
            {
                status.Strikes++;

                resultsRichTextBox.Text += string.Format("{0}好球\n", status.Strikes);
                if (status.Strikes == 3)
                {
                    outEvent(status, ball.Status);
                    resultsRichTextBox.Text += string.Format("三振出局\n");
                    status.Strikes = 0;
                    status.Outs++;
                    resultsRichTextBox.Text += string.Format("{0}出局\n", status.Outs);
                }
            }
        }

        private void UpdateResults(object sender, EventArgs e)
        {
            BallStatus ballInPlayEventArgs = e as BallStatus;
            if (ballInPlayEventArgs.IsHomeRun)
            {
                resultsRichTextBox.Text += string.Format("打擊出去了，是全壘打\n");
            }
            else
            {
                resultsRichTextBox.Text += string.Format("打擊出去了，落點是{0}\n", ballInPlayEventArgs.ToString());
            }
        }
    }
}