﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Считывание начальных данных 
                double x0 = Convert.ToDouble(textBox1.Text);
                double xk = Convert.ToDouble(textBox2.Text);
                double dx = Convert.ToDouble(textBox3.Text);
                double a = Convert.ToDouble(textBox4.Text);
                double b = Convert.ToDouble(textBox6.Text);
                textBox5.Text = "Работу выполнил ст. Давыдюк А.С." + Environment.NewLine;
                // Цикл для табулирования функции 
                double x = x0;
               
                while (x <= (xk + dx / 2))
                {
                    double y = Math.Pow(10, -1) * a * x * x * x * Math.Tan(a - b * x); ;
                    textBox5.Text += "x=" + Convert.ToString(x) +
                    "; y=" + Convert.ToString(y) +
                    Environment.NewLine;
                    x = x + dx;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
