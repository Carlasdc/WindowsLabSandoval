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
    public partial class FrmLyVCaso1 : Form
    {
        private int materia1;
        private int materia2;
        private int materia3;

        public FrmLyVCaso1()
        {
            InitializeComponent();
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
           string nombre = txtNombre1.Text;
            int total = 0;
            this.materia1 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 1","Calculo de Notas","0"));
            this.materia2 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 2", "Calculo de Notas", "0"));
            this.materia3 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 3", "Calculo de Notas","0"));
            total = this.materia1 + this.materia2 + this.materia3;
            decimal promedio = total / 3;
            if (materia1 > materia2)
            {
                MessageBox.Show("La nota mas alta alcanzada fue: " + materia1);
            }
            else
            {
                int mayor = Math.Max(materia2, materia3);
                MessageBox.Show(nombre + ", la nota mas alta alcanzada fue: " + mayor);
            }

            MessageBox.Show("El promedio del alumno es: " + promedio);
            if (promedio>=7)
            {
                MessageBox.Show("Muy Bien!");
            }
            else
            {
                if(promedio<7 && promedio>=4)
                {
                    MessageBox.Show("Bien");
                }
                else
                {
                    MessageBox.Show("Debe ir a recuperatorio");
                }
            }
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre2.Text;
            int total = 0;
            this.materia1 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 1", "Calculo de Notas", "0"));
            this.materia2 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 2", "Calculo de Notas", "0"));
            this.materia3 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 3", "Calculo de Notas", "0"));
            total = this.materia1 + this.materia2 + this.materia3;
            decimal promedio = total / 3;
            if (materia1 > materia2)
            {
                MessageBox.Show("La nota mas alta alcanzada fue: " + materia1);
            }
            else
            {
                int mayor = Math.Max(materia2, materia3);
                MessageBox.Show(nombre + ", la nota mas alta alcanzada fue: " + mayor);
            }

            MessageBox.Show("El promedio del alumno es: " + promedio);
            if (promedio >= 7)
            {
                MessageBox.Show("Muy Bien!");
            }
            else
            {
                if (promedio < 7 && promedio >= 4)
                {
                    MessageBox.Show("Bien");
                }
                else
                {
                    MessageBox.Show("Debe ir a recuperatorio");
                }
            }
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre3.Text;
            int total = 0;
            this.materia1 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 1", "Calculo de Notas", "0"));
            this.materia2 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 2", "Calculo de Notas", "0"));
            this.materia3 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 3", "Calculo de Notas", "0"));
            total = this.materia1 + this.materia2 + this.materia3;
            decimal promedio = total / 3;
            if (materia1 > materia2)
            {
                MessageBox.Show("La nota mas alta alcanzada fue: " + materia1);
            }
            else
            {
                int mayor = Math.Max(materia2, materia3);
                MessageBox.Show(nombre + ", la nota mas alta alcanzada fue: " + mayor);
            }

            MessageBox.Show("El promedio del alumno es: " + promedio);
            if (promedio >= 7)
            {
                MessageBox.Show("Muy Bien!");
            }
            else
            {
                if (promedio < 7 && promedio >= 4)
                {
                    MessageBox.Show("Bien");
                }
                else
                {
                    MessageBox.Show("Debe ir a recuperatorio");
                }
            }
        }

        private void btnMostar4_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre4.Text;
            int total = 0;
            this.materia1 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 1", "Calculo de Notas", "0"));
            this.materia2 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 2", "Calculo de Notas", "0"));
            this.materia3 = Convert.ToInt32(Interaction.InputBox("Ingrese nota de materia 3", "Calculo de Notas", "0"));
            total = this.materia1 + this.materia2 + this.materia3;
            decimal promedio = total / 3;
            if (materia1 > materia2)
            {
                MessageBox.Show("La nota mas alta alcanzada fue: " + materia1);
            }
            else
            {
                int mayor = Math.Max(materia2, materia3);
                MessageBox.Show(nombre + ", la nota mas alta alcanzada fue: " + mayor);
            }

            MessageBox.Show("El promedio del alumno es: " + promedio);
            if (promedio >= 7)
            {
                MessageBox.Show("Muy Bien!");
            }
            else
            {
                if (promedio < 7 && promedio >= 4)
                {
                    MessageBox.Show("Bien");
                }
                else
                {
                    MessageBox.Show("Debe ir a recuperatorio");
                }
            }
        
        }
    }
       
}
