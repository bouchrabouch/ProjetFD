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
    public partial class _12SICK : Form
    {
        public _12SICK()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            new P1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new P2().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new P3().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new P4().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new P5().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new P6().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new P7().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new P8().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new P9().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new P10().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new P11().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new P12().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Menuform().Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Menuform().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Warehouse4().Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new OW().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
