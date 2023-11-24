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
    public partial class SearchGO : Form
    {
        public Point mouselocation;

        public SearchGO()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=GO0;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter dr;
        string date1;
        string date2;

        private void SearchGO_Load(object sender, EventArgs e)
        {

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

        private void SearchGO_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new MédGO().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sdf = new SqlDataAdapter("select * from GO0 where TodaySDate between '" + StartDate.Value.ToString("yyy-MM-dd") + "' and '" + dtEnd.Value.ToString("yyy-MM-dd") + "'", conn);
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
            cmd = new SqlCommand(" select * from GO0 where  TodaySDate between '" + date1 + "' and '" + date2 + "'", conn);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            CrystalReport7 cr = new CrystalReport7();
            cr.Database.Tables["GO0"].SetDataSource(dt);

            this.crystalReportViewer1.ReportSource = cr;
            conn.Close();
        }
    }
}
