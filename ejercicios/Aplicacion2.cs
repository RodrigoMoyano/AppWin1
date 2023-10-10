using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Aplicacion2 : Form
    {
        public Aplicacion2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;
            txtResultado.Text = ("Nombre y apellido: " + nombre + " " + apellido + Environment.NewLine + "Edad: " + edad + Environment.NewLine + "Direccion: " + direccion );
            

            List<TextBox> lista = new List<TextBox>();
            lista.Add(txtNombre);
            lista.Add(txtApellido);
            lista.Add(txtEdad);
            lista.Add(txtDireccion);

            foreach (var item in lista)
            {
                if (item.Text == "")
                    item.BackColor = Color.Red;
                else if (item.Text.Length > 0)
                    item.BackColor = Color.White;
                else
                    item.BackColor = System.Drawing.SystemColors.Control;
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            { 
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
