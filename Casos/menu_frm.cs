using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casos
{
    public partial class menu_frm : Form
    {
        Alumno oAlumno = new Alumno();
        public menu_frm()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void btn_consulta_Click(object sender, EventArgs e)
        {
            
            oAlumno.codigo = Convert.ToInt32(txt_cod.Text);
            oAlumno.nombres = txt_nom.Text;
            oAlumno.apellidos = txt_ape.Text;
            oAlumno.fechaNacimiento = dtp_fecNac.Value;
            oAlumno.edad = Convert.ToInt32(txt_edad.Text);
            
            MessageBox.Show($"Codigo: {oAlumno.codigo} \n" +
                $"Nombre Completo: {oAlumno.nombres} {oAlumno.apellidos}\n" +
                $"Fecha Nacimiento: {oAlumno.fechaNacimiento}\n" +
                $"Edad: {oAlumno.edad}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlumnosInstituto oAlumnosInstituto = new AlumnosInstituto();
            oAlumnosInstituto.codigo = oAlumno.codigo;
            oAlumnosInstituto.nombres = oAlumno.nombres;
            oAlumnosInstituto.apellidos = oAlumno.apellidos;
            oAlumnosInstituto.fechaNacimiento = oAlumno.fechaNacimiento;
            oAlumnosInstituto.edad = oAlumno.edad;
            oAlumnosInstituto.fechaIngreso = dtp_fecIngreso.Value;
            string añoIngreso = Convert.ToString(oAlumnosInstituto.fechaIngreso.Year);
            MessageBox.Show(
                $"Codigo: {oAlumnosInstituto.codigo} \n" +
                $"Nombre Completo: {oAlumnosInstituto.nombres} {oAlumnosInstituto.apellidos}\n" +
                $"Fecha Nacimiento: {oAlumnosInstituto.fechaNacimiento}\n" +
                $"Edad: {oAlumnosInstituto.edad}\n" +
                "-----------------------------\n" +
                $"Año de ingreso al instituto: {añoIngreso}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subsidio oSubsidio = new Subsidio();
            oSubsidio.nroHijos = Convert.ToInt32(txt_nroHijos.Text);
            oSubsidio.nroEscolares = Convert.ToInt32(txt_nroEscolares.Text);
            int bonoHijos = 0;
            int bonoEscolares = 0;
            int bonoViuda = 0;


            if(oSubsidio.nroHijos <= 2)
            {
                bonoHijos = 70;
            }else if(oSubsidio.nroHijos >= 3 && oSubsidio.nroHijos <= 5)
            {
                bonoHijos = 90;
            }else if(oSubsidio.nroHijos >= 6)
            {
                bonoHijos = 120;
            }
            
            if(oSubsidio.nroEscolares > 0)
            {
                bonoEscolares = 10 * oSubsidio.nroEscolares;
            }

            if(rb_si.Checked == true)
            {
                bonoViuda = 20;
            }
            else
            {
                bonoViuda = 0;
            }
            
            txt_bh.Text = bonoHijos.ToString();
            txt_be.Text = bonoEscolares.ToString();
            txt_bv.Text = bonoViuda.ToString();
            int total;
            total = bonoHijos + bonoEscolares + bonoViuda;
            txt_total.Text = total.ToString();

            MessageBox.Show($"El monto por hijos es {bonoHijos} \n" +
                $"Monto por escolaridad es {bonoEscolares} \n" +
                $"Monto por madre viuda {bonoViuda}");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            deposito_frm oDeo_frm = new deposito_frm();
            Cliente oCliente = new Cliente();
            oCliente.saldo = Convert.ToInt32(txt_saldo.Text);

            
            if (oCliente.saldo < 20)
            {
                MessageBox.Show("EL minimo de deposito es 20");
            }
            else
            {                
                oDeo_frm.txt_pdaMonto.Text = txt_saldo.Text;
                oDeo_frm.ShowDialog();
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            retiro_frm oRetiro_frm = new retiro_frm();

            Cliente oCliente = new Cliente();
            oCliente.saldo = Convert.ToInt32(txt_saldo.Text);


            if (oCliente.saldo < 20)
            {
                MessageBox.Show("EL minimo de deposito es 20");
            }
            else
            {
                oRetiro_frm.txt_praMonto.Text = txt_saldo.Text;
                oRetiro_frm.ShowDialog();
            }         
        }
    }
}
