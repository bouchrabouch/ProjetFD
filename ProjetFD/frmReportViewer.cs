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
    public partial class frmReportViewer : Form
    {
        PEDsearchpériod ths ;

       

        public frmReportViewer(PEDsearchpériod myfrm)
        {
       
            InitializeComponent();
            ths = myfrm;
        }
        
        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
          
              

          
            
           
              
        }
    }

   
    
}
