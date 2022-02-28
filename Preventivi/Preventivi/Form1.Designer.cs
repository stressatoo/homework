
namespace Preventivi
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
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.txtCrc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezzoTot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costo manodopera / ora";
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(174, 28);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(100, 20);
            this.txtCmd.TabIndex = 1;
            // 
            // txtCrc
            // 
            this.txtCrc.Location = new System.Drawing.Point(174, 54);
            this.txtCrc.Name = "txtCrc";
            this.txtCrc.Size = new System.Drawing.Size(100, 20);
            this.txtCrc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Costo ricambi";
            // 
            // txtOre
            // 
            this.txtOre.Location = new System.Drawing.Point(174, 80);
            this.txtOre.Name = "txtOre";
            this.txtOre.Size = new System.Drawing.Size(100, 20);
            this.txtOre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ore impiegate";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(174, 106);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aliquota";
            // 
            // txtPrezzoTot
            // 
            this.txtPrezzoTot.Location = new System.Drawing.Point(174, 181);
            this.txtPrezzoTot.Name = "txtPrezzoTot";
            this.txtPrezzoTot.Size = new System.Drawing.Size(100, 20);
            this.txtPrezzoTot.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prezzo totale";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcola";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrezzoTot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCrc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.TextBox txtCrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrezzoTot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

