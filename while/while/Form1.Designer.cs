namespace @while
{
    partial class While_DoWhile
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.chkDoWhile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(133, 23);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci un numero:";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(64, 132);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(120, 251);
            this.lstOutput.TabIndex = 2;
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(85, 90);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(75, 23);
            this.btnEsegui.TabIndex = 3;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // chkDoWhile
            // 
            this.chkDoWhile.AutoSize = true;
            this.chkDoWhile.Location = new System.Drawing.Point(81, 55);
            this.chkDoWhile.Name = "chkDoWhile";
            this.chkDoWhile.Size = new System.Drawing.Size(87, 17);
            this.chkDoWhile.TabIndex = 4;
            this.chkDoWhile.Text = "Usa do while";
            this.chkDoWhile.UseVisualStyleBackColor = true;
            // 
            // While_DoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 413);
            this.Controls.Add(this.chkDoWhile);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Name = "While_DoWhile";
            this.Text = "While_DoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.CheckBox chkDoWhile;
    }
}

