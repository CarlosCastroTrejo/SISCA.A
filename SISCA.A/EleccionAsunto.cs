using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCA.A
{
    public partial class EleccionAsunto : Form
    {
        string asunto = null;
        string matricula;
        public EleccionAsunto(string matricula)
        {
            this.matricula = matricula;
            InitializeComponent();
        }

        private void EleccionAsunto_Load(object sender, EventArgs e)
        {

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
            if (eleccionAsuntoBox.CheckedItems.Count > 1)
            {
                MessageBox.Show("No se puede elegir mas de un asunto", "SISCA.A - Registro de usuarios");
            }
            else if (eleccionAsuntoBox.CheckedItems.Count < 1)
            {
                MessageBox.Show("Porvafor elige un asunto", "SISCA.A - Registro de usuarios");
            }

            if (FirmaBox.Text == "")
            {
                MessageBox.Show("Porfavor firma tu entrada", "SISCA.A - Registro de usuarios");
            }

            if (eleccionAsuntoBox.CheckedItems.Count == 1 && FirmaBox.Text != "")
            {
                if (MessageBox.Show("¡Ingreso registrado exitosamente!", "SISCA.A - Registro de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {

                   
                }
            }


        }
    }
}
