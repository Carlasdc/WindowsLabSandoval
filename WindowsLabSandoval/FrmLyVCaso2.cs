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
    public partial class FrmLyVCaso2 : Form
    {
        private int[] product_prices; 
        public FrmLyVCaso2()
        {
            InitializeComponent();
            this.product_prices = new int[8];
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // crear un intput box que diga insertar numero
            for (int i = 0; i < 8; i++)
            {
                //mostras el mensaje que insert

                // agregas lo que inserto al vector

                //mostras mensaje de success
                
                //limpias el input box


            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           //asignas a una variuable
           //this.product_prices.Sum();
            //mostras el mensaje
        }
    }
}
