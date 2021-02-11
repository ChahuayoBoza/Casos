using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Casos
{
    public partial class retiro_frm : Form
    {
        public retiro_frm()
        {
            InitializeComponent();
        }

        private void btn_prRetirar_Click(object sender, EventArgs e)
        {
            double sAnterior = Convert.ToDouble(txt_praMonto.Text);
            double sRetirar =Convert.ToDouble(txt_prRetiro.Text);
            double sNuevo;
            if(sAnterior <= sRetirar)
            {
                sNuevo = sAnterior;
                MessageBox.Show("El monto a retirar no puede ser mayor a al saldo actual");
            }
           
            else {
                sNuevo = sAnterior - sRetirar;
                MessageBox.Show($"El nuevo saldo es {sNuevo}");
            }
            txt_prnMonto.Text = sNuevo.ToString();


        }
    }
}
