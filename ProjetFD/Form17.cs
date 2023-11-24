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
    public partial class Form17 : Form
    {
        public Point mouselocation;

        public Form17()
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
            new S1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new S2().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            new S3().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            new S4().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            new S5().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            new S6().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            new S7().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            new S8().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            new S9().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            new S10().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            new S11().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            new S12().Show();
            this.Hide();
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);

        }

        private void mouse_move(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new _12ORDO().Show();
            this.Hide();
        }
    }
}
