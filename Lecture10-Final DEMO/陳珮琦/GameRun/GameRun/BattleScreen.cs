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
    public partial class BattleScreen : Form
    {
        private Pokemon pokemon;

        private Player player = new PlayerOne();

        internal void Show(PlayerOne player)
        {
            this.player = player;
        }

        public BattleScreen()
        {
            InitializeComponent();
            this.Render();
            this.playerHpLabel.Text = "HP: " + player.CurrentHP + "/" + player.HP;
            FirstorderAttack.Visible = false;
            SecondorderAttack.Visible = false;
            FinalorderAttack.Visible = false;
        }

        public void Render()
        {
            Pokemon pokemon = PokemonFactory.Generate();
            this.pokemon = pokemon;
            this.PokemonBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(pokemon.ImageFileName);
            this.pokemonHpLabel.Text = "HP: " + pokemon.CurrentHP.ToString() + "/" + pokemon.HP;
        }

        private void baceAttack_Click(object sender, EventArgs e)
        {
            player.Attack(pokemon);
            pokemon.CurrentHP -= 2;
            this.pokemonHpLabel.Text = "HP: " + pokemon.CurrentHP + "/" + pokemon.HP;
            pokemon.Attack(player);
            this.playerHpLabel.Text = "HP: " + player.CurrentHP.ToString() + "/" + player.HP;
            if (player.attackType == AttackType.BACE)
            {
                FirstorderAttack.Visible = false;
                SecondorderAttack.Visible = false;
                FinalorderAttack.Visible = false;
            }
            else if (player.attackType == AttackType.FIRST)
            {
                FirstorderAttack.Visible = true;
                SecondorderAttack.Visible = false;
                FinalorderAttack.Visible = false;
            }
            else if (player.attackType == AttackType.SECOND)
            {
                FirstorderAttack.Visible = true;
                SecondorderAttack.Visible = true;
                FinalorderAttack.Visible = false;
            }
            if (pokemon.CurrentHP <= 0 || player.CurrentHP <= 0)
            {
                if (player.CurrentHP > pokemon.CurrentHP)
                    MessageBox.Show("恭喜你戰勝" + pokemon.Name);
                else
                    MessageBox.Show("很可惜，挑戰失敗");
            }
        }

        private void FirstorderAttack_Click(object sender, EventArgs e)
        {
            player.Attack(pokemon);
            pokemon.CurrentHP -= 5;
            this.pokemonHpLabel.Text = "HP: " + pokemon.CurrentHP + "/" + pokemon.HP;
            pokemon.Attack(player);
            this.playerHpLabel.Text = "HP: " + player.CurrentHP.ToString() + "/" + player.HP;
            if (player.attackType == AttackType.BACE)
            {
                FirstorderAttack.Visible = false;
                SecondorderAttack.Visible = false;
                FinalorderAttack.Visible = false;
            }
            else if (player.attackType == AttackType.FIRST)
            {
                FirstorderAttack.Visible = true;
                SecondorderAttack.Visible = false;
                FinalorderAttack.Visible = false;
            }
            else if (player.attackType == AttackType.SECOND)
            {
                FirstorderAttack.Visible = true;
                SecondorderAttack.Visible = true;
                FinalorderAttack.Visible = false;
            }
            if (pokemon.CurrentHP <= 0 || player.CurrentHP <= 0)
            {
                if (player.CurrentHP > pokemon.CurrentHP)
                {
                    MessageBox.Show("恭喜你戰勝" + pokemon.Name);
                }
                else
                {
                    MessageBox.Show("很可惜，挑戰失敗");
                }
            }
        }

        private void SecondorderAttack_Click(object sender, EventArgs e)
        {
            player.Attack(pokemon);
            pokemon.CurrentHP -= 7;
            this.pokemonHpLabel.Text = "HP: " + pokemon.CurrentHP + "/" + pokemon.HP;
            pokemon.Attack(player);
            this.playerHpLabel.Text = "HP: " + player.CurrentHP.ToString() + "/" + player.HP;
            if (player.attackType == AttackType.BACE)
            {
                FirstorderAttack.Visible = false;
                SecondorderAttack.Visible = false;
                FinalorderAttack.Visible = false;
            }
            else if (player.attackType == AttackType.FIRST)
            {
                FirstorderAttack.Visible = true;
                SecondorderAttack.Visible = false;
                FinalorderAttack.Visible = false;
            }
            else if (player.attackType == AttackType.SECOND)
            {
                FirstorderAttack.Visible = true;
                SecondorderAttack.Visible = true;
                FinalorderAttack.Visible = false;
            }
            if (pokemon.CurrentHP <= 0 || player.CurrentHP <= 0)
            {
                if (player.CurrentHP > pokemon.CurrentHP)
                    MessageBox.Show("恭喜你戰勝" + pokemon.Name);
                else
                    MessageBox.Show("很可惜，挑戰失敗");
            }
        }

        private void FinalorderAttack_Click(object sender, EventArgs e)
        {
            player.Attack(pokemon);
            pokemon.CurrentHP -= 10;
            this.pokemonHpLabel.Text = "HP: " + pokemon.CurrentHP + "/" + pokemon.HP;
            pokemon.Attack(player);
            this.playerHpLabel.Text = "HP: " + player.CurrentHP.ToString() + "/" + player.HP;
            if (pokemon.CurrentHP <= 0 || player.CurrentHP <= 0)
            {
                if (player.CurrentHP > pokemon.CurrentHP)
                    MessageBox.Show("恭喜你戰勝" + pokemon.Name);
                else
                    MessageBox.Show("很可惜，挑戰失敗");
            }
        }
    }
}