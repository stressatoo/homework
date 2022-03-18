namespace ciclofor1_17_03_22
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
            this.txtMediaStature = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(75, 34);
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
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Media stature";
            // 
            // txtMediaStature
            // 
            this.txtMediaStature.Location = new System.Drawing.Point(100, 104);
            this.txtMediaStature.Name = "txtMediaStature";
            this.txtMediaStature.Size = new System.Drawing.Size(100, 20);
            this.txtMediaStature.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 141);
            this.Controls.Add(this.txtMediaStature);
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
        private System.Windows.Forms.TextBox txtMediaStature;
    }
}

