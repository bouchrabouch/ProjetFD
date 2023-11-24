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
    public partial class ServiceORDONNA : Form
    {
        public Point mouselocation;
        public ServiceORDONNA()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Service().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            new Ordonnance().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ordSI().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ordPED().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ordNEO().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ordMF().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            new ordMH().Show();
            this.Hide();
        }

        private void ServiceORDONNA_Load(object sender, EventArgs e)
        {

        }

        private void mouse_down(object sender, MouseEventArgs e)
        {

            mouselocation = new Point(-e.X, -e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            new ordMAT().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ordGO().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            new ordCH().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            new ordOTR().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new ordCCI().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new ordDIALYSE().Show();
            this.Hide();
        }
    }
}
