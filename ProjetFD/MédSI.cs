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
    public partial class MédSI : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=SI0;Integrated Security=True");
        SqlCommand cmd;
        public Point mouselocation;
        public MédSI()
        {
            InitializeComponent();
        }

        private void MédSI_Load(object sender, EventArgs e)
        {
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT DISTINCT tradename FROM SI0_new", con);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            comboBox1.Items.Clear();
            comboBox1.Items.Add("---SELECT ---");
            foreach (DataRow ROW in DT.Rows)
            {
                comboBox1.Items.Add(ROW["tradename"].ToString());
            }
            displayData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into SI0 values ('" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')", con);
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
            cmd.CommandText = "select * from SI0";
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
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from SI0 where tradename = '" + comboBox1.Text + "' ";
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
                cmd = new SqlCommand("update SI0 set tradename = '" + comboBox1.Text + "',Quantity ='" + textBox1.Text + "',TodaySDate = '" + dateTimePicker1.Value.ToString() + "' where CodeProduct = '" + comboBox2.Text + "'", con);
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

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SI0  where tradename= '" + comboBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new Médicamentservice().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            new SearchSI().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("select distinct CodeProduct from SI0_new where tradename = '" + comboBox1.Text + "'", con);
            DataTable DT = new DataTable();
            sda.Fill(DT);
            comboBox2.Items.Clear();
            foreach (DataRow AB in DT.Rows)
            {
                comboBox2.Items.Add(AB["CodeProduct"].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=MédSERVICE;Integrated Security=True");
            SqlCommand cmdd;
            conn.Open();
            cmdd = new SqlCommand("insert into méd_new values ('" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "')", conn);
            cmdd.ExecuteNonQuery();
            MessageBox.Show("your data has been saved in database");

            conn.Close();
            displayData();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=MédSERVICE;Integrated Security=True");
            SqlCommand cmdd;
            conn.Open();
            cmdd = new SqlCommand("insert into méd_new1 values ('" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "')", conn);
            cmdd.ExecuteNonQuery();
            MessageBox.Show("your data has been saved in database");

            conn.Close();
            displayData();
            clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new SearchSI().Show();
            this.Hide();
        }
    }
}
