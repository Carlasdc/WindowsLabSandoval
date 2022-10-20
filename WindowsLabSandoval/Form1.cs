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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lado1 = Convert.ToInt32(txtLado1.Text);
            int lado2 = Convert.ToInt32(txtLado2.Text);

            int recarea = lado1 * lado2;

            MessageBox.Show("El area del rectangulo es: " + recarea);
        }
    }
}
