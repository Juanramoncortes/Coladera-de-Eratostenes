using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coladera_de_Eratostenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            Coladera coladera1 = new Coladera();
            txtDatos.Clear();
            coladera1.star();
            txtDatos.Text=coladera1.ToString();
        }
    }
}
