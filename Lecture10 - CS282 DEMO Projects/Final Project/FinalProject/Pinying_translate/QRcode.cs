using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace Pinying_translate
{
    public partial class QRcode : Form
    {
        public QRcode(String save_text)
        {
            var writer = new BarcodeWriter 
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions //設定大小
                {
                    Height =250,
                    Width = 250,
                    CharacterSet = "UTF-8"
                }
            };

            InitializeComponent();
            QR_pictureBox.Image = writer.Write(save_text);
        }
    }
}
