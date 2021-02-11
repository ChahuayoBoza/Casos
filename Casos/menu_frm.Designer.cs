
namespace Casos
{
    partial class menu_frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_caso1 = new System.Windows.Forms.TabPage();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.dtp_fecNac = new System.Windows.Forms.DateTimePicker();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_caso2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_fecIngreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tab_caso3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_bv = new System.Windows.Forms.TextBox();
            this.txt_be = new System.Windows.Forms.TextBox();
            this.txt_bh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.rb_si = new System.Windows.Forms.RadioButton();
            this.txt_nroEscolares = new System.Windows.Forms.TextBox();
            this.txt_nroHijos = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tab_caso4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_depositar = new System.Windows.Forms.Button();
            this.cbx_tipoDoc = new System.Windows.Forms.ComboBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tab_caso1.SuspendLayout();
            this.tab_caso2.SuspendLayout();
            this.tab_caso3.SuspendLayout();
            this.tab_caso4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab_caso1);
            this.tab.Controls.Add(this.tab_caso2);
            this.tab.Controls.Add(this.tab_caso3);
            this.tab.Controls.Add(this.tab_caso4);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(776, 406);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tab_caso1
            // 
            this.tab_caso1.Controls.Add(this.btn_consulta);
            this.tab_caso1.Controls.Add(this.dtp_fecNac);
            this.tab_caso1.Controls.Add(this.txt_edad);
            this.tab_caso1.Controls.Add(this.label5);
            this.tab_caso1.Controls.Add(this.label4);
            this.tab_caso1.Controls.Add(this.txt_ape);
            this.tab_caso1.Controls.Add(this.label3);
            this.tab_caso1.Controls.Add(this.txt_nom);
            this.tab_caso1.Controls.Add(this.label2);
            this.tab_caso1.Controls.Add(this.txt_cod);
            this.tab_caso1.Controls.Add(this.label1);
            this.tab_caso1.Location = new System.Drawing.Point(4, 24);
            this.tab_caso1.Name = "tab_caso1";
            this.tab_caso1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_caso1.Size = new System.Drawing.Size(768, 378);
            this.tab_caso1.TabIndex = 0;
            this.tab_caso1.Text = "Caso 1";
            this.tab_caso1.UseVisualStyleBackColor = true;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(315, 305);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(75, 23);
            this.btn_consulta.TabIndex = 11;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // dtp_fecNac
            // 
            this.dtp_fecNac.Location = new System.Drawing.Point(245, 181);
            this.dtp_fecNac.Name = "dtp_fecNac";
            this.dtp_fecNac.Size = new System.Drawing.Size(362, 23);
            this.dtp_fecNac.TabIndex = 10;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(245, 223);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(362, 23);
            this.txt_edad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // txt_ape
            // 
            this.txt_ape.Location = new System.Drawing.Point(245, 137);
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(362, 23);
            this.txt_ape.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos:";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(245, 91);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(362, 23);
            this.txt_nom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(245, 45);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(362, 23);
            this.txt_cod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // tab_caso2
            // 
            this.tab_caso2.Controls.Add(this.button1);
            this.tab_caso2.Controls.Add(this.dtp_fecIngreso);
            this.tab_caso2.Controls.Add(this.label6);
            this.tab_caso2.Location = new System.Drawing.Point(4, 24);
            this.tab_caso2.Name = "tab_caso2";
            this.tab_caso2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_caso2.Size = new System.Drawing.Size(768, 378);
            this.tab_caso2.TabIndex = 1;
            this.tab_caso2.Text = "Caso 2";
            this.tab_caso2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_fecIngreso
            // 
            this.dtp_fecIngreso.Location = new System.Drawing.Point(365, 133);
            this.dtp_fecIngreso.Name = "dtp_fecIngreso";
            this.dtp_fecIngreso.Size = new System.Drawing.Size(221, 23);
            this.dtp_fecIngreso.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha de ingreso al instituto:";
            // 
            // tab_caso3
            // 
            this.tab_caso3.Controls.Add(this.label13);
            this.tab_caso3.Controls.Add(this.txt_total);
            this.tab_caso3.Controls.Add(this.txt_bv);
            this.tab_caso3.Controls.Add(this.txt_be);
            this.tab_caso3.Controls.Add(this.txt_bh);
            this.tab_caso3.Controls.Add(this.label12);
            this.tab_caso3.Controls.Add(this.label11);
            this.tab_caso3.Controls.Add(this.label10);
            this.tab_caso3.Controls.Add(this.rb_no);
            this.tab_caso3.Controls.Add(this.rb_si);
            this.tab_caso3.Controls.Add(this.txt_nroEscolares);
            this.tab_caso3.Controls.Add(this.txt_nroHijos);
            this.tab_caso3.Controls.Add(this.button2);
            this.tab_caso3.Controls.Add(this.label9);
            this.tab_caso3.Controls.Add(this.label8);
            this.tab_caso3.Controls.Add(this.label7);
            this.tab_caso3.Location = new System.Drawing.Point(4, 24);
            this.tab_caso3.Name = "tab_caso3";
            this.tab_caso3.Padding = new System.Windows.Forms.Padding(3);
            this.tab_caso3.Size = new System.Drawing.Size(768, 378);
            this.tab_caso3.TabIndex = 2;
            this.tab_caso3.Text = "Caso 3";
            this.tab_caso3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Subsidio Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(427, 294);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 23);
            this.txt_total.TabIndex = 14;
            // 
            // txt_bv
            // 
            this.txt_bv.Location = new System.Drawing.Point(427, 257);
            this.txt_bv.Name = "txt_bv";
            this.txt_bv.Size = new System.Drawing.Size(100, 23);
            this.txt_bv.TabIndex = 13;
            // 
            // txt_be
            // 
            this.txt_be.Location = new System.Drawing.Point(427, 232);
            this.txt_be.Name = "txt_be";
            this.txt_be.Size = new System.Drawing.Size(100, 23);
            this.txt_be.TabIndex = 12;
            this.txt_be.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_bh
            // 
            this.txt_bh.Location = new System.Drawing.Point(427, 207);
            this.txt_bh.Name = "txt_bh";
            this.txt_bh.Size = new System.Drawing.Size(100, 23);
            this.txt_bh.TabIndex = 11;
            this.txt_bh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(230, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Bono por madre viuda";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Bono por escolaridad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bono por numero de hijos";
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(391, 161);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(41, 19);
            this.rb_no.TabIndex = 7;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "No";
            this.rb_no.UseVisualStyleBackColor = true;
            // 
            // rb_si
            // 
            this.rb_si.AutoSize = true;
            this.rb_si.Location = new System.Drawing.Point(277, 161);
            this.rb_si.Name = "rb_si";
            this.rb_si.Size = new System.Drawing.Size(34, 19);
            this.rb_si.TabIndex = 6;
            this.rb_si.TabStop = true;
            this.rb_si.Text = "Si";
            this.rb_si.UseVisualStyleBackColor = true;
            // 
            // txt_nroEscolares
            // 
            this.txt_nroEscolares.Location = new System.Drawing.Point(277, 121);
            this.txt_nroEscolares.Name = "txt_nroEscolares";
            this.txt_nroEscolares.Size = new System.Drawing.Size(193, 23);
            this.txt_nroEscolares.TabIndex = 5;
            // 
            // txt_nroHijos
            // 
            this.txt_nroHijos.Location = new System.Drawing.Point(277, 80);
            this.txt_nroHijos.Name = "txt_nroHijos";
            this.txt_nroHijos.Size = new System.Drawing.Size(193, 23);
            this.txt_nroHijos.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Calcular Subsidio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Madre de familia viuda? ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hijos en etapa escolar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Numero de Hijos: ";
            // 
            // tab_caso4
            // 
            this.tab_caso4.Controls.Add(this.button3);
            this.tab_caso4.Controls.Add(this.btn_depositar);
            this.tab_caso4.Controls.Add(this.cbx_tipoDoc);
            this.tab_caso4.Controls.Add(this.txt_saldo);
            this.tab_caso4.Controls.Add(this.txt_nombre);
            this.tab_caso4.Controls.Add(this.label16);
            this.tab_caso4.Controls.Add(this.label15);
            this.tab_caso4.Controls.Add(this.label14);
            this.tab_caso4.Location = new System.Drawing.Point(4, 24);
            this.tab_caso4.Name = "tab_caso4";
            this.tab_caso4.Padding = new System.Windows.Forms.Padding(3);
            this.tab_caso4.Size = new System.Drawing.Size(768, 378);
            this.tab_caso4.TabIndex = 3;
            this.tab_caso4.Text = "Caso 4";
            this.tab_caso4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(424, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Retirar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_depositar
            // 
            this.btn_depositar.Location = new System.Drawing.Point(196, 242);
            this.btn_depositar.Name = "btn_depositar";
            this.btn_depositar.Size = new System.Drawing.Size(75, 23);
            this.btn_depositar.TabIndex = 7;
            this.btn_depositar.Text = "Depositar";
            this.btn_depositar.UseVisualStyleBackColor = true;
            this.btn_depositar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // cbx_tipoDoc
            // 
            this.cbx_tipoDoc.FormattingEnabled = true;
            this.cbx_tipoDoc.Items.AddRange(new object[] {
            "DNI",
            "CARNE DE EXTRANJERIA"});
            this.cbx_tipoDoc.Location = new System.Drawing.Point(280, 129);
            this.cbx_tipoDoc.Name = "cbx_tipoDoc";
            this.cbx_tipoDoc.Size = new System.Drawing.Size(261, 23);
            this.cbx_tipoDoc.TabIndex = 6;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(280, 162);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(261, 23);
            this.txt_saldo.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(280, 100);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(261, 23);
            this.txt_nombre.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(161, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Saldo Inicial";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(161, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tipo Documento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(161, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nombre";
            // 
            // menu_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab);
            this.Name = "menu_frm";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.tab_caso1.ResumeLayout(false);
            this.tab_caso1.PerformLayout();
            this.tab_caso2.ResumeLayout(false);
            this.tab_caso2.PerformLayout();
            this.tab_caso3.ResumeLayout(false);
            this.tab_caso3.PerformLayout();
            this.tab_caso4.ResumeLayout(false);
            this.tab_caso4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_caso1;
        private System.Windows.Forms.TabPage tab_caso2;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.DateTimePicker dtp_fecNac;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_fecIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tab_caso3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nroEscolares;
        private System.Windows.Forms.TextBox txt_nroHijos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.RadioButton rb_si;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_bv;
        private System.Windows.Forms.TextBox txt_be;
        private System.Windows.Forms.TextBox txt_bh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TabPage tab_caso4;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbx_tipoDoc;
        private System.Windows.Forms.Button btn_depositar;
        private System.Windows.Forms.Button button3;
    }
}

