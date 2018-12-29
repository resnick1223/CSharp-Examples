using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGoUI
{
    public partial class MainWindow : Form
    {
        private int startX = 10;
        private int startY = 10;
        private int boxWidth = 100;
        private int boxHeight = 100;
        private int gutter = 10;
        private int count = 10;
        private int numberOfRow = 3;

        public MainWindow()
        {
            InitializeComponent();
            Render();
        }

        #region 繪製視窗所有元件

        /// <summary>
        /// 用來繪製視窗元件
        /// </summary>

        private void Render()
        {
            numberOfRow = this.ClientSize.Width / (boxWidth + gutter);

            // 繪製PictureBox
            for (int index = 0; index < count; index++)
            {
                DrawPictureBox(index);
            }
        }

        #endregion 繪製視窗所有元件

        #region 視窗改變大小事件

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            numberOfRow = this.ClientSize.Width / (boxWidth + gutter);
            int index = 0;
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox pictureBox = control as PictureBox;
                    pictureBox.Location = GetPictureBoxLocation(index);
                    index++;
                }
            }
        }

        #endregion 視窗改變大小事件

        #region 計算PictureBox的位置

        private Point GetPictureBoxLocation(int index)
        {
            int row = index / numberOfRow;
            int col = index % numberOfRow;
            int x = startX + col * (boxWidth + gutter);
            int y = startY + row * (boxHeight + gutter);
            return new Point(x, y);
        }

        #endregion 計算PictureBox的位置

        #region 用編號繪製PictureBox

        private void DrawPictureBox(int index)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = GetPictureBoxLocation(index);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(boxWidth, boxHeight);
            pictureBox.Image = Properties.Resources._001;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(pictureBox);
        }

        #endregion 用編號繪製PictureBox
    }
}