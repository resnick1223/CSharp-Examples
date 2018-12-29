using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MPPlayerMain
{
    public partial class Form1 : Form
    {
        public string musicpath;
        public Form1()
        {
            InitializeComponent();                     
            AXwmp.settings.autoStart = false;
        }
        
        public void playMusicSound()
        {
            AXwmp.Ctlcontrols.play();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                musicpath = openFileDialog1.FileName.ToString() ;               
                musiclistbox.Items.AddRange(new object[] { musicpath });                 
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (musicpath == null)
            {
                MessageBox.Show("請先選擇加入一首歌曲");
                return;
            }
            AXwmp.URL = @musicpath;
            Thread playMedia = new Thread(new ThreadStart(playMusicSound));
            playMedia.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            musicpath = musiclistbox.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AXwmp.Ctlcontrols.stop();   
        }
    }
}
