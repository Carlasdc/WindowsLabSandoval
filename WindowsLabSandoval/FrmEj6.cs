using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLabSandoval
{
    public partial class FrmEj6 : Form
    {
        public FrmEj6()
        {
            InitializeComponent();
        }

        private void FrmEj6_Load(object sender, EventArgs e)
        {

            string nombre, apellido, fecha;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            fecha = txtFecha.Text;

            MessageBox.Show("Nombre: " + nombre + ", " + apellido);

            /*{
                int anio = dateTimePicker1.Value.Year;

                MessageBox.Show(nombre + " " + apellido + " tiene " + anio.ToString());
            }*/
        }
    }
}
