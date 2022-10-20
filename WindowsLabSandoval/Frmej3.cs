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
    public partial class Frmej3 : Form
    {
        public Frmej3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum1.Text);
            string resultado = "";
     
            for (int i = 1; i <= 12; i++)
            {
               
                resultado += num + "x" + i + "=" + (i * num) + "\n";
                
            }
            MessageBox.Show(resultado);
        }
    }
}
