namespace pedaggi
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
            this.btnCalcola = new System.Windows.Forms.Button();
            this.lstTarghe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCDP = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCDA = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstKmPerc = new System.Windows.Forms.ListBox();
            this.txtSomma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstImp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(264, 12);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(75, 23);
            this.btnCalcola.TabIndex = 0;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // lstTarghe
            // 
            this.lstTarghe.FormattingEnabled = true;
            this.lstTarghe.Location = new System.Drawing.Point(28, 74);
            this.lstTarghe.Name = "lstTarghe";
            this.lstTarghe.Size = new System.Drawing.Size(120, 199);
            this.lstTarghe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Targa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Città di partenza";
            // 
            // lstCDP
            // 
            this.lstCDP.FormattingEnabled = true;
            this.lstCDP.Location = new System.Drawing.Point(170, 74);
            this.lstCDP.Name = "lstCDP";
            this.lstCDP.Size = new System.Drawing.Size(120, 199);
            this.lstCDP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Città di arrivo";
            // 
            // lstCDA
            // 
            this.lstCDA.FormattingEnabled = true;
            this.lstCDA.Location = new System.Drawing.Point(312, 74);
            this.lstCDA.Name = "lstCDA";
            this.lstCDA.Size = new System.Drawing.Size(120, 199);
            this.lstCDA.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Km percorsi";
            // 
            // lstKmPerc
            // 
            this.lstKmPerc.FormattingEnabled = true;
            this.lstKmPerc.Location = new System.Drawing.Point(454, 74);
            this.lstKmPerc.Name = "lstKmPerc";
            this.lstKmPerc.Size = new System.Drawing.Size(120, 199);
            this.lstKmPerc.TabIndex = 7;
            // 
            // txtSomma
            // 
            this.txtSomma.Location = new System.Drawing.Point(248, 312);
            this.txtSomma.Name = "txtSomma";
            this.txtSomma.Size = new System.Drawing.Size(100, 20);
            this.txtSomma.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Somma importi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Importo pedaggio";
            // 
            // lstImp
            // 
            this.lstImp.FormattingEnabled = true;
            this.lstImp.Location = new System.Drawing.Point(597, 74);
            this.lstImp.Name = "lstImp";
            this.lstImp.Size = new System.Drawing.Size(120, 199);
            this.lstImp.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 359);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstImp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSomma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstKmPerc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCDA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCDP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTarghe);
            this.Controls.Add(this.btnCalcola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.ListBox lstTarghe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstKmPerc;
        private System.Windows.Forms.TextBox txtSomma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstImp;
    }
}

