namespace for4_18_03_22
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
            this.txt_nRedditi = new System.Windows.Forms.TextBox();
            this.lstReddito = new System.Windows.Forms.ListBox();
            this.txt_nRedditiF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nRedditiS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstTassa = new System.Windows.Forms.ListBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero redditi";
            // 
            // txt_nRedditi
            // 
            this.txt_nRedditi.Location = new System.Drawing.Point(210, 25);
            this.txt_nRedditi.Name = "txt_nRedditi";
            this.txt_nRedditi.Size = new System.Drawing.Size(100, 20);
            this.txt_nRedditi.TabIndex = 1;
            // 
            // lstReddito
            // 
            this.lstReddito.FormattingEnabled = true;
            this.lstReddito.Location = new System.Drawing.Point(48, 193);
            this.lstReddito.Name = "lstReddito";
            this.lstReddito.Size = new System.Drawing.Size(120, 95);
            this.lstReddito.TabIndex = 2;
            // 
            // txt_nRedditiF
            // 
            this.txt_nRedditiF.Location = new System.Drawing.Point(210, 103);
            this.txt_nRedditiF.Name = "txt_nRedditiF";
            this.txt_nRedditiF.ReadOnly = true;
            this.txt_nRedditiF.Size = new System.Drawing.Size(100, 20);
            this.txt_nRedditiF.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "N° dei redditi fino a 3.000€";
            // 
            // txt_nRedditiS
            // 
            this.txt_nRedditiS.Location = new System.Drawing.Point(210, 127);
            this.txt_nRedditiS.Name = "txt_nRedditiS";
            this.txt_nRedditiS.ReadOnly = true;
            this.txt_nRedditiS.Size = new System.Drawing.Size(100, 20);
            this.txt_nRedditiS.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "N° dei redditi oltre 3.000€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reddito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tassa";
            // 
            // lstTassa
            // 
            this.lstTassa.FormattingEnabled = true;
            this.lstTassa.Location = new System.Drawing.Point(203, 193);
            this.lstTassa.Name = "lstTassa";
            this.lstTassa.Size = new System.Drawing.Size(120, 95);
            this.lstTassa.TabIndex = 10;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(210, 63);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(100, 23);
            this.btnCalcola.TabIndex = 12;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 318);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstTassa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nRedditiS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nRedditiF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstReddito);
            this.Controls.Add(this.txt_nRedditi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nRedditi;
        private System.Windows.Forms.ListBox lstReddito;
        private System.Windows.Forms.TextBox txt_nRedditiF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nRedditiS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstTassa;
        private System.Windows.Forms.Button btnCalcola;
    }
}

