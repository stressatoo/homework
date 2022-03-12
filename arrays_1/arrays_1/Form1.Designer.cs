namespace arrays_1
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
            this.lstArray = new System.Windows.Forms.ListBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.txtContenuto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDimVettore = new System.Windows.Forms.TextBox();
            this.btnImposta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstArray
            // 
            this.lstArray.FormattingEnabled = true;
            this.lstArray.Location = new System.Drawing.Point(139, 97);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(120, 199);
            this.lstArray.TabIndex = 0;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(276, 39);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 1;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            // 
            // txtContenuto
            // 
            this.txtContenuto.Location = new System.Drawing.Point(139, 41);
            this.txtContenuto.Name = "txtContenuto";
            this.txtContenuto.Size = new System.Drawing.Size(119, 20);
            this.txtContenuto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contenuto del vettore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valori del vettore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "n° Indici del vettore";
            // 
            // txtDimVettore
            // 
            this.txtDimVettore.Location = new System.Drawing.Point(139, 12);
            this.txtDimVettore.Name = "txtDimVettore";
            this.txtDimVettore.Size = new System.Drawing.Size(119, 20);
            this.txtDimVettore.TabIndex = 9;
            // 
            // btnImposta
            // 
            this.btnImposta.Location = new System.Drawing.Point(276, 10);
            this.btnImposta.Name = "btnImposta";
            this.btnImposta.Size = new System.Drawing.Size(75, 23);
            this.btnImposta.TabIndex = 8;
            this.btnImposta.Text = "Imposta";
            this.btnImposta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDimVettore);
            this.Controls.Add(this.btnImposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContenuto);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.lstArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstArray;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.TextBox txtContenuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDimVettore;
        private System.Windows.Forms.Button btnImposta;
    }
}

