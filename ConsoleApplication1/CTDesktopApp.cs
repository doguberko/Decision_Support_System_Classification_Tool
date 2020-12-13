using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // hocam en iyi algoritmayi seciyor fakat program classindan bu classa calisir bir sekilde cekemedim.
            Form1 fr = new Form1();
            fr.textBox1.Text = Program.notice;
            fr.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Daily");
            comboBox1.Items.Add("Monthly");
            comboBox1.Items.Add("Yearly");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add("January");
            comboBox2.Items.Add("February");
            comboBox2.Items.Add("March");
            comboBox2.Items.Add("April");
            comboBox2.Items.Add("May");
            comboBox2.Items.Add("June");
            comboBox2.Items.Add("July");
            comboBox2.Items.Add("August");
            comboBox2.Items.Add("September");
            comboBox2.Items.Add("October");
            comboBox2.Items.Add("November");
            comboBox2.Items.Add("December");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
        }       

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
