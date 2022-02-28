
namespace BorsaDiStudio
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
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.lblVoto = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.txtImpFinale = new System.Windows.Forms.TextBox();
            this.lblBorsa = new System.Windows.Forms.Label();
            this.txtMinorenne = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Età";
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(110, 19);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(100, 20);
            this.txtEtà.TabIndex = 1;
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(110, 45);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(100, 20);
            this.txtVoto.TabIndex = 3;
            // 
            // lblVoto
            // 
            this.lblVoto.AutoSize = true;
            this.lblVoto.Location = new System.Drawing.Point(23, 48);
            this.lblVoto.Name = "lblVoto";
            this.lblVoto.Size = new System.Drawing.Size(29, 13);
            this.lblVoto.TabIndex = 2;
            this.lblVoto.Text = "Voto";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(110, 71);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBonus.TabIndex = 5;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(23, 74);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(37, 13);
            this.lblBonus.TabIndex = 4;
            this.lblBonus.Text = "Bonus";
            // 
            // txtImpFinale
            // 
            this.txtImpFinale.Location = new System.Drawing.Point(110, 146);
            this.txtImpFinale.Name = "txtImpFinale";
            this.txtImpFinale.Size = new System.Drawing.Size(100, 20);
            this.txtImpFinale.TabIndex = 7;
            // 
            // lblBorsa
            // 
            this.lblBorsa.AutoSize = true;
            this.lblBorsa.Location = new System.Drawing.Point(23, 149);
            this.lblBorsa.Name = "lblBorsa";
            this.lblBorsa.Size = new System.Drawing.Size(71, 13);
            this.lblBorsa.TabIndex = 6;
            this.lblBorsa.Text = "Importo borsa";
            // 
            // txtMinorenne
            // 
            this.txtMinorenne.Location = new System.Drawing.Point(26, 172);
            this.txtMinorenne.Name = "txtMinorenne";
            this.txtMinorenne.Size = new System.Drawing.Size(184, 20);
            this.txtMinorenne.TabIndex = 9;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(110, 108);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(100, 23);
            this.btnCalcola.TabIndex = 10;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 210);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.txtMinorenne);
            this.Controls.Add(this.txtImpFinale);
            this.Controls.Add(this.lblBorsa);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.lblVoto);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Label lblVoto;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.TextBox txtImpFinale;
        private System.Windows.Forms.Label lblBorsa;
        private System.Windows.Forms.TextBox txtMinorenne;
        private System.Windows.Forms.Button btnCalcola;
    }
}

