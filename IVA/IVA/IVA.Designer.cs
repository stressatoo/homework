
namespace IVA
{
    partial class IVA
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
            this.txtImpFinale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantità = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImponibile = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImpFinale
            // 
            this.txtImpFinale.Location = new System.Drawing.Point(101, 195);
            this.txtImpFinale.Name = "txtImpFinale";
            this.txtImpFinale.Size = new System.Drawing.Size(100, 20);
            this.txtImpFinale.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Importo Finale";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(101, 141);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "IVA al 22%";
            // 
            // txtPrUnit
            // 
            this.txtPrUnit.Location = new System.Drawing.Point(101, 30);
            this.txtPrUnit.Name = "txtPrUnit";
            this.txtPrUnit.Size = new System.Drawing.Size(100, 20);
            this.txtPrUnit.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imponibile";
            // 
            // txtQuantità
            // 
            this.txtQuantità.Location = new System.Drawing.Point(101, 56);
            this.txtQuantità.Name = "txtQuantità";
            this.txtQuantità.Size = new System.Drawing.Size(100, 20);
            this.txtQuantità.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantità";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prezzo unitario";
            // 
            // txtImponibile
            // 
            this.txtImponibile.Location = new System.Drawing.Point(101, 115);
            this.txtImponibile.Name = "txtImponibile";
            this.txtImponibile.Size = new System.Drawing.Size(100, 20);
            this.txtImponibile.TabIndex = 8;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(101, 85);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(100, 23);
            this.btnCalcola.TabIndex = 14;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // IVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 251);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImpFinale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImponibile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantità);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrUnit);
            this.Name = "IVA";
            this.Text = "IVA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImpFinale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantità;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImponibile;
        private System.Windows.Forms.Button btnCalcola;
    }
}

