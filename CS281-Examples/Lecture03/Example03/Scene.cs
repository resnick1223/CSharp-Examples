using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Example03
{
    public class Scene
    {
        #region 建構式: 用來初始化場景

        public Scene(int id, Button yesButton, Button noButton, PictureBox pictureBox)
        {
            this.Id = id;
            this.YesButton = yesButton;
            this.NoButton = noButton;
            this.ScenePictureBox = pictureBox;
            this.Render();
        }

        #endregion 建構式: 用來初始化場景

        #region Scene的欄位定義

        public int Id;
        public Button YesButton;
        public Button NoButton;
        public PictureBox ScenePictureBox;

        #endregion Scene的欄位定義

        #region Scene的公用方法

        public Image GetImage()
        {
            if (this.Id == 1)
            {
                return global::Example03.Properties.Resources._1;
            }
            else if (this.Id == 2)
            {
                return global::Example03.Properties.Resources._2;
            }
            else if (this.Id == 3)
            {
                return global::Example03.Properties.Resources._3;
            }
            else if (this.Id == 4)
            {
                return global::Example03.Properties.Resources._4;
            }
            else if (this.Id == 5)
            {
                return global::Example03.Properties.Resources._5;
            }
            else if (this.Id == 6)
            {
                return global::Example03.Properties.Resources._6;
            }
            else if (this.Id == 7)
            {
                return global::Example03.Properties.Resources._7;
            }
            else if (this.Id == 8)
            {
                return global::Example03.Properties.Resources._8;
            }
            else if (this.Id == 9)
            {
                return global::Example03.Properties.Resources._9;
            }
            else
            {
                return global::Example03.Properties.Resources._10;
            }
        }

        public void ChangeTo(int id)
        {
            this.Id = id;
            this.Render();
        }

        public void Render()
        {
            if (this.Id == 1)
            {
                YesButton.Text = "按下乾啦來了解";
                NoButton.Hide();
            }
            else if (this.Id == 4 || this.Id == 6 || this.Id == 7 || this.Id == 10)
            {
                YesButton.Text = "重新開始";
                NoButton.Hide();
            }
            else if (this.Id == 9)
            {
                YesButton.Text = "(1)";
                NoButton.Hide();
            }
            else
            {
                YesButton.Text = "(1)";
                NoButton.Text = "(2)";
                YesButton.Show();
                NoButton.Show();
            }

            this.ScenePictureBox.Image = this.GetImage();
        }

        #endregion Scene的公用方法
    }
}