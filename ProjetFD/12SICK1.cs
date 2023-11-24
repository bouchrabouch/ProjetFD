using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFD
{
    public partial class _12SICK1 : Form
    {
        public _12SICK1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new Menuform().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new P01().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new P02().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new P03().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new P04().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new P05().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new P06().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new P07().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new P08().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new p09().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new P010().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new P011().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new P012().Show();
            this.Hide();
        }

        private void _12SICK1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            new Mconsom().Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            new cy1().Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Menuform().Show();
            this.Hide();
        }
    }
}
