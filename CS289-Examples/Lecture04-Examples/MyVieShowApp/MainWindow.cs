using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVieShowApp
{
    public partial class MainWindow : Form
    {
        private PictureBox[] seats;
        private bool[] seatAvail;
        private Random random;
        private int numberOfRow = 6;
        private int start = 0;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            seats = new PictureBox[20];
            seatAvail = new bool[20];
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            int x_ini = 12;
            int y_ini = 12;

            int w = 80;
            int h = 120;
            int g = 10;
            for (int count = 0; count < seats.Length; count++)
            {
                int randomNumber = random.Next(1, 7);
                int row = count / numberOfRow;
                int col = count % numberOfRow;

                seats[count] = new PictureBox();
                seats[count].Size = new Size(w, h);
                //if (randomNumber > 2)
                //{
                //    seats[count].Image = Properties.Resources.seat_avail;
                //    seatAvail[count] = true;
                //}
                //else
                //{
                //    seats[count].Image = Properties.Resources.seat_unavail;
                //    seatAvail[count] = false;
                //}

                seats[count].Image =
                    randomNumber > 2 ?
                    Properties.Resources.seat_avail :
                    Properties.Resources.seat_unavail;
                seatAvail[count] = randomNumber > 2;

                int x = x_ini + (w + g) * col;
                int y = y_ini + (h + g) * row;
                seats[count].Location = new Point(x, y);

                seats[count].SizeMode = PictureBoxSizeMode.Zoom;
                seats[count].Click += new System.EventHandler(this.pictureBox1_Click);
                this.Controls.Add(seats[count]);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int numberOfPeople = selectNumberComboBox.SelectedIndex + 1;

            if (numberOfPeople == 0)
            {
                MessageBox.Show("請選擇要購買的張數");
            }
            else
            {
                for (int number = start; number <= seatAvail.Length - numberOfPeople; number++)
                {
                    if (!seatAvail[number])
                        continue;
                    int row = number / numberOfRow;
                    int col = number % numberOfRow;
                    int finded = 1;
                    for (int next = number + 1; next < number + numberOfPeople; next++)
                    {
                        if (seatAvail[next] && next / numberOfRow == row)
                            finded++;
                        else
                            break;
                    }

                    if (finded == numberOfPeople)
                    {
                        string receipt = "您選擇的座位是:\n";
                        for (int index = number; index < number + numberOfPeople; index++)
                        {
                            seats[index].Image = Properties.Resources.seat_select;

                            receipt += string.Format("第{0}排{1}號\n", index / numberOfRow + 1, index % numberOfRow + 1);
                        }
                        receiptRichTextBox.Text = receipt;
                        start = number + 1;
                        break;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox seat = sender as PictureBox;
            if (seat.Image == Properties.Resources.seat_select)
                seat.Image = Properties.Resources.seat_avail;
            else
                seat.Image = Properties.Resources.seat_select;
        }
    }
}