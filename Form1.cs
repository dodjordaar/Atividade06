using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSortear_Click(object sender, EventArgs e)
        {
            int numeroMinimo = Convert.ToInt32(txtMinimo.Text);
            int numeroMaximo = Convert.ToInt32(txtMaximo.Text);

            btSortear.Text = new Random().Next(numeroMinimo, numeroMaximo + 1).ToString();
        }

        private void txtMinimo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
