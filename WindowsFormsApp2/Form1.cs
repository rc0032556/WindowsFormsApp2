﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 4, pictureBox1.Location.Y);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 4);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 4, pictureBox1.Location.Y);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 4);
                await Task.Delay(50);
            }
        }
    }
}













