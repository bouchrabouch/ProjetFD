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
    public partial class ordSI : Form
    {
        public Point mouselocation;
        SqlConnection con = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Doctorser;Integrated Security=True");

        public ordSI()
        {
            InitializeComponent();
            GetN();
            displayData();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Ordo1;Integrated Security=True");
        SqlCommand cmd;

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ServiceORDONNA().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.ToString("yyy-MM-dd") == "" || dateTimePicker2.Value.ToString("yyy-MM-dd") == "" || comboBox2.Text == "" || comboBox1.Text == "" || comboBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(" Missing information");
            }
            else
            {

                conn.Open();
                cmd = new SqlCommand("insert into ordo1_new values ('" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "', '" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Value.ToString("yyy-MM-dd") + "','" + textBox1.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("your data has been saved in database");

                conn.Close();
                displayData();
            }
        }
        public void displayData()
        {

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ordo1_new";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }
        public void clear()
        {
            comboBox3.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";




        }
        public void GetName()
        {
            SqlConnection connn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Youtube50 ;Integrated Security=True");


            connn.Open();
            string Query = "select * from serSI1 where N = " + comboBox3.SelectedValue.ToString() + "";
            SqlCommand cmdd = new SqlCommand(Query, connn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox2.Text = dr["Name"].ToString();
            }

            connn.Close();
        }
        public void GetNInsuranceCard()
        {
            SqlConnection connn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Youtube50 ;Integrated Security=True");


            connn.Open();
            string Query = "select * from serSI1 where N = " + comboBox3.SelectedValue.ToString() + "";
            SqlCommand cmdd = new SqlCommand(Query, connn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1.Text = dr["NInsuranceCard"].ToString();
            }

            connn.Close();
        }
        public void GetLastName()
        {
            SqlConnection connn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Youtube50 ;Integrated Security=True");


            connn.Open();
            string Query = "select * from serSI1 where N = " + comboBox3.SelectedValue.ToString() + "";
            SqlCommand cmdd = new SqlCommand(Query, connn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox3.Text = dr["LastName"].ToString();
            }

            connn.Close();
        }
        public void GetN()
        {
            SqlConnection connn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Youtube50 ;Integrated Security=True");

            connn.Open();
            SqlCommand cmdd = new SqlCommand("select N from serSI1", connn);
            SqlDataReader rdr;
            rdr = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("N", typeof(int));
            dt.Load(rdr);
            comboBox3.ValueMember = "N";
            comboBox3.DataSource = dt;
            connn.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ordo1_new where Name = '" + textBox2.Text + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayData();
            clear();
            MessageBox.Show("Record deleted successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("update ordo1_new set Date = '" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "' ,Doctor= '" + comboBox1.Text + "',service ='" + comboBox2.Text + "',Name  = '" + textBox2.Text + "',LastName = '" + textBox3.Text + "', Medicines= '" + textBox4.Text + "',DateOfBirth ='" + dateTimePicker2.Value.ToString("yyy-MM-dd") + "',NInsuranceCard = '" + textBox1.Text + "'  where N = '" + comboBox3.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                displayData();
                MessageBox.Show("Data has been updated ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.ToString("yyy-MM-dd") == "" || dateTimePicker2.Value.ToString("yyy-MM-dd") == "" || comboBox2.Text == "" || comboBox1.Text == "" || comboBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
            {
                MessageBox.Show(" you can't save it " +
                    ",select the line that wants to save it");
            }
            else
            {
                SqlConnection connnn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=WarehouseOrdo ;Integrated Security=True");
                SqlCommand cmdd;

                connnn.Open();
                cmdd = new SqlCommand("insert into Warehouse_new1 values ('" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "', '" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Value.ToString("yyy-MM-dd") + "','" + textBox1.Text + "')", connnn);
                cmdd.ExecuteNonQuery();
                MessageBox.Show("your data has been saved in Warehouse");

                connnn.Close();
                displayData();
                clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ordo1_new where NInsuranceCard= '" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text + "\n", new Font("Averia", 18, FontStyle.Regular), Brushes.Black, new Point(95, 80));


        }

        private void ordSI_Load(object sender, EventArgs e)
        {
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT DISTINCT Doctor FROM Doctor", con);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            comboBox1.Items.Clear();
            comboBox1.Items.Add("---SELECT ---");
            foreach (DataRow ROW in DT.Rows)
            {
                comboBox1.Items.Add(ROW["Doctor"].ToString());
            }
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetName();
            GetLastName();
            GetNInsuranceCard();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select distinct service from Doctor where Doctor = '" + comboBox1.Text + "'", con);
            DataTable DT = new DataTable();
            sda.Fill(DT);
            comboBox2.Items.Clear();
            foreach (DataRow AB in DT.Rows)
            {
                comboBox2.Items.Add(AB["service"].ToString());
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string datetime = DateTime.Now.ToString("dd-MM-yyyy hh:mm tt");
            DateTime birth = (DateTime)dataGridView1.SelectedRows[0].Cells[7].Value;
            string Birth = birth.ToString("dd-MM-yyyy");
            richTextBox1.Text = "";
            richTextBox1.Text = "                                     PRESCRIPTION\n\n" + "****************************************************************************" + "\n" + datetime + "\n\n\n\n        Name:  " + dataGridView1.SelectedRows[0].Cells[4].Value.ToString() + "                 Last Name :" + dataGridView1.SelectedRows[0].Cells[5].Value.ToString() + "\n\n\n       Date Of Birth  : " + Birth + "\n\n\n       Doctor : " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "\n\n\n       Medicines : " + dataGridView1.SelectedRows[0].Cells[6].Value.ToString() + "\n\n\n\n\n\n\n\n                                    signature";

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

        private void button7_Click(object sender, EventArgs e)
        {

            new P2().Show();
            this.Hide();
        }
    }
}
