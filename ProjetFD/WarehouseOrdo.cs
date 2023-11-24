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
    public partial class WarehouseOrdo : Form
    {
        public Point mouselocation;

        SqlConnection con = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=WarehouseOrdo;Integrated Security=True");
        SqlCommand cmd;
        public void displayData()
        {

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Warehouse_new1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
        public void clear()
        {
            comboBox3.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";




        }

        public WarehouseOrdo()
        {
            InitializeComponent();
            displayData();
        }

        private void WarehouseOrdo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.ToString("yyy-MM-dd") == "" || dateTimePicker2.Value.ToString("yyy-MM-dd") == ""|| comboBox2.Text == "" || comboBox1.Text == "" || comboBox3.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(" Missing information");
            }
            else
            {

                con.Open();
                cmd = new SqlCommand("insert into Warehouse_new1 values ('" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "', '" + comboBox4.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Value.ToString("yyy-MM-dd") + "','" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("your data has been saved in database");

                con.Close();
                displayData();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Warehouse_new1 where Name = '" + textBox2.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            displayData();
            clear();
            MessageBox.Show("Record deleted successfully");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            comboBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new warehousehybride().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Warehouse_new1 where NInsuranceCard= '" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Warehouse_new1 set Date = '" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "' ,Doctor= '" + comboBox4.Text + "',service ='" + comboBox2.Text + "',N = '" + comboBox3.Text + "',Name  = '" + textBox2.Text + "',LastName = '" + textBox3.Text + "', Medicines= '" + textBox4.Text + "',DateOfBirth ='" + dateTimePicker2.Value.ToString("yyy-MM-dd") + "',NInsuranceCard = '" + textBox1.Text + "' ", con);
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
    }
}
