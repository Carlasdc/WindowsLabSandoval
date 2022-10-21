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
    public partial class FrmEj4 : Form
    {
        public FrmEj4()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            string figura = txtFigura.Text;
            double area = 0;
            switch(figura)
            {
                case "rectangulo":
                    double rBase = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese base del rectangulo: "));
                    double rAltura = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese altura del rectangulo: "));
                    area = rBase * rAltura;
                    break;
                case "circulo":
                    double radio = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el radio del circulo: "));
                    area = Math.PI * Math.Pow(radio,2);
                    break;
                case "trapecio":
                    double tBase1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese base superior del trapecio: "));
                    double tBase2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese base inferior del trapecio: "));
                    double tAltura = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese altura del trapecio: "));
                    area = ((tBase1+tBase2)/2) * tAltura;
                    break;
                default:
                    MessageBox.Show("No se puede calcular la figura ingresada");
                    break;

            }
            MessageBox.Show("El area es: " + area);
        }
    }
}
