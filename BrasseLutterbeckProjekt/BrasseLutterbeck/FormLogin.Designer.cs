namespace BrasseLutterbeck
{
    partial class FormLogin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAnmelden = new System.Windows.Forms.Button();
            this.checkBoxMerken = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirmaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKennwort = new System.Windows.Forms.TextBox();
            this.textBoxMitarbeiterID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnmelden
            // 
            this.buttonAnmelden.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAnmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnmelden.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnmelden.Location = new System.Drawing.Point(259, 242);
            this.buttonAnmelden.Name = "buttonAnmelden";
            this.buttonAnmelden.Size = new System.Drawing.Size(105, 35);
            this.buttonAnmelden.TabIndex = 5;
            this.buttonAnmelden.Text = "Anmelden";
            this.buttonAnmelden.UseVisualStyleBackColor = false;
            this.buttonAnmelden.Click += new System.EventHandler(this.buttonAnmelden_Click);
            // 
            // checkBoxMerken
            // 
            this.checkBoxMerken.AutoSize = true;
            this.checkBoxMerken.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMerken.Location = new System.Drawing.Point(121, 192);
            this.checkBoxMerken.Name = "checkBoxMerken";
            this.checkBoxMerken.Size = new System.Drawing.Size(138, 20);
            this.checkBoxMerken.TabIndex = 4;
            this.checkBoxMerken.Text = "Anmeldung merken";
            this.checkBoxMerken.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firma-ID :";
            // 
            // textBoxFirmaID
            // 
            this.textBoxFirmaID.Location = new System.Drawing.Point(121, 89);
            this.textBoxFirmaID.Name = "textBoxFirmaID";
            this.textBoxFirmaID.Size = new System.Drawing.Size(159, 20);
            this.textBoxFirmaID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "IT-Support";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mitarbeiter-ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kennwort :";
            // 
            // textBoxKennwort
            // 
            this.textBoxKennwort.Location = new System.Drawing.Point(121, 166);
            this.textBoxKennwort.Name = "textBoxKennwort";
            this.textBoxKennwort.PasswordChar = '*';
            this.textBoxKennwort.Size = new System.Drawing.Size(159, 20);
            this.textBoxKennwort.TabIndex = 3;
            this.textBoxKennwort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKennwort_KeyDown);
            // 
            // textBoxMitarbeiterID
            // 
            this.textBoxMitarbeiterID.Location = new System.Drawing.Point(121, 128);
            this.textBoxMitarbeiterID.Name = "textBoxMitarbeiterID";
            this.textBoxMitarbeiterID.Size = new System.Drawing.Size(159, 20);
            this.textBoxMitarbeiterID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "- Login -";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMitarbeiterID);
            this.Controls.Add(this.textBoxKennwort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirmaID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMerken);
            this.Controls.Add(this.buttonAnmelden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(392, 328);
            this.Name = "FormLogin";
            this.Text = "IT-Support Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnmelden;
        private System.Windows.Forms.CheckBox checkBoxMerken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirmaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKennwort;
        private System.Windows.Forms.TextBox textBoxMitarbeiterID;
        private System.Windows.Forms.Label label5;
    }
}

