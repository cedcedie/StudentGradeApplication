using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;

            string name = Convert.ToString(textBox1.Text);

            double english = Convert.ToDouble(textBox2.Text);
            sum += english;

            double math = Convert.ToDouble(textBox3.Text);
            sum += math;

            double science = Convert.ToDouble(textBox4.Text);
            sum += science;

            double filipino =   Convert.ToDouble(textBox5.Text);
            sum += filipino;

            double history = Convert.ToDouble(textBox6.Text);
            sum += history;

            double average = sum / 5;

            label7.Text = (average >= 75) ? ("The Student Has Passed. \nThe General Average of " + name + " is " + average) : ("The Student Has Failed. \nThe General Average of " + name + " is " + average);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
