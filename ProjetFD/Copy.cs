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
    public partial class Copy : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Copy;Integrated Security=True");
        SqlCommand cmd;
        public Copy()
        {
            InitializeComponent();
        }

        private void Copy_Load(object sender, EventArgs e)
        {
            displayData();
            SqlConnection con = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Copy;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT N ,Name , LastName ,NInsuranceCard,EntryDate ,ReleaseDate ,DateOfBirth,service FROM COPY_new",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into COPY_new values ( '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + dateTimePicker1.Value.ToString() + "','" + textBox8.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("your data has been saved in database");

            con.Close();
            displayData();
            clear();
        }
        public void displayData()
        {

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from COPY_new";
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
            cmd.CommandText = "delete from COPY_new where Name = '" + textBox2.Text + "' ";
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
                cmd = new SqlCommand("update COPY_new set Name = '" + textBox2.Text + "',LastName = '" + textBox3.Text + "',NInsuranceCard ='" + textBox4.Text + "',EntryDate  = '" + dateTimePicker1.Value.ToString() + "',ReleaseDate  = '" + dateTimePicker2.Value.ToString() + "',DateOfBirth= '" + dateTimePicker3.Value.ToString() + "',service= '" + textBox8.Text + "' where N = '" + int.Parse(textBox1.Text) + "'", con);
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
            cmd.CommandText = "select * from COPY_new where NInsuranceCard = '" + textBox4.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Paste con = new Paste(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
               dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
               dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
               dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            con.Show();
        }
    }
}
