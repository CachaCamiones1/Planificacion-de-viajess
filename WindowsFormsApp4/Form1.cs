using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_Load(object sender, EventArgs e)
        {
            btniniciosesion.Enabled = false;
         
        }
        private void controlBotones()
        {
            if (nombre.Text.Trim() != string.Empty && nombre.Text.All(Char.IsLetter))
            {
                btniniciosesion.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                if (!(nombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(nombre, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir su nombre");
                }
                btniniciosesion.Enabled = false;
                nombre.Focus();
            }
        }
        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
        private void btniniciosesion_Click(object sender, EventArgs e)
        {
            Form formulario = new plan_viaje();
            formulario.Show();
        }
    } //escribe algo
}
