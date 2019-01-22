using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public class Pokemon : UserControl
    {
        public int NationalId { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
    }
}