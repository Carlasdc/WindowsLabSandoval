﻿using System;
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
            int i = Convert.ToInt32(txtNum1.Text);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(number + "x" + i + "=" + (i * number));
            }
        }
    }
}
