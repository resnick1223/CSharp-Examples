using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Imaging.Formats;
using AForge.Imaging.Filters;
using AForge.Imaging;

namespace OneClickPhotoshop
{
    public partial class OneClickPhotoshop : Form
    {
        private Bitmap originImage;
        private Bitmap processedImage;

        public OneClickPhotoshop()
        {
            InitializeComponent();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "所有檔案(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originImage = ImageDecoder.DecodeFromFile(openFileDialog.FileName);
                originPictureBox.Image = originImage;
            }
        }

        private void grayFilterButtom_Click(object sender, EventArgs e)
        {
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            processedImage = filter.Apply(originImage);
            processedPictureBox.Image = processedImage;
        }

        private void sketchFilterButton_Click(object sender, EventArgs e)
        {
            Grayscale grayfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImg = grayfilter.Apply(originImage);

            OtsuThreshold filter = new OtsuThreshold();
            processedImage = filter.Apply(grayImg);
            processedPictureBox.Image = processedImage;
        }

        private void reminiscentFilterButton_Click(object sender, EventArgs e)
        {
            SaturationCorrection filter = new SaturationCorrection((float)-0.2);
            processedImage = filter.Apply(originImage);
            processedPictureBox.Image = processedImage;
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "NewImage.bmp";
            saveFileDialog.Filter = "Bitmap file(*.bmp)|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                processedImage.Save(saveFileDialog.FileName);
            }
        }
    }
}