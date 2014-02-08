namespace BrasseLutterbeck
{
    partial class FormAdminMitarbeiteruebersicht
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.textBoxGeraeteSuchen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMitarbeiter = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übersichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geräteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übersichtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesGerätToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übersichtToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.neuerMitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persönlicheDatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMitarbeiter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSpeichern.Enabled = false;
            this.buttonSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeichern.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeichern.Location = new System.Drawing.Point(697, 386);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(153, 46);
            this.buttonSpeichern.TabIndex = 4;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = false;
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuchen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuchen.Location = new System.Drawing.Point(315, 96);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(107, 25);
            this.buttonSuchen.TabIndex = 2;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = false;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // textBoxGeraeteSuchen
            // 
            this.textBoxGeraeteSuchen.Location = new System.Drawing.Point(16, 99);
            this.textBoxGeraeteSuchen.Name = "textBoxGeraeteSuchen";
            this.textBoxGeraeteSuchen.Size = new System.Drawing.Size(293, 20);
            this.textBoxGeraeteSuchen.TabIndex = 1;
            this.textBoxGeraeteSuchen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGeraeteSuchen_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "- Mitarbeiterübersicht -";
            // 
            // dataGridViewMitarbeiter
            // 
            this.dataGridViewMitarbeiter.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMitarbeiter.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewMitarbeiter.Location = new System.Drawing.Point(16, 125);
            this.dataGridViewMitarbeiter.Name = "dataGridViewMitarbeiter";
            this.dataGridViewMitarbeiter.Size = new System.Drawing.Size(834, 255);
            this.dataGridViewMitarbeiter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 48;
            this.label1.Text = "IT-Support Admin";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketsToolStripMenuItem,
            this.geräteToolStripMenuItem,
            this.mitarbeiterToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.übersichtToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // übersichtToolStripMenuItem
            // 
            this.übersichtToolStripMenuItem.Name = "übersichtToolStripMenuItem";
            this.übersichtToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.übersichtToolStripMenuItem.Text = "Übersicht";
            // 
            // geräteToolStripMenuItem
            // 
            this.geräteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.übersichtToolStripMenuItem1,
            this.neuesGerätToolStripMenuItem});
            this.geräteToolStripMenuItem.Name = "geräteToolStripMenuItem";
            this.geräteToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.geräteToolStripMenuItem.Text = "Geräte";
            // 
            // übersichtToolStripMenuItem1
            // 
            this.übersichtToolStripMenuItem1.Name = "übersichtToolStripMenuItem1";
            this.übersichtToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.übersichtToolStripMenuItem1.Text = "Übersicht";
            // 
            // neuesGerätToolStripMenuItem
            // 
            this.neuesGerätToolStripMenuItem.Name = "neuesGerätToolStripMenuItem";
            this.neuesGerätToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.neuesGerätToolStripMenuItem.Text = "Neues Gerät";
            // 
            // mitarbeiterToolStripMenuItem
            // 
            this.mitarbeiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.übersichtToolStripMenuItem2,
            this.neuerMitarbeiterToolStripMenuItem});
            this.mitarbeiterToolStripMenuItem.Name = "mitarbeiterToolStripMenuItem";
            this.mitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.mitarbeiterToolStripMenuItem.Text = "Mitarbeiter";
            // 
            // übersichtToolStripMenuItem2
            // 
            this.übersichtToolStripMenuItem2.Name = "übersichtToolStripMenuItem2";
            this.übersichtToolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.übersichtToolStripMenuItem2.Text = "Übersicht";
            // 
            // neuerMitarbeiterToolStripMenuItem
            // 
            this.neuerMitarbeiterToolStripMenuItem.Name = "neuerMitarbeiterToolStripMenuItem";
            this.neuerMitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.neuerMitarbeiterToolStripMenuItem.Text = "Neuer Mitarbeiter";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.persönlicheDatenToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // persönlicheDatenToolStripMenuItem
            // 
            this.persönlicheDatenToolStripMenuItem.Name = "persönlicheDatenToolStripMenuItem";
            this.persönlicheDatenToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.persönlicheDatenToolStripMenuItem.Text = "Persönliche Daten";
            // 
            // FormAdminMitarbeiteruebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 441);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.buttonSuchen);
            this.Controls.Add(this.textBoxGeraeteSuchen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMitarbeiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(877, 479);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(877, 479);
            this.Name = "FormAdminMitarbeiteruebersicht";
            this.Text = "IT-Support Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMitarbeiter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.TextBox textBoxGeraeteSuchen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMitarbeiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geräteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neuesGerätToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem neuerMitarbeiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persönlicheDatenToolStripMenuItem;
    }
}