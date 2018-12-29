using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonRun;

namespace PokemonRunWinForm
{
    public partial class 寶可夢區塊 : UserControl
    {
        public 寶可夢區塊()
        {
            InitializeComponent();
        }

        public void 繪製畫面(寶可夢 某一隻寶可夢)
        {
            血量標籤.Text = string.Format("HP {0}/{1}"
                , 某一隻寶可夢.血量,某一隻寶可夢.滿血量);

            寶可夢圖像.Image = (Image)Properties.Resources.ResourceManager.GetObject(某一隻寶可夢.圖片名稱);
        }
    }
}
