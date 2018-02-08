using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGameEngine
{
    public class Pokemon
    {
        public int nationalNo;
        public string name;
        public Position pos;
        public double theta;
        public int maxHp;
        protected int currentHp;

        public int CurrentHp
        {
            get
            {
                return this.currentHp;
            }

            set
            {
                this.currentHp = value < 0 ? 0 : value;
            }
        }

        public Pokemon()
        {
            this.pos = new Position();
            this.theta = 0.0;
            this.name = "妙蛙種子";
            this.nationalNo = 1;
        }

        public void TurnRight(double theta)
        {
            this.theta += theta;
        }

        public void TurnLeft(double theta)
        {
            this.theta -= theta;
        }

        public void MoveForward(double distance)
        {
            this.pos.x += distance * Math.Cos(Math.PI * this.theta / 180.0);
            this.pos.y += distance * Math.Sin(Math.PI * this.theta / 180.0);
        }

        public string GetResourceNumber()
        {
            if (this.nationalNo < 10)
            {
                return "00" + this.nationalNo;
            }
            else if (this.nationalNo >= 10 && this.nationalNo < 100)
            {
                return "0" + this.nationalNo;
            }
            else
            {
                return this.nationalNo.ToString();
            }
        }

        public virtual void Attack(Pokemon other)
        {
            other.CurrentHp -= 10;
        }
    }
}