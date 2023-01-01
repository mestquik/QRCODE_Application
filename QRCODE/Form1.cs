using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QRCODE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder qr = new QRCodeEncoder();
            pictureBox1.Image = qr.Encode(textBox1.Text);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QRCodeDecoder qrr = new QRCodeDecoder();

           textBox1.Text = qrr.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
        }
    }
}
