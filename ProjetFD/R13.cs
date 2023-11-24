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
    public partial class R13 : Form
    {
        public Point mouselocation;
        SqlConnection conn = new SqlConnection(@"Data Source=UTILISA-6T0ALDK\SQLEXPRESS;Initial Catalog=MM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter dr;
        string date1;
        string date2;

        public R13()
        {
            InitializeComponent();
        }
     
        private void R13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sdf = new SqlDataAdapter("select * from    Mconsm  where TodaySDate between '" + StartDate.Value.ToString("yyy-MM-dd") + "' and '" + dtEnd.Value.ToString("yyy-MM-dd") + "'", conn);
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
            cmd = new SqlCommand(" select * from  Mconsm where  TodaySDate between '" + date1 + "' and '" + date2 + "'", conn);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            CrystalReport27 cr = new CrystalReport27();
            cr.Database.Tables["Mconsm"].SetDataSource(dt);

            this.crystalReportViewer1.ReportSource = cr;
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Mconsom().Show();
            this.Hide();
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
    }
}
