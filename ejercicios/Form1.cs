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
    public partial class PrimerApp : Form
    {
        public PrimerApp()
        {
            InitializeComponent();
        }

        private void PrimerApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");

        }

        private void PrimerApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau...");
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Se disparo el evento Click ", "Atencion");
            //this.BackColor = Color.Blue;
            if (txtBox.Text == "")
                txtBox.BackColor = Color.Red;
            else
                txtBox.BackColor = System.Drawing.SystemColors.Control;
        }
        private void PrimerApp_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void lblLabel_MouseMove(object sender, MouseEventArgs e)
        {
            lblLabel.BackColor = Color.Cyan;
            lblLabel.Cursor = Cursors.Hand;
        }

        private void lblLabel_MouseLeave(object sender, EventArgs e)
        {
            lblLabel.BackColor = System.Drawing.SystemColors.Control;
            lblLabel.Cursor = Cursors.Arrow;
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNuevo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtNuevo.Text.Length + " Caracteres");
        }
    }
}
