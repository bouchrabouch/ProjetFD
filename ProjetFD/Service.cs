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
    public partial class Service : Form
    {
        public Point mouselocation;
        public Service()
        {
            InitializeComponent();
        }

        private void Service_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UMS3().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SI().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Menuform().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new PED().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new NEO().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Mat().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            new GO().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            new OTR().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new CH().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new CCI().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            new MF().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MH().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new DIALYSE().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mouve_down(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void mousse_move(object sender, MouseEventArgs e)
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
            new ServiceORDONNA().Show();
            this.Hide();
        }
    }
    
}
