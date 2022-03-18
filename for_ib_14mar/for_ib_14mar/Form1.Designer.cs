namespace for_ib_14mar
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
            this.txtNPersone = new System.Windows.Forms.TextBox();
            this.btnVai = new System.Windows.Forms.Button();
            this.lstRis = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncTot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° persone";
            // 
            // txtNPersone
            // 
            this.txtNPersone.Location = new System.Drawing.Point(91, 20);
            this.txtNPersone.Name = "txtNPersone";
            this.txtNPersone.Size = new System.Drawing.Size(100, 20);
            this.txtNPersone.TabIndex = 1;
            // 
            // btnVai
            // 
            this.btnVai.Location = new System.Drawing.Point(103, 62);
            this.btnVai.Name = "btnVai";
            this.btnVai.Size = new System.Drawing.Size(75, 23);
            this.btnVai.TabIndex = 2;
            this.btnVai.Text = "Vai";
            this.btnVai.UseVisualStyleBackColor = true;
            this.btnVai.Click += new System.EventHandler(this.btnVai_Click);
            // 
            // lstRis
            // 
            this.lstRis.FormattingEnabled = true;
            this.lstRis.Location = new System.Drawing.Point(82, 114);
            this.lstRis.Name = "lstRis";
            this.lstRis.Size = new System.Drawing.Size(120, 134);
            this.lstRis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Importi per persone";
            // 
            // txtIncTot
            // 
            this.txtIncTot.Location = new System.Drawing.Point(91, 263);
            this.txtIncTot.Name = "txtIncTot";
            this.txtIncTot.Size = new System.Drawing.Size(100, 20);
            this.txtIncTot.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Incasso totale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 329);
            this.Controls.Add(this.txtIncTot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstRis);
            this.Controls.Add(this.btnVai);
            this.Controls.Add(this.txtNPersone);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Biglietteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNPersone;
        private System.Windows.Forms.Button btnVai;
        private System.Windows.Forms.ListBox lstRis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIncTot;
        private System.Windows.Forms.Label label3;
    }
}

