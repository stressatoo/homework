
namespace compagnia_aerea
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
            this.txtKg = new System.Windows.Forms.TextBox();
            this.txtQf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotAlKg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.txtImpTot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kg bagaglio";
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(113, 34);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(100, 20);
            this.txtKg.TabIndex = 1;
            // 
            // txtQf
            // 
            this.txtQf.Location = new System.Drawing.Point(113, 60);
            this.txtQf.Name = "txtQf";
            this.txtQf.Size = new System.Drawing.Size(100, 20);
            this.txtQf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quota fissa";
            // 
            // txtTotAlKg
            // 
            this.txtTotAlKg.Location = new System.Drawing.Point(113, 86);
            this.txtTotAlKg.Name = "txtTotAlKg";
            this.txtTotAlKg.Size = new System.Drawing.Size(100, 20);
            this.txtTotAlKg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "€ al kg";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(113, 131);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(100, 23);
            this.btnCalcola.TabIndex = 6;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImpTot
            // 
            this.txtImpTot.Location = new System.Drawing.Point(113, 179);
            this.txtImpTot.Name = "txtImpTot";
            this.txtImpTot.Size = new System.Drawing.Size(100, 20);
            this.txtImpTot.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Importo totale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 239);
            this.Controls.Add(this.txtImpTot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.txtTotAlKg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.TextBox txtQf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotAlKg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.TextBox txtImpTot;
        private System.Windows.Forms.Label label4;
    }
}

