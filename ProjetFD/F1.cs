﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjetFD
{
    public partial class F1 : Form
    {
        public Point mouselocation;
        public F1()
        {
            InitializeComponent();
        }
       
        private void F1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Login22;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand(" SELECT * FROM sick1 WHERE username = '" + textBox1.Text + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr.GetValue(1).ToString();
            }
            else
            {
                MessageBox.Show("not match");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new sick1().Show();
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
