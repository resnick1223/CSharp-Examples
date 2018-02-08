using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01_NestedForLoop
{
    public partial class Form1 : Form
    {
        // 宣告需要的變數
        private int pokemonCount = 7;

        // 一排有幾個
        private int numberOfColumn = 3;

        // 水平的接縫
        private int gutterX = 15;

        // 垂直的接縫
        private int gutterY = 20;

        // 一個picturebox的寬度
        private int width = 150;

        // 一個picturebox的高度
        private int height = 150;

        // 第一個picturebox 左上角的x
        private int startX = 115;

        // 第一個picturebox 左上角的y
        private int startY = 115;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Render();
        }

        private void CreatePokemonBox(int pokemonId, string name, int width, int height, int x, int y)
        {
            // 根據參數 建立一個pictureBox物件
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("001");
            pictureBox.Location = new Point(x, y);
            pictureBox.Name = name;
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = pokemonId;
            pictureBox.TabStop = false;
            // 所有控制項 加入 這個 pictureBox
            this.Controls.Add(pictureBox);
        }

        private void Render()
        {
            numberOfColumn = (ClientSize.Width - startX) / (width + gutterX);
            numberOfColumn = numberOfColumn == 0 ? 1 : numberOfColumn;
            for (int pokemonId = 0; pokemonId < pokemonCount; pokemonId++)
            {
                int row = pokemonId / numberOfColumn;
                int col = pokemonId % numberOfColumn;
                int x = startX + col * (width + gutterX);
                int y = startY + row * (height + gutterY);
                CreatePokemonBox(pokemonId, "超夢", width, height, x, y);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // this.Controls.Clear();
            Render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}