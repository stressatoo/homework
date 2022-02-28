
namespace Costo_per_fotocopie
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFotocopie = new System.Windows.Forms.Label();
            this.txtFotocopie = new System.Windows.Forms.TextBox();
            this.txtRilegatura = new System.Windows.Forms.TextBox();
            this.lblRilegatura = new System.Windows.Forms.Label();
            this.txtImp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImpConRil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFotocopie
            // 
            this.lblFotocopie.AutoSize = true;
            this.lblFotocopie.Location = new System.Drawing.Point(11, 20);
            this.lblFotocopie.Name = "lblFotocopie";
            this.lblFotocopie.Size = new System.Drawing.Size(102, 13);
            this.lblFotocopie.TabIndex = 0;
            this.lblFotocopie.Text = "Numero di fotocopie";
            // 
            // txtFotocopie
            // 
            this.txtFotocopie.Location = new System.Drawing.Point(138, 17);
            this.txtFotocopie.Name = "txtFotocopie";
            this.txtFotocopie.Size = new System.Drawing.Size(100, 20);
            this.txtFotocopie.TabIndex = 1;
            // 
            // txtRilegatura
            // 
            this.txtRilegatura.Location = new System.Drawing.Point(138, 43);
            this.txtRilegatura.Name = "txtRilegatura";
            this.txtRilegatura.Size = new System.Drawing.Size(100, 20);
            this.txtRilegatura.TabIndex = 3;
            // 
            // lblRilegatura
            // 
            this.lblRilegatura.AutoSize = true;
            this.lblRilegatura.Location = new System.Drawing.Point(11, 46);
            this.lblRilegatura.Name = "lblRilegatura";
            this.lblRilegatura.Size = new System.Drawing.Size(85, 13);
            this.lblRilegatura.TabIndex = 2;
            this.lblRilegatura.Text = "Prezzo rilegatura";
            // 
            // txtImp
            // 
            this.txtImp.Location = new System.Drawing.Point(138, 122);
            this.txtImp.Name = "txtImp";
            this.txtImp.Size = new System.Drawing.Size(100, 20);
            this.txtImp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Importo senza rilegatura";
            // 
            // txtImpConRil
            // 
            this.txtImpConRil.Location = new System.Drawing.Point(138, 148);
            this.txtImpConRil.Name = "txtImpConRil";
            this.txtImpConRil.Size = new System.Drawing.Size(100, 20);
            this.txtImpConRil.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Importo con rilegatura";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(138, 81);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(100, 24);
            this.btnCalcola.TabIndex = 8;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 181);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.txtImpConRil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRilegatura);
            this.Controls.Add(this.lblRilegatura);
            this.Controls.Add(this.txtFotocopie);
            this.Controls.Add(this.lblFotocopie);
            this.Name = "Form1";
            this.Text = "Costo per Fotocopie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFotocopie;
        private System.Windows.Forms.TextBox txtFotocopie;
        private System.Windows.Forms.TextBox txtRilegatura;
        private System.Windows.Forms.Label lblRilegatura;
        private System.Windows.Forms.TextBox txtImp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImpConRil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcola;
    }
}

