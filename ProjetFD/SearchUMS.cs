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
    public partial class SearchUMS : Form
    {
        public Point mouselocation;

        public SearchUMS()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=UMS0;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter dr;
        string date1;
        string date2;


        private void SearchUMS_Load(object sender, EventArgs e)
        {

        }

        private void Mouse_move(object sender, MouseEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MédUMS().Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new MédUMS ().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            date1 = StartDate.Value.Year + "-" + StartDate.Value.Month + "-" + StartDate.Value.Day;
            date2 = dtEnd.Value.Year + "-" + dtEnd.Value.Month + "-" + dtEnd.Value.Day;
            conn.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand(" select * from UMS0 where  TodaySDate between '" + date1 + "' and '" + date2 + "'", conn);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            CrystalReport3 cr = new CrystalReport3();
            cr.Database.Tables["UMS0"].SetDataSource(dt);

            this.crystalReportViewer1.ReportSource = cr;
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sdf = new SqlDataAdapter("select * from UMS0 where TodaySDate between '" + StartDate.Value.ToString("yyy-MM-dd") + "' and '" + dtEnd.Value.ToString("yyy-MM-dd") + "'", conn);
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            dataGridView1.DataSource = sd;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
