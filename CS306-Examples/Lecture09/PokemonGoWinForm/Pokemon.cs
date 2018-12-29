using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PokemonGoWinForm
{
    public class Pokemon : PictureBox
    {
        public int NationalId { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public event EventHandler PowerUp;
    }
}
