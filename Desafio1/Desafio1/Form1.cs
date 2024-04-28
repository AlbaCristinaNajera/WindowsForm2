using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularCapital_Click(object sender, EventArgs e)
        {
            double montoInicial = double.Parse(txtmontoInicial.Text.ToString());
            double tasaInteres = double.Parse(txttasaInteres .Text.ToString()); 
            double periodoInversion= double.Parse(txtperiodoInversion .Text.ToString());

            double CapitalFinal = montoInicial * Math.Pow(1 + (tasaInteres / 100), periodoInversion);

            txtResultado.Text = $"El capital final de inversión es de:  { CapitalFinal:N2}";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtmontoInicial.Text = string.Empty;
            txttasaInteres .Text = string.Empty;
            txtperiodoInversion .Text = string.Empty;   
            txtResultado .Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
