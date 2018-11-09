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


namespace SISCA.A
{
    public partial class EleccionAsunto : Form
    {
        
        string asunto = null;
        string matricula,nombre,carrera,alumno;
        DateTime now;
        public EleccionAsunto(string matricula,string nombre, string carrera, string alumno, DateTime now)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.carrera = carrera;
            this.alumno = alumno;
            this.now = now;
            InitializeComponent();
        }

       
        private void label8_Click(object sender, EventArgs e)
        {

        }

       
        private void eleccionAsuntoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = eleccionAsuntoBox.SelectedIndex;
            if (indice != -1)
            {
                asunto = eleccionAsuntoBox.Items[indice].ToString();
            }

            if (eleccionAsuntoBox.GetItemChecked(4) == true)
            {
                AsuntoBox.Visible = true;
                AsuntoLabel.Visible = true;
            }
            else
            {
                AsuntoBox.Visible = false;
                AsuntoLabel.Visible = false;
            }
            
            
        }

        private void Continuar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Documents\Tec de Monterrey\3er Semestre\Fundamentos de Ingeniería de Software\SISCA.A\ITESMCVA.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            
            if (eleccionAsuntoBox.CheckedItems.Count > 1)
            {
                MessageBox.Show("No se puede elegir más de un asunto", "SISCA.A - Registro de usuarios");
            }
            else if (eleccionAsuntoBox.CheckedItems.Count < 1)
            {
                MessageBox.Show("Porfavorr elige un asunto", "SISCA.A - Registro de usuarios");
            }
            

            if (eleccionAsuntoBox.GetItemChecked(4) == true)
            {
                if (eleccionAsuntoBox.CheckedItems.Count == 1 && AsuntoBox.Text != "" && FirmaBox.Text == matricula)
                {
                    if (MessageBox.Show("¡Ingreso registrado exitosamente!", "SISCA.A - Registro de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Hide();
                        SqlCommand command = new SqlCommand("UPDATE MakerSpace SET Asunto = @Asunto WHERE Matricula= '" + FirmaBox.Text+ "' AND FechaSalida IS NULL AND Asunto IS NULL", connection);
                        command.Parameters.Add("@Asunto", AsuntoBox.Text);
                        command.ExecuteNonQuery();


                         command = new SqlCommand("INSERT INTO MakerSpace (Matricula,Nombre,Carrera,Alumno,FechaEntrada) Values (@Matricula,@Nombre,@Carrera,@Alumno,@FechaEntrada)", connection);
                        command.Parameters.Add("@Matricula", matricula);
                        command.Parameters.Add("@Nombre", nombre);
                        command.Parameters.Add("@Carrera", carrera);
                        command.Parameters.Add("@Alumno", alumno);
                        command.Parameters.Add("@FechaEntrada", now);
                        command.ExecuteNonQuery();

                        Form1 principal = new Form1();
                        principal.Show();
                    }
                }
                else if (FirmaBox.Text == "")
                {
                    MessageBox.Show("Porfavor firma tu entrada", "SISCA.A - Registro de usuarios");
                }
                else if (FirmaBox.Text != matricula)
                {
                    MessageBox.Show("Porfavor teclea tu firma (matricula / nomina) correctamente", "SISCA.A - Registro de usuarios");
                }
                else if (AsuntoBox.Text == "")
                {
                    MessageBox.Show("Porfavor teclea tu asunto específico", "SISCA.A - Registro de usuarios");
                }
            }
            else
            {
                if (eleccionAsuntoBox.CheckedItems.Count == 1 && FirmaBox.Text ==matricula)
                {
                    if (MessageBox.Show("¡Ingreso registrado exitosamente!", "SISCA.A - Registro de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Hide();
                        SqlCommand command = new SqlCommand("UPDATE MakerSpace SET Asunto = @Asunto WHERE Matricula= '" + FirmaBox.Text + "' AND FechaSalida IS NULL AND Asunto IS NULL", connection);
                        command.Parameters.Add("@Asunto", asunto);
                        command.ExecuteNonQuery();

                        command = new SqlCommand("INSERT INTO MakerSpace (Matricula,Nombre,Carrera,Alumno,FechaEntrada) Values (@Matricula,@Nombre,@Carrera,@Alumno,@FechaEntrada)", connection);
                        command.Parameters.Add("@Matricula", matricula);
                        command.Parameters.Add("@Nombre", nombre);
                        command.Parameters.Add("@Carrera", carrera);
                        command.Parameters.Add("@Alumno", alumno);
                        command.Parameters.Add("@FechaEntrada", now);
                        command.ExecuteNonQuery();
                        Form1 principal = new Form1();
                        principal.Show();
                    }
                }
                else if (FirmaBox.Text == "")
                {
                    MessageBox.Show("Porfavor firma tu entrada", "SISCA.A - Registro de usuarios");
                }
                else if (FirmaBox.Text != matricula)
                {
                    MessageBox.Show("Porfavor teclea tu firma (matrícula / nómina) correctamente", "SISCA.A - Registro de usuarios");
                }
            }

            connection.Close();
        }

        private void FirmaLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }
    }
}
