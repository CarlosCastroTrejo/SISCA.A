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
        bool formularioLLeno = false; // Variable booleana para indentificar si el formulario esta completo
        DateTime now = DateTime.Now;
        bool entrada = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Llenar_Click(object sender, EventArgs e)
        {
            // Borrado de formulario
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
             entrada = true;
            formularioLLeno = false;

            if (MatriculaBox.Text.Length != 0)
            {
                // Se realiza la conexion con la base de datos
                char PrimeraLetra = char.ToUpper(MatriculaBox.Text[0]);
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\Tec de Monterrey\3er Semestre\Fundamentos de Ingeniería de Software\SISCA.A\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                string output = null;
                string output2 = null;
                if (PrimeraLetra == 'A')
                {
                    string query = "SELECT * FROM Alumno Where (Matricula = '" + MatriculaBox.Text + "')";
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

                    // Checar el regreso del reader para asegurar que existe en la base datos
                    if (output == null || output == "")
                    {
                        exist = false;
                    }

                    // Si si se encuentra el usuario en la base de datos de Alumno
                    if (exist) 
                    {
                        AlumnoBox.Text = "Alumno";
                        HoraBox.Text = now.ToString("F");
                        formularioLLeno = true;
                        command = new SqlCommand("SELECT * FROM MakerSpace Where (Matricula = '" + MatriculaBox.Text + "')", connection);
                        dataReader = command.ExecuteReader();
                        output = null;
                        while (dataReader.Read())
                        {
                            output = "";
                            output2 = "";
                            output = output + dataReader.GetValue(0);
                            output2 = output2 + dataReader.GetValue(5);
                        }

                        if (output == null)
                        {
                            EntradaBox.Text = "Entrada";
                        }
                        else if (output != null && (output2 == null || output2==""))
                        {
                            EntradaBox.Text = "Salida";
                            entrada = false;
                        }
                        else 
                        {
                            EntradaBox.Text = "Entrada";
                        }
                        dataReader.Close();
                    }
                    else if (!exist) // Si no se encuentra el usuario en la base de datos
                    {
                        if (MessageBox.Show("No exite usuario en el sistema, ¿Eres usuario nuevo?", "SISCA.A - Registro de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Usuario apreto "si" como respuesta
                            NombreObliga.Visible = true;
                            CarreraObliga.Visible = true;
                            AlumnoObliga.Visible = true;
                            RegistraObliga.Visible = true;

                            AlumnoBox.Text = "Alumno";
                            DateTime now = DateTime.Now;
                            HoraBox.Text = now.ToString("F");

                            if (NombreBox.Text != null && MatriculaBox.Text != null && CarreraBox.Text != null && HoraBox.Text != null && EntradaBox.Text != null && AlumnoBox.Text != null)
                            {
                                formularioLLeno = true;
                                command = new SqlCommand("INSERT INTO Alumno (Matricula,Nombre,Carrera) Values (@Matricula,@Nombre,@Carrera)", connection);
                                command.Parameters.Add("@Matricula", MatriculaBox.Text);
                                command.Parameters.Add("@Nombre", NombreBox.Text);
                                command.Parameters.Add("@Carrera", CarreraBox.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Usuario apreto "no" como respuesta
                            MessageBox.Show("Error en la matricula, intenta de nuevo", "SISCA.A - Registro de usuarios");
                        }
                    }
                   
                }
                else if (PrimeraLetra == 'L')
                {
                    string query = "SELECT * FROM Colaborador WHERE (Nomina = '" + MatriculaBox.Text + "')";
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
                        HoraBox.Text = now.ToString("F");
                        formularioLLeno = true;
                        command = new SqlCommand("SELECT * FROM MakerSpace Where (Matricula = '" + MatriculaBox.Text + "')", connection);
                        dataReader = command.ExecuteReader();
                        output = null;
                        while (dataReader.Read())
                        {
                            output = "";
                            output2 = "";
                            output = output + dataReader.GetValue(0);
                            output2 = output2 + dataReader.GetValue(5);
                        }

                        if (output == null)
                        {
                            EntradaBox.Text = "Entrada";
                        }
                        else if (output != null && (output2 == null || output2 == ""))
                        {
                            EntradaBox.Text = "Salida";
                            entrada = false;
                        }
                        else
                        {
                            EntradaBox.Text = "Entrada";
                        }
                        dataReader.Close();
                    }
                    else if (!exist)
                    {

                        if (MessageBox.Show("No exite usuario en el sistema, ¿Eres usuario nuevo?", "SISCA.A - Registro de alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Usuario apreto "si" como respuesta
                            NombreObliga.Visible = true;
                            CarreraObliga.Visible = true;
                            AlumnoObliga.Visible = true;
                            RegistraObliga.Visible = true;

                            AlumnoBox.Text = "Colaborador";
                            DateTime now = DateTime.Now;
                            HoraBox.Text = now.ToString("F");

                            if (NombreBox.Text != null && MatriculaBox.Text != null && CarreraBox.Text != null && HoraBox.Text != null && EntradaBox.Text != null && AlumnoBox.Text != null)
                            {
                                formularioLLeno = true;
                                command = new SqlCommand("INSERT INTO Colaborador (Nomina,Nombre,Cargo) Values (@Matricula,@Nombre,@Carrera)", connection);
                                command.Parameters.Add("@Matricula", MatriculaBox.Text);
                                command.Parameters.Add("@Nombre", NombreBox.Text);
                                command.Parameters.Add("@Carrera", CarreraBox.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Usuario apreto "no" como respuesta
                            MessageBox.Show("Intenta de nuevo", "SISCA.A - Registro de usuarios");
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

        private void Continuar_Click(object sender, EventArgs e)
        {
            if (formularioLLeno == true && entrada == true)
            {
                this.Hide();
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\Tec de Monterrey\3er Semestre\Fundamentos de Ingeniería de Software\SISCA.A\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();


                SqlCommand command = new SqlCommand("INSERT INTO MakerSpace (Matricula,Nombre,Carrera,Alumno,FechaEntrada) Values (@Matricula,@Nombre,@Carrera,@Alumno,@FechaEntrada)", connection);
                command.Parameters.Add("@Matricula", MatriculaBox.Text);
                command.Parameters.Add("@Nombre", NombreBox.Text);
                command.Parameters.Add("@Carrera", CarreraBox.Text);
                command.Parameters.Add("@Alumno", AlumnoBox.Text);
                command.Parameters.Add("@FechaEntrada", now);
                command.ExecuteNonQuery();
                connection.Close();
            }
            else if (formularioLLeno == true && entrada == false)
            {
                this.Hide();
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\Tec de Monterrey\3er Semestre\Fundamentos de Ingeniería de Software\SISCA.A\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                // SqlCommand command = new SqlCommand("INSERT INTO MakerSpace (FechaSalida) Values (@FechaSalida) WHERE Matricula (Matricula = '"+ MatriculaBox.Text + "')", connection);
                SqlCommand command = new SqlCommand("UPDATE MakerSpace SET FechaSalida = @FechaSalida WHERE Matricula= '"+MatriculaBox.Text+"' AND FechaSalida IS NULL", connection);

                command.Parameters.Add("@FechaSalida", now);
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Formulario Incompleto", "SISCA.A - Registro de usuarios");
            }
        }
    }
}
