namespace for2_17_03_22
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
            this.txtNPersone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotStipendi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNMaschi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNFemmine = new System.Windows.Forms.TextBox();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNPersone
            // 
            this.txtNPersone.Location = new System.Drawing.Point(158, 31);
            this.txtNPersone.Name = "txtNPersone";
            this.txtNPersone.Size = new System.Drawing.Size(100, 20);
            this.txtNPersone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero persone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Totale stipendi";
            // 
            // txtTotStipendi
            // 
            this.txtTotStipendi.Location = new System.Drawing.Point(158, 138);
            this.txtTotStipendi.Name = "txtTotStipendi";
            this.txtTotStipendi.Size = new System.Drawing.Size(100, 20);
            this.txtTotStipendi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "N° dei maschi";
            // 
            // txtNMaschi
            // 
            this.txtNMaschi.Location = new System.Drawing.Point(158, 164);
            this.txtNMaschi.Name = "txtNMaschi";
            this.txtNMaschi.Size = new System.Drawing.Size(100, 20);
            this.txtNMaschi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "N° delle femmine";
            // 
            // txtNFemmine
            // 
            this.txtNFemmine.Location = new System.Drawing.Point(158, 190);
            this.txtNFemmine.Name = "txtNFemmine";
            this.txtNFemmine.Size = new System.Drawing.Size(100, 20);
            this.txtNFemmine.TabIndex = 6;
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(158, 81);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(100, 23);
            this.btnEsegui.TabIndex = 8;
            this.btnEsegui.Text = "Esegui";
            this.btnEsegui.UseVisualStyleBackColor = true;
            this.btnEsegui.Click += new System.EventHandler(this.btnEsegui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 246);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNFemmine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNMaschi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotStipendi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNPersone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNPersone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotStipendi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNMaschi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNFemmine;
        private System.Windows.Forms.Button btnEsegui;
    }
}

