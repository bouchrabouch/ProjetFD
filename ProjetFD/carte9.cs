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
    public partial class carte9 : Form
    {
        public carte9()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=carte;Integrated Security=True");


        private void carte9_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username;

            username = txt_username.Text;


            try
            {
                string querry = " SELECT * FROM carte9 WHERE carte = '" + txt_username.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;

                    Forgetpass3magasin form2 = new Forgetpass3magasin();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();

                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_username.Clear();

            txt_username.Focus();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new Magasin().Show();
            this.Hide();
        }
    }
}
