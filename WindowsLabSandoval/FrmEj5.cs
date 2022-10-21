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
    public partial class FrmEj5 : Form
    {
        public FrmEj5()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            string usuario, tipo, sexo;
            usuario = txtUsuario.Text;
            tipo = txtTipo.Text;
            sexo = txtSexo.Text;

            if(tipo == "Administrador"|| tipo == "estandar" || tipo== "invitado")
            {
                MessageBox.Show("Tipo de usuario validado");
            }
            else
            {
                MessageBox.Show("El tipo de usuario es incorrecto");
            }
            if(sexo == "Femenino"|| sexo== "Masculino")
            {
                MessageBox.Show("El sexo del usuario fue validado");
            }
            else
            {
                MessageBox.Show("El sexo ingresado es invalido");
            }

            MessageBox.Show("Usuario: " + usuario + " - Sexo: " + sexo + " - Rol: " + tipo);
        }
    }
}
