using System;
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
    public partial class Warhouse3 : Form
    {
        public Point mouselocation;
        SqlConnection con = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=SS ;Integrated Security=True");
        SqlCommand cmd;
        public Warhouse3()
        {
            InitializeComponent();
            displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("insert into warhouse_new values ( '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + dateTimePicker1.Value.ToString() + "','" + textBox8.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("your data has been saved in database");

            con.Close();
            displayData();
        }
        public void displayData()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from warhouse_new";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker3.Text = "";
            textBox8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from warhouse_new where Name = '" + textBox2.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            clear();
            MessageBox.Show("Record deleted successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("update warhouse_new set Name = '" + textBox2.Text + "',LastName = '" + textBox3.Text + "',NInsuranceCard ='" + textBox4.Text + "',EntryDate  = '" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "',ReleaseDate  = '" + dateTimePicker2.Value.ToString("yyy-MM-dd") + "',DateOfBirth= '" + dateTimePicker3.Value.ToString("yyy-MM-dd") + "',service= '" + textBox8.Text + "' where N = '" + int.Parse(textBox1.Text) + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                displayData();
                MessageBox.Show("Data has been updated ");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from warhouse_new  where NInsuranceCard = '" + textBox4.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new warehousehybride().Show();
            this.Hide();
        }

        private void Warhouse3_Load(object sender, EventArgs e)
        {
            displayData();
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

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }
    }
}
