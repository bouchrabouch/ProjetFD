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
    public partial class PEDsearchpériod : Form
    {
        public Point mouselocation;
       
       
        public PEDsearchpériod()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=Youtube16;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter dr;
        string date1;
        string date2;

      

        private void PEDsearchpériod_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sdf = new SqlDataAdapter("select * from drugPED_new where TodaySDate between '" + StartDate.Value.ToString("yyyy-MM-dd") + "' and '" + dtEnd.Value.ToString("yyyy-MM-dd") + "'", conn);
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            dataGridView1.DataSource = sd;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            date1 = StartDate.Value.Year + "-" + StartDate.Value.Month + "-" + StartDate.Value.Day;
            date2 = dtEnd.Value.Year + "-" + dtEnd.Value.Month + "-" + dtEnd.Value.Day;
            conn.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand(" select * from drugPED_new where  TodaySDate between '"+date1+ "' and '" + date2 + "'",conn);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            CrystalReport2 cr = new CrystalReport2();
            cr.Database.Tables["drugPED_new"].SetDataSource(dt);

            this.crystalReportViewer1.ReportSource = cr;
            conn.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {

        }

        private void mousse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousePose;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new PEDmédicaments().Show();
            this.Hide();
        }
    }
}
