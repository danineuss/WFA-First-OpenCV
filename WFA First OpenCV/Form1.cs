using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WFA_First_OpenCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> myImage = new Image<Bgr, byte>(openfile.FileName);
                Image<Gray, Byte> grayImage = myImage.Convert<Gray, Byte>();
                pictureBox1.Image = myImage.ToBitmap();
                pictureBox2.Image = grayImage.ToBitmap();
            }
        }
    }
}
