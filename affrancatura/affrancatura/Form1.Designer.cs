
namespace affrancatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesoLettera = new System.Windows.Forms.TextBox();
            this.txtAffrancatura = new System.Windows.Forms.TextBox();
            this.lblAffrancatura = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso lettera in grammi";
            // 
            // txtPesoLettera
            // 
            this.txtPesoLettera.Location = new System.Drawing.Point(147, 18);
            this.txtPesoLettera.Name = "txtPesoLettera";
            this.txtPesoLettera.Size = new System.Drawing.Size(100, 20);
            this.txtPesoLettera.TabIndex = 1;
            // 
            // txtAffrancatura
            // 
            this.txtAffrancatura.Location = new System.Drawing.Point(147, 112);
            this.txtAffrancatura.Name = "txtAffrancatura";
            this.txtAffrancatura.Size = new System.Drawing.Size(100, 20);
            this.txtAffrancatura.TabIndex = 3;
            // 
            // lblAffrancatura
            // 
            this.lblAffrancatura.AutoSize = true;
            this.lblAffrancatura.Location = new System.Drawing.Point(22, 114);
            this.lblAffrancatura.Name = "lblAffrancatura";
            this.lblAffrancatura.Size = new System.Drawing.Size(102, 13);
            this.lblAffrancatura.TabIndex = 2;
            this.lblAffrancatura.Text = "Importo affrancatura";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(147, 66);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(100, 23);
            this.btnCalcola.TabIndex = 4;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 161);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.txtAffrancatura);
            this.Controls.Add(this.lblAffrancatura);
            this.Controls.Add(this.txtPesoLettera);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesoLettera;
        private System.Windows.Forms.TextBox txtAffrancatura;
        private System.Windows.Forms.Label lblAffrancatura;
        private System.Windows.Forms.Button btnCalcola;
    }
}

