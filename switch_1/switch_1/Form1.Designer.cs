namespace switch_1
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
            this.cmbMese = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.chkBisestile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbMese
            // 
            this.cmbMese.FormattingEnabled = true;
            this.cmbMese.Items.AddRange(new object[] {
            "Gennaio",
            "Febbraio",
            "Marzo",
            "Aprile",
            "Maggio",
            "Giugno",
            "Luglio",
            "Agosto",
            "Settembre",
            "Novembre",
            "Dicembre"});
            this.cmbMese.Location = new System.Drawing.Point(155, 21);
            this.cmbMese.Name = "cmbMese";
            this.cmbMese.Size = new System.Drawing.Size(121, 21);
            this.cmbMese.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scegli un mese:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(67, 81);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(10, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = " ";
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(155, 49);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(121, 23);
            this.btnEsegui.TabIndex = 3;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // chkBisestile
            // 
            this.chkBisestile.AutoSize = true;
            this.chkBisestile.Location = new System.Drawing.Point(299, 23);
            this.chkBisestile.Name = "chkBisestile";
            this.chkBisestile.Size = new System.Drawing.Size(91, 17);
            this.chkBisestile.TabIndex = 4;
            this.chkBisestile.Text = "Anno bisestile";
            this.chkBisestile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 117);
            this.Controls.Add(this.chkBisestile);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMese);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.CheckBox chkBisestile;
    }
}

