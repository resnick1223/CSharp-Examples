using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGoRunWinForm
{
    public partial class MainWindow : Form
    {
        public string 寶可夢名字;
        public int 寶可夢CP;
        public int 寶可夢目前HP;
        public int 寶可夢最大HP;
        public float 寶可夢身高;
        public float 寶可夢體重;
        public int 寶可夢進化需要的星星沙子;
        public int 寶可夢進化需要的糖果;
        public int 玩家擁有的星星沙子;
        public int 玩家擁有的寶可夢糖果;
        public bool 可否進化;


        public MainWindow()
        {
            // 建立視窗 初始化視窗元件
            InitializeComponent();

            // 初始化寶可夢的數據
            初始化寶可夢();

            // 繪製寶可夢相關視窗元件
            繪製畫面();
        }

        public void 初始化寶可夢()
        {
            寶可夢名字 = "火焰鳥";
            寶可夢CP = 1860;
            寶可夢目前HP = 114;
            寶可夢最大HP = 114;
            寶可夢身高 = 1.18f;
            寶可夢體重 = 30.87f;
            寶可夢進化需要的星星沙子 = 2500;
            寶可夢進化需要的糖果 = 2;
            玩家擁有的星星沙子 = 277396;
            玩家擁有的寶可夢糖果 = 3;
            可否進化 = 玩家擁有的星星沙子 >= 寶可夢進化需要的星星沙子
                    && 玩家擁有的寶可夢糖果 >= 寶可夢進化需要的糖果;
        }

        public void 繪製畫面()
        {
            寶可夢CP標籤.Text = string.Format("CP {0}", 寶可夢CP);
            寶可夢名字標籤.Text = 寶可夢名字;
            寶可夢HP標籤.Text = string.Format("HP {0}/{1}", 寶可夢目前HP, 寶可夢最大HP);
            玩家的星星沙子標籤.Text = 玩家擁有的星星沙子.ToString();
            玩家的糖果標籤.Text = 玩家擁有的寶可夢糖果.ToString();
            強化按鈕.Enabled = 可否進化;
        }

        private void 強化按鈕_Click(object sender, EventArgs e)
        {
            // 把該扣的扣掉
            玩家擁有的寶可夢糖果 -= 寶可夢進化需要的糖果;
            玩家擁有的星星沙子 -= 寶可夢進化需要的星星沙子;
            可否進化 = 玩家擁有的星星沙子 >= 寶可夢進化需要的星星沙子
                   && 玩家擁有的寶可夢糖果 >= 寶可夢進化需要的糖果;
            // 然後畫面的數字總要改吧
            繪製畫面();
        }
    }
}
