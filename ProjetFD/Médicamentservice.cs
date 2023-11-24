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
    public partial class Médicamentservice : Form
    {
        public Point mouselocation;

        public Médicamentservice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            new MédUMS().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new MédSI().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            new PEDmédicaments().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            new MédNEO().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            new MédMAT().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            new MédGO().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            new MédCH().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            new MédOTR().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            new MédCCI().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            new MédMF().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            new MédMH().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            new MédDIALYSE().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Menuform().Show();
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
    }
}
