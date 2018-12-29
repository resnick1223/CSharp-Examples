using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public enum AttackType
    {
        BACE, FIRST, SECOND, FINAL
    }

    public enum DefenseType
    {
        BACE, FIRST, SECOND, FINAL
    }

    public class Player
    {
        private int charactwalk = 2;
        private int walkType = 2;
        public int HP;
        private int currentHP;
        public AttackType attackType = new AttackType();
        public DefenseType defenseType = new DefenseType();
        public List<string> PropsName = new List<string>();

        public Player()
        {
            HP = 50;
            currentHP = 50;
            attackType = AttackType.BACE;
            defenseType = DefenseType.BACE;
        }

        public int CurrentHP
        {
            get
            {
                return currentHP;
            }

            set
            {
                this.currentHP = value < 0 ? 0 : value;
            }
        }

        #region 定義玩家走路

        public string playerWalk()
        {
            switch (charactwalk)
            {
                case 1:
                    charactwalk = 2;
                    walkType = 1;
                    break;

                case 2:
                    charactwalk = 3;
                    walkType = 2;
                    break;

                case 3:
                    charactwalk = 4;
                    walkType = 1;
                    break;

                case 4:
                    charactwalk = 1;
                    walkType = 3;
                    break;

                default:
                    charactwalk = 2;
                    walkType = 2;
                    break;
            }
            return walkType.ToString();
        }

        #endregion 定義玩家走路

        public virtual void Attack(Pokemon pokemon)
        {
            if (this.attackType == AttackType.BACE)
                pokemon.CurrentHP -= 7;
            else if (this.attackType == AttackType.FIRST)
                pokemon.CurrentHP -= 9;
            else if (this.attackType == AttackType.SECOND)
                pokemon.CurrentHP -= 15;
            else if (this.attackType == AttackType.FINAL)
                pokemon.CurrentHP -= 20;
        }
    }
}