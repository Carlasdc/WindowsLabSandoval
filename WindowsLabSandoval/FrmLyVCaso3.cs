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
    public partial class FrmLyVCaso3 : Form
    {
        public FrmLyVCaso3()
        {
            InitializeComponent();
        }
        
        struct Empleado
        {
            public string nombre;
            public int[] sueldos;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Empleado[] empleados = new Empleado[4];
            string nom = "";
            int sueldoMax = 0;

            for (int i = 0; i < 4; i++)
            {
                string nombre = Interaction.InputBox("Ingrese nombre");
                int[] sueldo = new int[3];

                for (int j = 0; j < 3; j++)
                {
                    sueldo[j] = Convert.ToInt32(Interaction.InputBox("Ingrese sueldo del mes " + (j + 1) + ":", "Carga de datos por empleado", "0"));
                }
                Empleado empleado = new Empleado();
                empleado.nombre = nombre;
                empleado.sueldos = sueldo;
                empleados[i] = empleado;

                int total = sueldo.Sum();
                MessageBox.Show("Total pagado en el ultimo trimestre: " + total);
                if (total > sueldoMax)
                {
                    nom = nombre;
                    sueldoMax = total;

                }
            }
            MessageBox.Show("La persona con mayor sueldo es: " + nom);
        }
        
    }
    
}

