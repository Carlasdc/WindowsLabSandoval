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
    public partial class Frmej2 : Form
    {
        public Frmej2()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);

            if ( edad >= 60)
            {
                MessageBox.Show("Es adulto mayor");
                   
            }
            else
            {
                if (edad >= 18 && edad < 60)
                {
                    MessageBox.Show("Es mayor de edad");
                }
                else
                {
                    if(edad <18 && edad != 0)
                    {
                        MessageBox.Show("Es menor de edad");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
        }
    }
}
