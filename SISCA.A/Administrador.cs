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
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace SISCA.A
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataAdapter da;
            DataSet ds;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\Tec de Monterrey\3er Semestre\Fundamentos de Ingeniería de Software\SISCA.A\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand("SELECT * FROM MakerSpace", con);
            con.Open();
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
           
            ds.WriteXml(@"c:/Users/carlosemilianocastro/Desktop/File_.xls");


        }
    }
}
