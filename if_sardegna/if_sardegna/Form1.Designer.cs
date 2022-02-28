
namespace if_sardegna
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
            this.txtCostoFisso = new System.Windows.Forms.TextBox();
            this.txtCilindrata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegione = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.txtTotale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costo fisso";
            // 
            // txtCostoFisso
            // 
            this.txtCostoFisso.Location = new System.Drawing.Point(190, 31);
            this.txtCostoFisso.Name = "txtCostoFisso";
            this.txtCostoFisso.Size = new System.Drawing.Size(100, 20);
            this.txtCostoFisso.TabIndex = 1;
            // 
            // txtCilindrata
            // 
            this.txtCilindrata.Location = new System.Drawing.Point(190, 57);
            this.txtCilindrata.Name = "txtCilindrata";
            this.txtCilindrata.Size = new System.Drawing.Size(100, 20);
            this.txtCilindrata.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cilindrata";
            // 
            // txtRegione
            // 
            this.txtRegione.Location = new System.Drawing.Point(190, 83);
            this.txtRegione.Name = "txtRegione";
            this.txtRegione.Size = new System.Drawing.Size(100, 20);
            this.txtRegione.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Regione di residenza";
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(190, 124);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(100, 23);
            this.btnEsegui.TabIndex = 6;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // txtTotale
            // 
            this.txtTotale.Location = new System.Drawing.Point(190, 170);
            this.txtTotale.Name = "txtTotale";
            this.txtTotale.Size = new System.Drawing.Size(100, 20);
            this.txtTotale.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Totale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 215);
            this.Controls.Add(this.txtTotale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.txtRegione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCilindrata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCostoFisso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostoFisso;
        private System.Windows.Forms.TextBox txtCilindrata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.TextBox txtTotale;
        private System.Windows.Forms.Label label4;
    }
}

