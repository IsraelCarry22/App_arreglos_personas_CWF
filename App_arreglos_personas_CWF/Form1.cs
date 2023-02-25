using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_arreglos_personas_CWF
{
    public partial class Form1 : Form
    {
        int numero_contactos = 0;
        Person[] Contacto_agenda;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtmAgregar_Click(object sender, EventArgs e)
        {
            numero_contactos = Convert.ToInt32(NumData.Value);
            if (numero_contactos == 0)
            {
                MessageBox.Show("Ingresa una cantidad mayor a 0");
            }
            Contacto_agenda = new Person[numero_contactos];
        }

        private void Btmnuevo_Click(object sender, EventArgs e)
        {
            if (numero_contactos <= i) { return; }
            if (numero_contactos == 0) { MessageBox.Show("Ingresa una cantidad mayor a 0"); return; }

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Nombres no ingresados");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtNombres, "");

            if (txtApellidoPaterno.Text == "")
            {
                errorProvider1.SetError(txtApellidoPaterno, "Apellido no ingresados");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoPaterno, "");

            if (txtApellidoMaterno.Text == "")
            {
                errorProvider1.SetError(txtApellidoMaterno, "Apellido no ingresados");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidoMaterno, "");

            Regex regemailo = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+" + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@" + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}" + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+" + @"[]" + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regemailo.IsMatch(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Gmail no es valida");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtCorreo, "");

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "Telefono no es valido");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            Person mipersona = new Person();
            mipersona.Nombre = txtNombres.Text;
            mipersona.Apellido_Paterno = txtApellidoPaterno.Text;
            mipersona.Apellido_Materno = txtApellidoMaterno.Text;
            mipersona.Fecha_de_cumpleaños = dtmFechaCumpleaños.Value;
            mipersona.Correo = txtCorreo.Text;
            mipersona.Telefono = txtTelefono.Text;
            Contacto_agenda[i] = mipersona;
            i++;
            dvgDatos.DataSource = null;
            dvgDatos.DataSource = Contacto_agenda;

            txtNombres.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombres.Focus();
        }
    }
}