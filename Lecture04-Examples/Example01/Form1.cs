using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private Scene currentScene;

        public Form1()
        {
            InitializeComponent();
            this.currentScene = new Scene(this.scenePictureBox);
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(1);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(2);
        }

        private void MakeDecision(int decision)
        {
            switch (this.currentScene.Number)
            {
                case 1:
                    this.currentScene.ChangeTo(2);
                    break;

                case 2:
                    if (decision == 1)
                        this.currentScene.ChangeTo(8);
                    else
                        this.currentScene.ChangeTo(3);
                    break;

                case 3:
                    if (decision == 1)
                    {
                        this.currentScene.ChangeTo(4);
                        MessageBox.Show("GG惹");
                    }
                    else
                        this.currentScene.ChangeTo(5);
                    break;

                case 4:

                    break;

                case 5:
                    if (decision == 1)
                        this.currentScene.ChangeTo(8);
                    else
                        this.currentScene.ChangeTo(3);
                    break;

                case 6:
                    if (decision == 1)
                        this.currentScene.ChangeTo(8);
                    else
                        this.currentScene.ChangeTo(3);
                    break;
            }
        }
    }
}