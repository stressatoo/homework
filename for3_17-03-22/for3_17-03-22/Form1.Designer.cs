namespace for3_17_03_22
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
            this.btnEsegui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpesa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(107, 36);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(75, 23);
            this.btnEsegui.TabIndex = 0;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spesa totale annua";
            // 
            // txtSpesa
            // 
            this.txtSpesa.Location = new System.Drawing.Point(149, 108);
            this.txtSpesa.Name = "txtSpesa";
            this.txtSpesa.Size = new System.Drawing.Size(100, 20);
            this.txtSpesa.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 152);
            this.Controls.Add(this.txtSpesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEsegui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEsegui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpesa;
    }
}

