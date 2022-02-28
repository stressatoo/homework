
namespace IMC
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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtStatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXPeso = new System.Windows.Forms.TextBox();
            this.txtSupera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso in kg";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(167, 24);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // txtStatura
            // 
            this.txtStatura.Location = new System.Drawing.Point(167, 50);
            this.txtStatura.Name = "txtStatura";
            this.txtStatura.Size = new System.Drawing.Size(100, 20);
            this.txtStatura.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Statura in m";
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(167, 148);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(100, 20);
            this.txtIMC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Indica di Massa Corporea";
            // 
            // txtXPeso
            // 
            this.txtXPeso.Location = new System.Drawing.Point(167, 174);
            this.txtXPeso.Name = "txtXPeso";
            this.txtXPeso.Size = new System.Drawing.Size(100, 20);
            this.txtXPeso.TabIndex = 7;
            // 
            // txtSupera
            // 
            this.txtSupera.Location = new System.Drawing.Point(167, 200);
            this.txtSupera.Name = "txtSupera";
            this.txtSupera.Size = new System.Drawing.Size(100, 20);
            this.txtSupera.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Di quanto supera 25";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(167, 98);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(100, 23);
            this.btnCalcola.TabIndex = 10;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.txtSupera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtXPeso);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtStatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXPeso;
        private System.Windows.Forms.TextBox txtSupera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcola;
    }
}

