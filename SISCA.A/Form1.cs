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
using System.Collections;
using System.Windows;

namespace SISCA.A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Llenar_Click(object sender, EventArgs e)
        {
            NombreBox.Text = null;
            CarreraBox.Text = null;
            HoraBox.Text = null;
            EntradaBox.Text = null;
            AlumnoBox.Text = null;
            NombreObliga.Visible = false;
            CarreraObliga.Visible = false;
            AlumnoObliga.Visible = false;
            RegistraObliga.Visible = false;
            bool exist = true;

            if (MatriculaBox.Text.Length != 0)
            {
                char PrimeraLetra = char.ToUpper(MatriculaBox.Text[0]);
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\Tec de Monterrey\3er Semestre\Fundamentos de Ingeniería de Software\SISCA.A\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                if (PrimeraLetra == 'A')
                {
                   
                    //Checar que si abre la base de datos

                    string query = "SELECT * FROM C0laborador Where (Nomina = '" + MatriculaBox.Text + "')";
                    string output = null;
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        output = output + dataReader.GetValue(1);
                        NombreBox.Text = output;
                        output = null;
                        output = output + dataReader.GetValue(2);
                        CarreraBox.Text = output;
                    }
                    dataReader.Close();
                    if (output == null || output == "")
                    {
                        exist = false;
                    }

                    if (exist)
                    {
                        AlumnoBox.Text = "Alumno";
                        DateTime now = DateTime.Now;
                        HoraBox.Text = now.ToString("F");
                    }
                    else if (!exist)
                    {
                        if (MessageBox.Show("No exite usuario en el sistema, ¿Eres usuario nuevo?", "SISCA.A - Registro de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Usuario apreto "si" como respuesta
                            NombreObliga.Visible = true;
                            CarreraObliga.Visible = true;
                            AlumnoObliga.Visible = true;
                            RegistraObliga.Visible = true;

                            AlumnoBox.Text = "Alumno";
                            EntradaBox.Text = "Entrada";
                            DateTime now = DateTime.Now;
                            HoraBox.Text = now.ToString("F");

                            if (NombreBox.Text != null && MatriculaBox.Text != null && CarreraBox.Text != null && HoraBox.Text != null && EntradaBox.Text != null && AlumnoBox.Text != null)
                            {

                            }
                            else
                            {
                                MessageBox.Show("Formulario Incompleto", "SISCA.A - Registro de usuarios");
                            }
                        }
                        else
                        {
                            // Usuario apreto "no" como respuesta
                            MessageBox.Show("Intenta de nuevo", "SISCA.A - Registro de usuarios");
                        }
                    }
                   
                }
                else if (PrimeraLetra == 'L')
                {

                    //SqlConnection connection2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlosemilianocastro\Desktop\ITESM\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
                    //connection2.Open();
                    //Checar que si abre la base de datos

                    string query = "SELECT * FROM Colaborador WHERE (Nomina = '" + MatriculaBox.Text + "')";
                    string output = null;
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        output = output + dataReader.GetValue(1);
                        NombreBox.Text = output;
                        output = null;
                        output = output + dataReader.GetValue(2);
                        CarreraBox.Text = output;
                    }
                    dataReader.Close();
                    if (output == null || output == "")
                    {
                        exist = false;
                    }

                    if (exist)
                    {
                        AlumnoBox.Text = "Colaborador";
                        DateTime now = DateTime.Now;
                        HoraBox.Text = now.ToString("F");
                    }
                    else if (!exist)
                    {

                        if (MessageBox.Show("No exite usuario en el sistema, ¿Eres usuario nuevo?", "SISCA.A - Registro de alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // user clicked yes
                        }
                        else
                        {
                            // user clicked no
                        }
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Matricula incorrecta", "SISCA.A - Registro de alumnos");
                }
                connection.Close();

            }
            else
            {
                MessageBox.Show("No se escribio matricula", "SISCA.A - Registro de alumnos");
            }
        }
    }
}
