﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paymon
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private  void  LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
            slidePicture.ImageLocation = string.Format(@"Images\{0}.png", imageNumber);
            imageNumber++;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
