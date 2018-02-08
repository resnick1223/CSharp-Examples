using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class MainWindow : Form
    {
        // 定義一個變數儲存 現在的場景
        private Scene currentScene;

        public MainWindow()
        {
            InitializeComponent();
            this.currentScene = new Scene(1, this.yesButton, this.noButton, this.scenePictureBox);
        }

        private void MakeDecision(int decision)
        {
            switch (currentScene.Id)
            {
                case 1:
                    currentScene.ChangeTo(2);
                    break;

                case 2:
                    if (decision == 1)
                        currentScene.ChangeTo(8);
                    else
                        currentScene.ChangeTo(3);
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;
            }

            if (currentScene.Id == 1)
            {
                currentScene.ChangeTo(2);
            }
            else if (currentScene.Id == 2)
            {
                if (decision == 1)
                    currentScene.ChangeTo(8);
                else
                    currentScene.ChangeTo(3);
            }
            else if (currentScene.Id == 3)
            {
                if (decision == 1)
                    currentScene.ChangeTo(4);
                else
                    currentScene.ChangeTo(5);
            }
            else if (currentScene.Id == 4)
            {
                currentScene.ChangeTo(1);
            }
            else if (currentScene.Id == 5)
            {
                if (decision == 1)
                    currentScene.ChangeTo(6);
                else
                    currentScene.ChangeTo(7);
            }
            else if (currentScene.Id == 6)
            {
                currentScene.ChangeTo(1);
            }
            else if (currentScene.Id == 7)
            {
                currentScene.ChangeTo(1);
            }
            else if (currentScene.Id == 8)
            {
                if (decision == 1)
                    currentScene.ChangeTo(9);
                else
                    currentScene.ChangeTo(10);
            }
            else if (currentScene.Id == 9)
            {
                currentScene.ChangeTo(3);
            }
            else if (currentScene.Id == 10)
            {
                currentScene.ChangeTo(1);
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(1);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(2);
        }
    }
}