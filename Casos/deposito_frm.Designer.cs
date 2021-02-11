
namespace Casos
{
    partial class deposito_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbpd_efectivo = new System.Windows.Forms.RadioButton();
            this.rbpd_cheque = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pdDeposito = new System.Windows.Forms.TextBox();
            this.btn_pdDepositar = new System.Windows.Forms.Button();
            this.btn_pdCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pdnMonto = new System.Windows.Forms.TextBox();
            this.txt_pdaMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbpd_efectivo
            // 
            this.rbpd_efectivo.AutoSize = true;
            this.rbpd_efectivo.Location = new System.Drawing.Point(158, 85);
            this.rbpd_efectivo.Name = "rbpd_efectivo";
            this.rbpd_efectivo.Size = new System.Drawing.Size(67, 19);
            this.rbpd_efectivo.TabIndex = 0;
            this.rbpd_efectivo.TabStop = true;
            this.rbpd_efectivo.Text = "Efectivo";
            this.rbpd_efectivo.UseVisualStyleBackColor = true;
            // 
            // rbpd_cheque
            // 
            this.rbpd_cheque.AutoSize = true;
            this.rbpd_cheque.Location = new System.Drawing.Point(158, 110);
            this.rbpd_cheque.Name = "rbpd_cheque";
            this.rbpd_cheque.Size = new System.Drawing.Size(66, 19);
            this.rbpd_cheque.TabIndex = 1;
            this.rbpd_cheque.TabStop = true;
            this.rbpd_cheque.Text = "Cheque";
            this.rbpd_cheque.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elegir deposito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto a depositar";
            // 
            // txt_pdDeposito
            // 
            this.txt_pdDeposito.Location = new System.Drawing.Point(319, 85);
            this.txt_pdDeposito.Name = "txt_pdDeposito";
            this.txt_pdDeposito.Size = new System.Drawing.Size(134, 23);
            this.txt_pdDeposito.TabIndex = 4;
            // 
            // btn_pdDepositar
            // 
            this.btn_pdDepositar.Location = new System.Drawing.Point(158, 209);
            this.btn_pdDepositar.Name = "btn_pdDepositar";
            this.btn_pdDepositar.Size = new System.Drawing.Size(75, 23);
            this.btn_pdDepositar.TabIndex = 5;
            this.btn_pdDepositar.Text = "Depositar";
            this.btn_pdDepositar.UseVisualStyleBackColor = true;
            this.btn_pdDepositar.Click += new System.EventHandler(this.btn_pdDepositar_Click);
            // 
            // btn_pdCancelar
            // 
            this.btn_pdCancelar.Location = new System.Drawing.Point(349, 209);
            this.btn_pdCancelar.Name = "btn_pdCancelar";
            this.btn_pdCancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_pdCancelar.TabIndex = 6;
            this.btn_pdCancelar.Text = "Cancelar";
            this.btn_pdCancelar.UseVisualStyleBackColor = true;
            this.btn_pdCancelar.Click += new System.EventHandler(this.btn_pdCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nuevo Monto";
            // 
            // txt_pdnMonto
            // 
            this.txt_pdnMonto.Location = new System.Drawing.Point(332, 294);
            this.txt_pdnMonto.Name = "txt_pdnMonto";
            this.txt_pdnMonto.Size = new System.Drawing.Size(100, 23);
            this.txt_pdnMonto.TabIndex = 8;
            // 
            // txt_pdaMonto
            // 
            this.txt_pdaMonto.Location = new System.Drawing.Point(332, 154);
            this.txt_pdaMonto.Name = "txt_pdaMonto";
            this.txt_pdaMonto.Size = new System.Drawing.Size(100, 23);
            this.txt_pdaMonto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monto Actual";
            // 
            // deposito_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.txt_pdaMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pdnMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_pdCancelar);
            this.Controls.Add(this.btn_pdDepositar);
            this.Controls.Add(this.txt_pdDeposito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbpd_cheque);
            this.Controls.Add(this.rbpd_efectivo);
            this.Name = "deposito_frm";
            this.Text = "deposito_frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbpd_efectivo;
        private System.Windows.Forms.RadioButton rbpd_cheque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pdDeposito;
        private System.Windows.Forms.Button btn_pdDepositar;
        private System.Windows.Forms.Button btn_pdCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pdnMonto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_pdaMonto;
    }
}