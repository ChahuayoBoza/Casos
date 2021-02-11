using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Casos
{
    public partial class deposito_frm : Form
    {

        
        public deposito_frm()
        {
            InitializeComponent();
        }

        private void btn_pdDepositar_Click(object sender, EventArgs e)
        {
            double saldoAnterior = Convert.ToDouble(txt_pdaMonto.Text);
            double deposito = Convert.ToDouble(txt_pdDeposito.Text);
            double saldoNuevo;
            if (rbpd_cheque.Checked == true)
            {

                saldoNuevo = saldoAnterior + (deposito - (0.01 * deposito));
            }
            else
            {
                saldoNuevo = deposito + saldoAnterior;
            }

            txt_pdnMonto.Text = saldoNuevo.ToString();

            MessageBox.Show($"El nuevo saldo es {saldoNuevo}");
        }

        private void btn_pdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
