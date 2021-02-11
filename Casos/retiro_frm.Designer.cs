
namespace Casos
{
    partial class retiro_frm
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
            this.txt_praMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_prnMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_pdCancelar = new System.Windows.Forms.Button();
            this.btn_prRetirar = new System.Windows.Forms.Button();
            this.txt_prRetiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_praMonto
            // 
            this.txt_praMonto.Location = new System.Drawing.Point(241, 174);
            this.txt_praMonto.Name = "txt_praMonto";
            this.txt_praMonto.Size = new System.Drawing.Size(100, 23);
            this.txt_praMonto.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Monto Actual";
            // 
            // txt_prnMonto
            // 
            this.txt_prnMonto.Location = new System.Drawing.Point(249, 325);
            this.txt_prnMonto.Name = "txt_prnMonto";
            this.txt_prnMonto.Size = new System.Drawing.Size(100, 23);
            this.txt_prnMonto.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nuevo Monto";
            // 
            // btn_pdCancelar
            // 
            this.btn_pdCancelar.Location = new System.Drawing.Point(266, 240);
            this.btn_pdCancelar.Name = "btn_pdCancelar";
            this.btn_pdCancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_pdCancelar.TabIndex = 17;
            this.btn_pdCancelar.Text = "Cancelar";
            this.btn_pdCancelar.UseVisualStyleBackColor = true;
            // 
            // btn_prRetirar
            // 
            this.btn_prRetirar.Location = new System.Drawing.Point(75, 240);
            this.btn_prRetirar.Name = "btn_prRetirar";
            this.btn_prRetirar.Size = new System.Drawing.Size(75, 23);
            this.btn_prRetirar.TabIndex = 16;
            this.btn_prRetirar.Text = "Retirar";
            this.btn_prRetirar.UseVisualStyleBackColor = true;
            this.btn_prRetirar.Click += new System.EventHandler(this.btn_prRetirar_Click);
            // 
            // txt_prRetiro
            // 
            this.txt_prRetiro.Location = new System.Drawing.Point(148, 112);
            this.txt_prRetiro.Name = "txt_prRetiro";
            this.txt_prRetiro.Size = new System.Drawing.Size(134, 23);
            this.txt_prRetiro.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Monto a retirar";
            // 
            // retiro_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.txt_praMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_prnMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_pdCancelar);
            this.Controls.Add(this.btn_prRetirar);
            this.Controls.Add(this.txt_prRetiro);
            this.Controls.Add(this.label2);
            this.Name = "retiro_frm";
            this.Text = "retiro_frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_praMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_prnMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_pdCancelar;
        private System.Windows.Forms.Button btn_prRetirar;
        private System.Windows.Forms.TextBox txt_prRetiro;
        private System.Windows.Forms.Label label2;
    }
}