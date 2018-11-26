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
    // Windows Forms que representa la interfaz de administrador del sistema
    public partial class Administrador : Form
    {
        
        public Administrador()
        {
            InitializeComponent();
            NuevoAdminLabel.Visible = false;
            NominaAdminLabel.Visible = false;
            NominObli.Visible = false;
            NominaAdminBox.Visible = false;
            NombreAdminLabel.Visible = false;
            NombreObli.Visible = false;
            NombreAdminBox.Visible = false;
            ContrasenaAdminLabel.Visible = false;
            ContraOblig.Visible = false;
            ContrasenaAdminBox.Visible = false;
        }

        // Metodo que se ejecuta al hacer click en Salir
        private void Continuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (EleccionAdminBox.CheckedItems.Count > 1)
            {
                MessageBox.Show("No se puede elegir más de un asunto", "SISCA.A - Registro de usuarios");
            }
            else if (EleccionAdminBox.CheckedItems.Count < 1)
            {
                MessageBox.Show("Porfavor elige un asunto", "SISCA.A - Registro de usuarios");
            }
            else
            {
                // Conexion a la base de datos de MakerSpace para desplegar excel 
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\Tec de Monterrey\3er Semestre\Fundamentos de Ingeniería de Software\SISCA.A\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();

                SqlCommand command;
                SqlDataAdapter da;
                DataSet ds;
                DateTime now;

                if (EleccionAdminBox.GetItemChecked(0) == true)
                {
                    command = new SqlCommand("SELECT * FROM MakerSpace", connection);
                    da = new SqlDataAdapter(command);
                    ds = new DataSet();
                    da.Fill(ds);
                    now = DateTime.Now;
                    // Ruta de localizacion donde se desea guardar el archivo excel con el registro de usuarios
                    ds.WriteXml(@"c:/Users/carlosemilianocastro/Desktop/RegistroUsuarios_"+now.ToString("m,M")+".xls");
                    MessageBox.Show("Archivo generado exitosamente con el nombre de:  RegistroUsuarios_" + now.ToString("M"), "SISCA.A - Registro de usuarios");
                }
                else if (EleccionAdminBox.GetItemChecked(1) == true)
                {
                    if (ContrasenaAdminBox.Text != "" && NominaAdminBox.Text != "" && NombreAdminBox.Text != "")
                    {
                        if (Form1.validarMatricula(NominaAdminBox.Text) && NominaAdminBox.Text[0] == 'L')
                        {
                            if (Form1.validarCampo(NombreAdminBox.Text))
                            {

                                command = new SqlCommand("INSERT INTO Administrador (Nomina,Nombre,Contrasena) Values (@Matricula,@Nombre,@Contrasena)", connection);
                                command.Parameters.Add("@Matricula", NominaAdminBox.Text);
                                command.Parameters.Add("@Nombre", NombreAdminBox.Text);
                                command.Parameters.Add("@Contrasena", ContrasenaAdminBox.Text);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Registro de nuevo administrador exitoso", "SISCA.A - Registro de usuarios");
                                NominaAdminBox.Text = "";
                                NombreAdminBox.Text = "";
                                ContrasenaAdminBox.Text = "";

                            }
                            else
                            {
                                MessageBox.Show("Formato de nombre erróneo", "SISCA.A - Registro de usuarios");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Formato de nómina erróneo", "SISCA.A - Registro de usuarios");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formulario incompleto", "SISCA.A - Registro de usuarios");
                    }
                }
                connection.Close();
            }
        }

        private void EleccionAdminBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EleccionAdminBox.GetItemChecked(1) == true)
            {
                NuevoAdminLabel.Visible = true;
                NominaAdminLabel.Visible = true;
                NominObli.Visible = true;
                NominaAdminBox.Visible = true;
                NominaAdminBox.Text = "";
                NombreAdminLabel.Visible = true;
                NombreObli.Visible = true;
                NombreAdminBox.Visible = true;
                NombreAdminBox.Text = "";
                ContrasenaAdminLabel.Visible = true;
                ContraOblig.Visible = true;
                ContrasenaAdminBox.Visible = true;
                ContrasenaAdminBox.Text = "";
            }
            else
            {
                NuevoAdminLabel.Visible = false;
                NominaAdminLabel.Visible = false;
                NominObli.Visible = false;
                NominaAdminBox.Visible = false;
                NombreAdminLabel.Visible = false;
                NombreObli.Visible = false;
                NombreAdminBox.Visible = false;
                ContrasenaAdminLabel.Visible = false;
                ContraOblig.Visible = false;
                ContrasenaAdminBox.Visible = false;
            }

        }
    }
}
