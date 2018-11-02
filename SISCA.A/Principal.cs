using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Windows;

namespace SISCA.A
{
    public partial class Principal : Form
    {

        bool exist = true;
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElegirAsunto asunto = new ElegirAsunto();
            asunto.Show();
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
            exist = true;

            if (MatriculaBox.Text.Length != 0)
            {
                char PrimeraLetra = char.ToUpper(MatriculaBox.Text[0]);
                if (PrimeraLetra == 'A')
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlosemilianocastro\Desktop\ITESM\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
                    connection.Open();
                    //Checar que si abre la base de datos

                    string query = "SELECT * FROM Usuarios Where (Matricula = '" + MatriculaBox.Text + "')";
                    string output = null;
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        output = output + dataReader.GetValue(1);
                        NombreBox.Text = output;
                        output = null;
                        output = output + dataReader.GetValue(3);
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
                        }
                        else
                        {
                            // Usuario apreto "no" como respuesta
                            MessageBox.Show("Intenta de nuevo", "SISCA.A - Registro de usuarios");
                        }
                    }
                    connection.Close();
                }
                else if (PrimeraLetra == 'L')
                {

                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlosemilianocastro\Desktop\ITESM\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
                    connection.Open();
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

            }
            else
            {
                MessageBox.Show("No se escribio matricula","SISCA.A - Registro de alumnos");
            }
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'iTESMCVADataSet.Colaborador' Puede moverla o quitarla según sea necesario.
            this.colaboradorTableAdapter.Fill(this.iTESMCVADataSet.Colaborador);
            // TODO: esta línea de código carga datos en la tabla 'iTESMCVADataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.iTESMCVADataSet.Usuarios);
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
