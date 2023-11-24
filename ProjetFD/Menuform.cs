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
    public partial class Menuform : Form
    {
        public Point mouselocation;
        public Menuform()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            
           
           
            
          
            panel7.Visible = false;
            panel3.Visible = false;
        }


        private void hidesubMenu()
        {
           
            
            
            
           
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel7.Visible == true)
                panel7.Visible = false;





        }

        private void ShowsubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidesubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void Menuform_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Hopital().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Entrepot().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Magasin().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ShowsubMenu(panel3);



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hidesubMenu();
            new UMSordon().Show();
            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            hidesubMenu();
            new service1().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesubMenu();
            new entrepot1().Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            new Entrepot().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            new Magasin1().Show();
            this.Hide();
        }

        private void mouse_Done(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Entrepot().Show();
            this.Hide();
            hidesubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Ordo().Show();
            this.Hide();
            hidesubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            new Magasin().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Magasin1().Show();
            this.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");




        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           new Form16().Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new Login1().Show();
            this.Hide();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            ShowsubMenu(panel7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Login4().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Login6().Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new Login2().Show();
            this.Hide();
            hidesubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new Login3().Show();
            this.Hide();
            hidesubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new Login4().Show();
            this.Hide();
            hidesubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            new Login5().Show();
            this.Hide();
            hidesubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            new Login6().Show();
            this.Hide();
            hidesubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Login7().Show();
            this.Hide();
            hidesubMenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            new Doctor().Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            new sick2().Show();
            this.Hide();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            new sick1().Show();
            this.Hide();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            new Login1().Show();
            this.Hide();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            new sick3().Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            new P1().Show();
            this.Hide();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            new service1().Show();
            this.Hide();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {

            new Magasin().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            new UMS ().Show();
            this.Hide();
        }
    }
}
