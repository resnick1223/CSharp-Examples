using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace game1
{
    public partial class maingame : Form
    {    
        //變數宣告
        private Button[] button = new System.Windows.Forms.Button[36];
        private Button[] ctrlBtn = new System.Windows.Forms.Button[3];
        private String[] cB_name = { "START", "STOP", "RESET" };
        private Timer timer1 = new System.Windows.Forms.Timer();
        private Timer timer2 = new System.Windows.Forms.Timer();
        private Random ran = new Random();
        private int score = new int();
        private int time = 61;//倒數時間
        private int speed = 2200;//碼表速度


        public maingame()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            load();
        }

        private void load()
        {
            timer1 = new Timer();
            timer2 = new Timer();
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer2.Tick += new System.EventHandler(timer2_Tick);
            //動態產生button
            for (int i = 0; i < 36; i++) 
            {
                button[i] = new Button();
                button[i].Size = new Size(60, 60);
                button[i].Click += new System.EventHandler(button_Click);
                this.Controls.Add(button[i]);
                if (i < 6) button[i].Location = new System.Drawing.Point(60 * (i + 1), 20);
                if (i >= 6 && i < 12) button[i].Location = new System.Drawing.Point(60 * (i % 6 + 1), 80);
                if (i >= 12 && i < 18) button[i].Location = new System.Drawing.Point(60 * (i % 6 + 1), 140);
                if (i >= 18 && i < 24) button[i].Location = new System.Drawing.Point(60 * (i % 6 + 1), 200);
                if (i >= 24 && i < 30) button[i].Location = new System.Drawing.Point(60 * (i % 6 + 1), 260);
                if (i >= 30 && i < 36) button[i].Location = new System.Drawing.Point(60 * (i % 6 + 1), 320);
            }
            //動態產生 "START", "STOP", "RESET" 的ctrlBtn
            for (int j = 0; j < 3; j++)
            {
                ctrlBtn[j] = new Button();
                ctrlBtn[j].Text = cB_name[j];
                ctrlBtn[j].Size = new Size(50, 50);
                ctrlBtn[j].Location = new System.Drawing.Point(60 * (j + 1), 400);
                ctrlBtn[j].Click += new System.EventHandler(ctrlBtn_Click);
                this.Controls.Add(ctrlBtn[j]);
            }
            label1.Location = new System.Drawing.Point(60 * 5, 405);
            label2.Location = new System.Drawing.Point(60 * 5, 430);
            
        }
      
        private void button_Click(object sender, EventArgs e)
        {
            int random_i = 0;
            for (int i = 0; i < 36; i++)
            {
                if (sender == button[i] && button[i].Image != null)   //取地鼠 位置
                    random_i = i;
            }

            if (sender == button[random_i])//判別是否點對
            {
                score += 10;//按對加分
                speed -= 50;
                button[random_i].BackColor = Color.LightGreen;
                button[random_i].Image = null;
            }

            else if (sender != button[random_i])
            {
                score -= 15;//按錯減分
                speed += 200;
            }
            label2.Text = "分數" + score.ToString();
            
        }

        private void ctrlBtn_Click(object sender, EventArgs e)
        {
            if (sender == ctrlBtn[0]) { start(); }
            if (sender == ctrlBtn[1]) { stop(); }
            if (sender == ctrlBtn[2]) { reset(); }
        }
        private void timer1_Tick(object sender, EventArgs e)//產生
        {
            for (int i = 0; i < 36 ; i++)
            {
                button[i].BackColor = Color.LightGreen;
                button[i].Image = null;
            }

            ////隨機選一個按鈕
            //button[ran.Next(0, 36)].BackColor = Color.YellowGreen;
            button[ran.Next(0, 36)].Image = global::game1.Properties.Resources._050;
            if (speed >= 1000)
                timer1.Interval = speed;

            else if (timer1.Interval == 999)
                //當緩衝時間過了(999),便會以原來速度下去跑
                timer1.Interval = speed;

            else timer1.Interval = 1000; 
        }
        private void timer2_Tick(object sender, EventArgs e)//倒數計時器
        {
            if (time > 0) time--;
            else if (time <= 0)
            {
                for (int i = 0; i < 36; i++)
                {
                    button[i].BackColor = SystemColors.Control;
                    button[i].Image = null;
                }
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("遊戲結束囉!!您的分數為" + score.ToString());
            }
            label1.Text = time.ToString();
        }

        private void start()//開始
        {
            if (label1.Text != "")
            {
                MessageBox.Show("請先重置遊戲!");
                return;
            }
            timer1.Start();
            timer1.Interval = 999;//設緩衝時間
            timer2.Start();
            timer2.Interval = 1000;
        }

        private void stop() //暫停
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void reset() //重置
        {
            time = 61;
            score = 0;
            speed = 2000;
            label1.Text = "";
            label2.Text = "";
            for (int i = 0; i < 36; i++)
            {
                button[i].BackColor = SystemColors.Control;
            }
        }
    }

}

