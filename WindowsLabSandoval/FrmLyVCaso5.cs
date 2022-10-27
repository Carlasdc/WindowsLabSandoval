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
    public partial class FrmLyVCaso5 : Form
    {
        public FrmLyVCaso5()
        {
            InitializeComponent();
        }
              
        private void btnTemp_Click_1(object sender, EventArgs e)
        {
            string provincia1 = txtProv1.Text;
            string provincia2 = txtProv2.Text;
            string provincia3 = txtProv3.Text;
            string provincia4 = txtProv4.Text;

            string[] provincias = { provincia1, provincia2, provincia3, provincia4 };

            int[] temperaturas = new int[3];
            int[] temperaturaTrimestral = new int[4];

            cargaTemperaturas(provincias, temperaturas, temperaturaTrimestral);
            MuestraProvinciasTemperatura(provincias, temperaturaTrimestral);
            mayorTempratura(provincias, temperaturaTrimestral);
        }
        private static void mayorTempratura(string[] provincias, int[] temperaturaTrimestral)
        {
            int mayor = 0;
            int contador = 0;
            for (int i = 0; i < provincias.Length; i++)
            {
                if (temperaturaTrimestral[i] > mayor)
                {
                    mayor = temperaturaTrimestral[i];
                    contador = i;
                }
            }
            MessageBox.Show("La provincia con la mayor temperatura trimestral es: " + provincias[contador]);
        }

        private static void MuestraProvinciasTemperatura(string[] provincias, int[] temperaturaTrimestral)
        {
            for (int j = 0; j < provincias.Length; j++)
            {

                MessageBox.Show("Provincia: " + provincias[j] + "\nTemperatura mensual media: " + (temperaturaTrimestral[j]/3));

            }
        }

        private static void cargaTemperaturas(string[] provincias, int[] temperaturas, int[] temperaturaTrimestral)
        {
            int temp;
            for (int j = 0; j < provincias.Length; j++)
            {
                temp = 0;
                for (int i = 0; i < 3; i++)
                {
                    temperaturas[i] = Convert.ToInt32(Interaction.InputBox("Ingrese la temperatura del mes " + (i + 1) + " de " + provincias[j]));
                    temp += temperaturas[i];
                }
                temperaturaTrimestral[j] = temp;
            }
        }
    }
}
