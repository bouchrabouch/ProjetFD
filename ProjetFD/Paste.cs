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
    public partial class Paste : Form
    {
        public Paste(string N, string Name, string LastName, string NInsuranceCard, string EntryDate, string ReleaseDate, string DateOfBirth, string service)
        {
            InitializeComponent();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = N;
            dataGridView1.Rows[0].Cells[1].Value = Name;
            dataGridView1.Rows[0].Cells[2].Value = LastName;
            dataGridView1.Rows[0].Cells[3].Value = NInsuranceCard;
            dataGridView1.Rows[0].Cells[4].Value = EntryDate;
            dataGridView1.Rows[0].Cells[5].Value = ReleaseDate;
            dataGridView1.Rows[0].Cells[6].Value = DateOfBirth;
            dataGridView1.Rows[0].Cells[7].Value = service;
        }

        private void Paste_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Copy().Show();
            this.Hide();
        }
    }
}
