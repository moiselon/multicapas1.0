using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Multicapas
{
    public partial class form2 : Form
    {
        private List<Contacto> Contactos = new List<Contacto>();
        private int indice = -1;

        public form2()
        {
            InitializeComponent();
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Contacto persona = new Contacto();
            persona.Nombre = tbname.Text;
            persona.Apellido = tbapellido.Text;
            persona.Telefono = tbtelefono.Text;
            persona.Correo = tbemail.Text;
            persona.Genero = tbgenero.Text;
            persona.Estado = tbestado.Text;
            persona.Direccion = tbdireccion.Text;
            persona.Fechadenacimiento = tbcumpleaño.Text;
            if (indice > -1)
            {
                Contactos[indice] = persona;
                indice = -1;
            }
            else
            {

                Contactos.Add(persona);
            }
            actualizavista();
            limpiacampos();
        }

        private void actualizavista()
        {
            dgvcontactos.DataSource = null;
            dgvcontactos.DataSource = Contactos;
            dgvcontactos.ClearSelection();
        }

        private void dgvcontactos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow renglon = dgvcontactos.SelectedRows[0];
            indice = dgvcontactos.Rows.IndexOf(renglon);
            Contacto persona = Contactos[indice];
            tbname.Text = persona.Nombre;
            tbapellido.Text = persona.Apellido;
            tbtelefono.Text = persona.Telefono;
            tbgenero.Text = persona.Genero;
            tbemail.Text = persona.Correo;
            tbestado.Text = persona.Estado;
            tbdireccion.Text = persona.Direccion;
            tbcumpleaño.Text = persona.Fechadenacimiento;
        }

        private void limpiacampos()
        {
            tbname.Text = null;
            tbapellido.Text = null;
            tbtelefono.Text = null;
            tbemail.Text = null;
            tbgenero.Text = null;
            tbdireccion.Text = null;
            tbestado.Text = null;
            tbcumpleaño.Text = null;
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                Contactos.RemoveAt(indice);
                actualizavista();
                limpiacampos();
                indice = -1;
            }

            else
            {
                MessageBox.Show("seleccione el registro al borrar");
            }
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            TextWriter escribir = new StreamWriter("Agenda.txt");
            foreach (Contacto persona in Contactos)
            {
                escribir.WriteLine(persona.Nombre + "|" + persona.Apellido + "|" + persona.Telefono + "|" + persona.Correo + "|" + persona.Genero + "|" + persona.Direccion + "|" + persona.Estado + "|" + persona.Fechadenacimiento);

            }
            escribir.Close();
            MessageBox.Show("contacto guardado existosamente");
        }
    }
    
    

        
}
