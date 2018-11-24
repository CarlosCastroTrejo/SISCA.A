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
    // Windows Forms que representa la interfaz principal de todo el sistema
    public partial class Form1 : Form
    {
        bool formularioLLeno = false;   // Variable booleana para indentificar si el formulario esta completo.
        DateTime now = DateTime.Now;    // Objeto tipo DateTime para desplegar la hora de entrada/salida.
        bool entrada = true;            // Variable booleana para indentificar si el usuario esta entrando.
        bool administrador = false;     // Variable booleana para indentificar si el usuario es el administrador.
        bool nuevo = false;             // Variable booleana para indentificar si el usuario es nuevo en la base de datos.
        string contrasena = null;       // Variable string para comparar la contrasena ingresada por la del administrador en la base de datos
        char PrimeraLetra ;             // Variable char para asignar la primera letra de la matricula.
        bool exist = true; // Variable bool para determinar si el usuario existe en la base de datos
        string matricula = null;

        // Validar Matricula: Metodo encargado de verificar que el campo de matricula tenga el formato correcto
        // Input: Valor string de la matricula
        // Output: Valor bool confirmando la matricula
        public static bool validarMatricula(string matricula)
        {
            if (matricula.Length !=9)
            {
                return false;
            }
            for (int x = 1; x < matricula.Length; x++)
            {
                if (matricula[x] > 57 || matricula[x] < 48)
                {
                    return false;
                }
            }
            return true;
        }

        // Validar Campor: Metodo encargado de verificar que los campos tenga el formato correcto
        // Input: Valor string del texto del campo a verificar
        // Output: Valor bool confirmando el formato del texto
        public static bool validarCampo(string text)
        {
            int fin = text.Length;
            if (text.Length == 0)
            {
                return false;
            }
            if (text[text.Length - 1] == ' ')
            {
                fin -= 1;
            }
            for (int i = 0; i < fin; i++)
            {
                char b = text[i];
                if ((int)text[i] >= 65 && (int)text[i] <= 97 || (int)text[i] >= 97 && (int)text[i] <= 122 || text[i] == 'ñ' || text[i] == 'í' || text[i] == 'ó' || text[i] == ' ')
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Metodo que se ejecuta al hacer click en conitnuar
        private void Llenar_Click(object sender, EventArgs e)
        {
            //  Inicializacion de la busqueda en la base de datos

            // Borrado de Campos 
            NombreBox.Text = null;
            CarreraBox.Text = null;
            HoraBox.Text = null;
            EntradaBox.Text = null;
            AlumnoBox.Text = null;
            NombreObliga.Visible = false;
            CarreraObliga.Visible = false;
            RegistraObliga.Visible = false;
            ContraLabel.Visible = false;
            ContraObli.Visible = false;
            ContraBox.Visible = false;
            entrada = true;
            nuevo = false;
            formularioLLeno = false;
            now = DateTime.Now; 
            HoraBox.Text = now.ToString("F");
            administrador = true;
            contrasena = null;
            matricula = null; 

            NombreBox.Enabled = false;
            CarreraBox.Enabled = false;
            AlumnoBox.Enabled = false;

            NombreBox.Visible = true;
            TextoNombre.Visible = true;
            CarreraBox.Visible = true;
            TextoCarrera.Visible = true;
            AlumnoBox.Visible = true;
            TextoAlumno.Visible = true;
            HoraBox.Visible = true;
            TextoHora.Visible = true;
            EntradaB.Visible = true;
            EntradaBox.Visible = true;
            Continuar.Visible = true;


            if (validarMatricula(MatriculaBox.Text))
            {
                string output = null;
                string output2 = null;

                // Se realiza la conexion con la base de datos de administrador para buscar verificar si el usuario es admnistrador
                PrimeraLetra = char.ToUpper(MatriculaBox.Text[0]);
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\Tec de Monterrey\3er Semestre\Fundamentos de Ingeniería de Software\SISCA.A\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
               
                string query =  "SELECT * FROM Administrador Where (Nomina = '" + MatriculaBox.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output = output + dataReader.GetValue(1);
                    NombreBox.Text= output;
                    output = null;
                    output = output + dataReader.GetValue(2);
                    contrasena = output;
                }
                dataReader.Close();
                if (output == null || output == "")
                {
                    administrador = false;
                }


                if (PrimeraLetra == 'A' && validarMatricula(MatriculaBox.Text))
                {
                    
                    output = null;
                    string mat ="A";
                    // Conversion de texto en el campo de matricula a un formato especifico
                    for (int x = 1; x < MatriculaBox.Text.Length; x++)
                    {
                        mat += MatriculaBox.Text[x];
                    }
                    matricula = mat;
                    MatriculaBox.Text = mat;
                     
                    // Conexion a la base de datos de alumno para buscar la matricula y verificar la existencia del alumno
                    query = "SELECT * FROM Alumno Where (Matricula = '" + MatriculaBox.Text + "')";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
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
                    // Si no se encuentra el usuario en la base de datos
                    else if (!exist) 
                    {
                        if (MessageBox.Show("No existe usuario en el sistema, ¿Eres usuario nuevo?", "SISCA.A - Registro de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Usuario apreto "si" como respuesta
                            NombreObliga.Visible = true;
                            CarreraObliga.Visible = true;
                            RegistraObliga.Visible = true;
                            NombreBox.Enabled = true;
                            CarreraBox.Enabled = true;
                            //AlumnoBox.Enabled = true;

                            AlumnoBox.Text = "Alumno";
                            EntradaBox.Text = "Entrada";
                            nuevo = true;

                        }
                        else
                        {
                            // Usuario apreto "no" como respuesta
                            MessageBox.Show("Hubo error en la matrícula, intentalo de nuevo", "SISCA.A - Registro de usuarios");
                            NombreBox.Visible = false;
                            TextoNombre.Visible = false;
                            CarreraBox.Visible = false;
                            TextoCarrera.Visible = false;
                            AlumnoBox.Visible = false;
                            TextoAlumno.Visible = false;
                            HoraBox.Visible = false;
                            TextoHora.Visible = false;
                            EntradaB.Visible = false;
                            EntradaBox.Visible = false;
                            Continuar.Visible = false;
                        }
                    }

                }
                // Si el primera letra de la matricula es L, esta bien escrita su matricula y es administrador
                else if (PrimeraLetra == 'L' && validarMatricula(MatriculaBox.Text) && administrador)
                {
                    string mat = "L";
                    for (int x = 1; x < MatriculaBox.Text.Length; x++)
                    {
                        mat += MatriculaBox.Text[x];
                    }
                    matricula = mat;

                    MatriculaBox.Text = mat;
                    ContraLabel.Visible = true;
                    ContraObli.Visible = true;
                    ContraBox.Visible = true;
                    CarreraBox.Text = "Administador";
                    AlumnoBox.Text = "Colaborador";
                    HoraBox.Text = now.ToString("F");

                }
                // Si el primera letra de la matricula es L, esta bien escrita su matricula y no es administrador
                else if (PrimeraLetra == 'L' && validarMatricula(MatriculaBox.Text))
                {
                    output = null;
                    string mat = "L";
                    for (int x = 1; x < MatriculaBox.Text.Length; x++)
                    {
                        mat += MatriculaBox.Text[x];
                    }
                    matricula = mat;

                    MatriculaBox.Text = mat;
                   
                    // Conexion a la base de datos del colaboradores
                    query = "SELECT * FROM Colaborador WHERE (Nomina = '" + MatriculaBox.Text + "')";
                    command = new SqlCommand(query, connection);

                    dataReader = command.ExecuteReader();
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

                    // Si el colaborador existe en la base de datos
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
                    // Si el colaborador no existe en la base de datos
                    else if (!exist)
                    { 
                        if (MessageBox.Show("No existe usuario en el sistema, ¿Eres usuario nuevo?", "SISCA.A - Registro de alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Usuario apreto "si" como respuesta
                            NombreObliga.Visible = true;
                            CarreraObliga.Visible = true;
                            RegistraObliga.Visible = true;
                            NombreBox.Enabled = true;
                            CarreraBox.Enabled = true;
                            // AlumnoBox.Enabled = true;

                            AlumnoBox.Text = "Colaborador";
                            EntradaBox.Text = "Entrada";
                            DateTime now = DateTime.Now;
                            HoraBox.Text = now.ToString("F");
                            nuevo = true;

                        }
                        else
                        {
                            // Usuario apreto "no" como respuesta
                            MessageBox.Show("Hubo error en la nómina, intentalo de nuevo", "SISCA.A - Registro de usuarios");
                            NombreBox.Visible = false;
                            TextoNombre.Visible = false;
                            CarreraBox.Visible = false;
                            TextoCarrera.Visible = false;
                            AlumnoBox.Visible = false;
                            TextoAlumno.Visible = false;
                            HoraBox.Visible = false;
                            TextoHora.Visible = false;
                            EntradaB.Visible = false;
                            EntradaBox.Visible = false;
                            Continuar.Visible = false;
                        }
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Formato de matrícula erróneo", "SISCA.A - Registro de alumnos");
                }
                connection.Close();

            }
            else
            {
                MessageBox.Show("Formato de matrícula erróneo", "SISCA.A - Registro de alumnos");
            }
        }


        // Metodo que se ejecuta al hacer click en continuar
        private void Continuar_Click(object sender, EventArgs e)
        {
            // Conexion a la base de datos de MakerSpace
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\Tec de Monterrey\3er Semestre\Fundamentos de Ingeniería de Software\SISCA.A\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            // Si el usario a ingresar es nuevo, lo registra en la base de datos, de acuerdo si es alumno o colaborador
            if (nuevo)
            {
                if (validarCampo(NombreBox.Text) && validarCampo(CarreraBox.Text))
                {
                    // Si la primera letra de la matricula es A es un alumno
                    if (PrimeraLetra == 'A' && validarMatricula(MatriculaBox.Text))
                    {
                        if (NombreBox.Text != "" && MatriculaBox.Text != "" && CarreraBox.Text != "" && HoraBox.Text != "" && EntradaBox.Text != "" && AlumnoBox.Text != "")
                        {
                            formularioLLeno = true;
                            entrada = true;
                            // Conexion con la base de datos de alumno para registrar al usuario
                            SqlCommand command = new SqlCommand("INSERT INTO Alumno (Matricula,Nombre,Carrera) Values (@Mat,@Nom,@Car)", connection);
                            command.Parameters.Add("@Mat", MatriculaBox.Text);
                            command.Parameters.Add("@Nom", NombreBox.Text);
                            command.Parameters.Add("@Car", CarreraBox.Text);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            formularioLLeno = false;
                        }
                    }
                    // Si la primera letra de la matricula es L es un colaborador
                    else if (PrimeraLetra == 'L' && validarMatricula(MatriculaBox.Text))
                    {
                        if (NombreBox.Text != "" && MatriculaBox.Text != "" && CarreraBox.Text != "" && HoraBox.Text != "" && EntradaBox.Text != "" && AlumnoBox.Text != "")
                        {
                            formularioLLeno = true;
                            entrada = true;
                            // Conexion con la base de datos de colaborador para registrar al usuario
                            SqlCommand command = new SqlCommand("INSERT INTO Colaborador (Nomina,Nombre,Cargo) Values (@Matricula,@Nombre,@Carrera)", connection);
                            command.Parameters.Add("@Matricula", MatriculaBox.Text);
                            command.Parameters.Add("@Nombre", NombreBox.Text);
                            command.Parameters.Add("@Carrera", CarreraBox.Text);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            formularioLLeno = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Formato de nombre o carrera / cargo erróneo", "SISCA.A - Registro de alumnos");
                }

            }

            if (NombreBox.Text != "" && MatriculaBox.Text != "" && CarreraBox.Text != "" && HoraBox.Text != "" && EntradaBox.Text != "" && AlumnoBox.Text != "" && validarCampo(NombreBox.Text) && validarCampo(CarreraBox.Text))
            {
                formularioLLeno = true;
            }
            else
            {
                formularioLLeno = false;
            }

            // Si el usuario es administrador, la interfaz del administrador se mostrara
            if (administrador == true && matricula==MatriculaBox.Text)
            {
                // Checar si la contrasena que se escribe es igual a la de dicho administrador en la base de datos
                if (ContraBox.Text == contrasena && ContraBox.Text != "")
                {
                    this.Hide();
                    Administrador admin = new Administrador();                    
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta ", "SISCA.A - Registro de usuarios");
                }
            }

            // Si el formulario esta lleno, el usuario entra y es un usuario cualquiera, se muestrsa la interfaz de eleccion de asunto
            if (formularioLLeno == true && entrada == true && matricula == MatriculaBox.Text)
            {
                this.Hide();
                EleccionAsunto asunto = new EleccionAsunto(MatriculaBox.Text, NombreBox.Text, CarreraBox.Text, AlumnoBox.Text, now);
                asunto.Show();
            }
            // Si el formulario esta lleno y el usuario sale
            else if (formularioLLeno == true && entrada == false && matricula == MatriculaBox.Text)
            {
                // Conexion con la base de datos de MakerSpace para actualizar la salida del usuario
                SqlCommand command = new SqlCommand("UPDATE MakerSpace SET FechaSalida = @FechaSalida WHERE Matricula= '" + MatriculaBox.Text + "' AND FechaSalida IS NULL", connection);

                command.Parameters.Add("@FechaSalida", now);
                command.ExecuteNonQuery();
                NombreBox.Text = null;
                MatriculaBox.Text = null;
                AlumnoBox.Text = null;
                CarreraBox.Text = null;
                AlumnoBox.Text = null;
                EntradaBox.Text = null;
                HoraBox.Text = null;
                MessageBox.Show("¡Salida registrada exitosamente!", "SISCA.A - Registro de usuarios");

            }
            else if (!formularioLLeno && (!validarCampo(NombreBox.Text) || !validarCampo(CarreraBox.Text)))
            {

            }
            else if (!validarCampo(NombreBox.Text) || !validarCampo(CarreraBox.Text))
            {

            }
            else if (administrador && ContraBox.Text == contrasena)
            {

            }
            else if (matricula != MatriculaBox.Text)
            {
                MessageBox.Show("Matrícula/nómina no coinciden, intenta llenar el fomulario de nuevo", "SISCA.A - Registro de usuarios");
            }
            else
            {
                MessageBox.Show("Formulario incompleto", "SISCA.A - Registro de usuarios");
            }
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void MatriculaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlumnoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EntradaB_Click(object sender, EventArgs e)
        {

        }
    }
}
