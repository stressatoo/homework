namespace WindowsFormsApp1
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
            this.txtnClienti = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.lstImporti = new System.Windows.Forms.ListBox();
            this.lstTarghe = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnClienti
            // 
            this.txtnClienti.Location = new System.Drawing.Point(225, 37);
            this.txtnClienti.Name = "txtnClienti";
            this.txtnClienti.Size = new System.Drawing.Size(100, 20);
            this.txtnClienti.TabIndex = 3;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(225, 177);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(75, 23);
            this.btnCalcola.TabIndex = 4;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // lstImporti
            // 
            this.lstImporti.FormattingEnabled = true;
            this.lstImporti.Location = new System.Drawing.Point(205, 281);
            this.lstImporti.Name = "lstImporti";
            this.lstImporti.Size = new System.Drawing.Size(120, 121);
            this.lstImporti.TabIndex = 5;
            // 
            // lstTarghe
            // 
            this.lstTarghe.FormattingEnabled = true;
            this.lstTarghe.Location = new System.Drawing.Point(38, 281);
            this.lstTarghe.Name = "lstTarghe";
            this.lstTarghe.Size = new System.Drawing.Size(120, 121);
            this.lstTarghe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Targa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Importo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(225, 82);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(100, 20);
            this.txtP1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "P1";
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(225, 108);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(100, 20);
            this.txtP2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "P2";
            // 
            // txtP3
            // 
            this.txtP3.Location = new System.Drawing.Point(225, 134);
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(100, 20);
            this.txtP3.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "P3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "n Clienti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 434);
            this.Controls.Add(this.txtP3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstTarghe);
            this.Controls.Add(this.lstImporti);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtnClienti);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnClienti;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.ListBox lstImporti;
        private System.Windows.Forms.ListBox lstTarghe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}

