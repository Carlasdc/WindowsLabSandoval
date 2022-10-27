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
    public partial class FrmLyVCaso2 : Form
    { 
        public FrmLyVCaso2()
        {
            InitializeComponent();  
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int[] precio = new int[8];
            
            
            for (int i = 0; i < 8; i++)
            {
                precio[i] = Convert.ToInt32(Interaction.InputBox("Ingrese el precio del producto: ", "Carga de precios","0"));
                
            }
            //sumar todos los precios del vector
            int total = precio.Sum();
            MessageBox.Show("Total: " + total.ToString());

        }
    }
}
