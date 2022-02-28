namespace metro_framework
{
    partial class Sandbox
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
            this.mtr_chkTheme = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.mtrControl = new MetroSet_UI.Controls.MetroSetControlBox();
            this.mtrSwitch = new MetroSet_UI.Controls.MetroSetSwitch();
            this.metroSetProgressBar1 = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.SuspendLayout();
            // 
            // mtr_chkTheme
            // 
            this.mtr_chkTheme.BackColor = System.Drawing.Color.Transparent;
            this.mtr_chkTheme.BackgroundColor = System.Drawing.Color.White;
            this.mtr_chkTheme.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mtr_chkTheme.Checked = false;
            this.mtr_chkTheme.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtr_chkTheme.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.mtr_chkTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtr_chkTheme.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.mtr_chkTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mtr_chkTheme.IsDerivedStyle = true;
            this.mtr_chkTheme.Location = new System.Drawing.Point(305, 51);
            this.mtr_chkTheme.Name = "mtr_chkTheme";
            this.mtr_chkTheme.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.mtr_chkTheme.Size = new System.Drawing.Size(95, 16);
            this.mtr_chkTheme.Style = MetroSet_UI.Enums.Style.Light;
            this.mtr_chkTheme.StyleManager = null;
            this.mtr_chkTheme.TabIndex = 0;
            this.mtr_chkTheme.Text = "Dark theme";
            this.mtr_chkTheme.ThemeAuthor = "Narwin";
            this.mtr_chkTheme.ThemeName = "MetroLite";
            this.mtr_chkTheme.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.mtr_chkTheme_CheckedChanged);
            // 
            // mtrControl
            // 
            this.mtrControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtrControl.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mtrControl.CloseHoverForeColor = System.Drawing.Color.White;
            this.mtrControl.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.mtrControl.DisabledForeColor = System.Drawing.Color.DimGray;
            this.mtrControl.IsDerivedStyle = true;
            this.mtrControl.Location = new System.Drawing.Point(341, 4);
            this.mtrControl.MaximizeBox = true;
            this.mtrControl.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mtrControl.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.mtrControl.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.mtrControl.MinimizeBox = true;
            this.mtrControl.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.mtrControl.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.mtrControl.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.mtrControl.Name = "mtrControl";
            this.mtrControl.Size = new System.Drawing.Size(100, 25);
            this.mtrControl.Style = MetroSet_UI.Enums.Style.Light;
            this.mtrControl.StyleManager = null;
            this.mtrControl.TabIndex = 1;
            this.mtrControl.Text = "metroSetControlBox1";
            this.mtrControl.ThemeAuthor = "Narwin";
            this.mtrControl.ThemeName = "MetroLite";
            // 
            // mtrSwitch
            // 
            this.mtrSwitch.BackColor = System.Drawing.Color.Transparent;
            this.mtrSwitch.BackgroundColor = System.Drawing.Color.Empty;
            this.mtrSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.mtrSwitch.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtrSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.mtrSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtrSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.mtrSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.mtrSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.mtrSwitch.IsDerivedStyle = true;
            this.mtrSwitch.Location = new System.Drawing.Point(44, 258);
            this.mtrSwitch.Name = "mtrSwitch";
            this.mtrSwitch.Size = new System.Drawing.Size(58, 22);
            this.mtrSwitch.Style = MetroSet_UI.Enums.Style.Light;
            this.mtrSwitch.StyleManager = null;
            this.mtrSwitch.Switched = false;
            this.mtrSwitch.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.mtrSwitch.TabIndex = 2;
            this.mtrSwitch.Text = "metroSetSwitch1";
            this.mtrSwitch.ThemeAuthor = "Narwin";
            this.mtrSwitch.ThemeName = "MetroLite";
            this.mtrSwitch.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.mtrSwitch.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.mtrSwitch_SwitchedChanged);
            // 
            // metroSetProgressBar1
            // 
            this.metroSetProgressBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetProgressBar1.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar1.IsDerivedStyle = true;
            this.metroSetProgressBar1.Location = new System.Drawing.Point(44, 306);
            this.metroSetProgressBar1.Maximum = 100;
            this.metroSetProgressBar1.Minimum = 0;
            this.metroSetProgressBar1.Name = "metroSetProgressBar1";
            this.metroSetProgressBar1.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.metroSetProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar1.Size = new System.Drawing.Size(343, 23);
            this.metroSetProgressBar1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetProgressBar1.StyleManager = null;
            this.metroSetProgressBar1.TabIndex = 8;
            this.metroSetProgressBar1.Text = "metroSetProgressBar1";
            this.metroSetProgressBar1.ThemeAuthor = "Narwin";
            this.metroSetProgressBar1.ThemeName = "MetroLite";
            this.metroSetProgressBar1.Value = 0;
            // 
            // Sandbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(445, 396);
            this.Controls.Add(this.metroSetProgressBar1);
            this.Controls.Add(this.mtrSwitch);
            this.Controls.Add(this.mtrControl);
            this.Controls.Add(this.mtr_chkTheme);
            this.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Sandbox";
            this.SmallLineColor1 = System.Drawing.Color.IndianRed;
            this.SmallLineColor2 = System.Drawing.Color.IndianRed;
            this.Text = "Stress\' Sandbox";
            this.TextColor = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetCheckBox mtr_chkTheme;
        private MetroSet_UI.Controls.MetroSetControlBox mtrControl;
        private MetroSet_UI.Controls.MetroSetSwitch mtrSwitch;
        private MetroSet_UI.Controls.MetroSetProgressBar metroSetProgressBar1;
    }
}

