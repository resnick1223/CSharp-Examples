using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class 寶可夢 : IComparable
    {
        protected int cp;

        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }

        public virtual int Cp
        {
            get => cp;
            set => cp = value;
        }

        public abstract void 攻擊(寶可夢 另一隻);

        public override string ToString()
        {
            return string.Format("CP: {0}", Cp);
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}