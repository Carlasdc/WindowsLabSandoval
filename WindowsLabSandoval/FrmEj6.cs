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
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimento;
        public FrmEj6()
        {
            InitializeComponent();
        }

        private void FrmEj6_Load(object sender, EventArgs e)
        {
        }
        private void Imprimir(string nombre, string apellido)
        {

            MessageBox.Show("Nombre: " + nombre + ", " + apellido);

        }
        private void Imprimir(string nombre, string apellido, DateTime fechaNac)
        {
            //solamente tiene en cuenta el anio de nac pero no el mes
            int edad = DateTime.Today.Year - dateTimePicker1.Value.Year;
            MessageBox.Show(nombre + " " + apellido + " tiene " + edad.ToString() + " años");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
      
            this.nombre = txtNombre.Text;
            this.apellido = txtApellido.Text;
            this.fechaDeNacimento = dateTimePicker1.Value;

            Imprimir(this.nombre, this.apellido);
            Imprimir(this.nombre, this.apellido, this.fechaDeNacimento);
       }
    }
}
