using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameRunLibrary;

namespace GameRun
{
    public partial class 開寶 : Form
    {
        private Random random = new Random();
        private PlayerOne player = new PlayerOne();
        private string PropsName;

        public 開寶()
        {
            InitializeComponent();
            treasureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("Box1");
            PropsBox.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            treasureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("Box2");
            PropsName = Render();
            PropsBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(PropsName);
            PropsBox.Visible = true;
            if (PropsName.Equals("Attack1"))
            {
                player.attackType = AttackType.FIRST;
            }
            else if (PropsName.Equals("Attack2"))
            {
                player.attackType = AttackType.SECOND;
            }
            else if (PropsName.Equals("Attack3"))
            {
                player.attackType = AttackType.FINAL;
            }
            else if (PropsName.Equals("Defence1"))
            {
                player.defenseType = DefenseType.FIRST;
            }
            else if (PropsName.Equals("Defence2"))
            {
                player.defenseType = DefenseType.SECOND;
            }
            else if (PropsName.Equals("Defence3"))
            {
                player.defenseType = DefenseType.FINAL;
            }
            else if (PropsName.Equals("heart"))
            {
                player.HP += 10;
                player.CurrentHP = player.HP;
            }
        }

        public string Render()
        {
            int TypeNumber = random.Next(1, 5);
            int LevelNumber = random.Next(1, 4);
            string Type = "nothing";
            string Level = null;
            switch (TypeNumber)
            {
                case 1:
                    Type = "Attack";
                    break;

                case 2:
                    Type = "Defence";
                    break;

                case 3:
                    Type = "heart";
                    break;

                case 4:
                    Type = "nothing";
                    break;

                default:
                    Type = "heart";
                    break;
            }
            if (!Type.Equals("nothing") && !Type.Equals("heart"))
            {
                switch (LevelNumber)
                {
                    case 1:
                        Level = "1";
                        break;

                    case 2:
                        Level = "2";
                        break;

                    case 3:
                        Level = "3";
                        break;

                    default:
                        Type = "1";
                        break;
                }
            }

            return Type + Level;
        }

        private void PropsBox_Click(object sender, EventArgs e)
        {
            player.PropsName.Add(PropsName);

            PropsBox.Visible = false;
            BattleScreen battle = new BattleScreen();
            battle.Show(player);
            battle.Show();
        }
    }
}