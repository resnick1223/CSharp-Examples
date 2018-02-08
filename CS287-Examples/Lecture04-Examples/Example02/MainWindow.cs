using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code.org;

namespace Example02
{
    public partial class MainWindow : Form
    {
        public Person elsa;

        public MainWindow()
        {
            InitializeComponent();
            elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    X = 0.0,
                    Y = 0.0
                },
                Theta = 20.0
            };
            int x = (int)elsa.Pos.X;
            int y = (int)elsa.Pos.Y;
            ElsaPictureBox.Location = new Point(x, y);
            if (elsa.IsHappy())
            {
                this.ElsaPictureBox.Image = global::Example02.Properties.Resources._6d7454cea6644379adc7e529c5790a28078a2823;
            }
            else
            {
                this.ElsaPictureBox.Image = global::Example02.Properties.Resources.Elsa_angry_frozen2;
            }
        }
    }
}