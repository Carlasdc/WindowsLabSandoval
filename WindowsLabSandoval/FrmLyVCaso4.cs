using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLabSandoval
{
    public partial class FrmLyVCaso4 : Form
    {
        public FrmLyVCaso4()
        {
            InitializeComponent();
        }
        struct Persona
        {
            public string nombre;
            public int edad;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Persona[] individuos = new Persona[5];
            string nombresMayoresDeEdad = "";          
           
            for(int i=0; i<individuos.Length; i++)
            {
               string nombre = Interaction.InputBox("Ingrese nombre: ");
               int edad = Convert.ToInt32(Interaction.InputBox("Ingrese edad: "));
                Persona per = new Persona();
                per.nombre = nombre;
                per.edad = edad;
                individuos[i] = per;
            }
            for (int j = 0; j < individuos.Length; j++)
            {
                if (individuos[j].edad >= 18)
                {
                    nombresMayoresDeEdad += individuos[j].nombre + "\n";
                }

            }
            MessageBox.Show("Los individuos mayores de edad son:\n " + nombresMayoresDeEdad);
        }
    }
}
