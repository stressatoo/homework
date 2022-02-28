namespace for_2
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
            this.txtnDip = new System.Windows.Forms.TextBox();
            this.txtOlp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.lstNome = new System.Windows.Forms.ListBox();
            this.lstTasso = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMess = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero dipendenti";
            // 
            // txtnDip
            // 
            this.txtnDip.Location = new System.Drawing.Point(226, 19);
            this.txtnDip.Name = "txtnDip";
            this.txtnDip.Size = new System.Drawing.Size(100, 20);
            this.txtnDip.TabIndex = 1;
            // 
            // txtOlp
            // 
            this.txtOlp.Location = new System.Drawing.Point(226, 45);
            this.txtOlp.Name = "txtOlp";
            this.txtOlp.Size = new System.Drawing.Size(100, 20);
            this.txtOlp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ore lavorative previste";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(108, 83);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(124, 23);
            this.btnCalcola.TabIndex = 4;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // lstNome
            // 
            this.lstNome.FormattingEnabled = true;
            this.lstNome.Location = new System.Drawing.Point(26, 151);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(59, 121);
            this.lstNome.TabIndex = 5;
            // 
            // lstTasso
            // 
            this.lstTasso.FormattingEnabled = true;
            this.lstTasso.Location = new System.Drawing.Point(108, 151);
            this.lstTasso.Name = "lstTasso";
            this.lstTasso.Size = new System.Drawing.Size(73, 121);
            this.lstTasso.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "% assenteismo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Messaggio";
            // 
            // lstMess
            // 
            this.lstMess.FormattingEnabled = true;
            this.lstMess.Location = new System.Drawing.Point(204, 151);
            this.lstMess.Name = "lstMess";
            this.lstMess.Size = new System.Drawing.Size(122, 121);
            this.lstMess.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 294);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstMess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstTasso);
            this.Controls.Add(this.lstNome);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.txtOlp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnDip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnDip;
        private System.Windows.Forms.TextBox txtOlp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.ListBox lstNome;
        private System.Windows.Forms.ListBox lstTasso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstMess;
    }
}

