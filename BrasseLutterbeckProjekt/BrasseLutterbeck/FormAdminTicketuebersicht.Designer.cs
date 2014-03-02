namespace BrasseLutterbeck
{
    partial class FormAdminTicketuebersicht
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGespraechsuebersicht = new System.Windows.Forms.Button();
            this.dateTimePickerBis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVon = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.buttonTicketSchliessen = new System.Windows.Forms.Button();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.textBoxTicketSuchen = new System.Windows.Forms.TextBox();
            this.buttonSuchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "- Ticketübersicht -";
            // 
            // buttonGespraechsuebersicht
            // 
            this.buttonGespraechsuebersicht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGespraechsuebersicht.BackColor = System.Drawing.Color.DarkGray;
            this.buttonGespraechsuebersicht.Enabled = false;
            this.buttonGespraechsuebersicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGespraechsuebersicht.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGespraechsuebersicht.Location = new System.Drawing.Point(707, 520);
            this.buttonGespraechsuebersicht.Name = "buttonGespraechsuebersicht";
            this.buttonGespraechsuebersicht.Size = new System.Drawing.Size(153, 46);
            this.buttonGespraechsuebersicht.TabIndex = 21;
            this.buttonGespraechsuebersicht.Text = "Gesprächsübersicht";
            this.buttonGespraechsuebersicht.UseVisualStyleBackColor = false;
            this.buttonGespraechsuebersicht.Click += new System.EventHandler(this.buttonGespraechsuebersicht_Click);
            // 
            // dateTimePickerBis
            // 
            this.dateTimePickerBis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBis.Location = new System.Drawing.Point(213, 104);
            this.dateTimePickerBis.Name = "dateTimePickerBis";
            this.dateTimePickerBis.Size = new System.Drawing.Size(111, 23);
            this.dateTimePickerBis.TabIndex = 20;
            // 
            // dateTimePickerVon
            // 
            this.dateTimePickerVon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerVon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVon.Location = new System.Drawing.Point(57, 104);
            this.dateTimePickerVon.Name = "dateTimePickerVon";
            this.dateTimePickerVon.Size = new System.Drawing.Size(111, 23);
            this.dateTimePickerVon.TabIndex = 19;
            this.dateTimePickerVon.Value = new System.DateTime(2014, 1, 1, 8, 32, 0, 0);
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AllowUserToDeleteRows = false;
            this.dataGridViewTickets.AllowUserToResizeRows = false;
            this.dataGridViewTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTickets.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewTickets.Location = new System.Drawing.Point(15, 133);
            this.dataGridViewTickets.MultiSelect = false;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.Size = new System.Drawing.Size(845, 381);
            this.dataGridViewTickets.TabIndex = 18;
            this.dataGridViewTickets.SelectionChanged += new System.EventHandler(this.dataGridViewTickets_SelectionChanged);
            // 
            // buttonTicketSchliessen
            // 
            this.buttonTicketSchliessen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTicketSchliessen.BackColor = System.Drawing.Color.DarkGray;
            this.buttonTicketSchliessen.Enabled = false;
            this.buttonTicketSchliessen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketSchliessen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketSchliessen.Location = new System.Drawing.Point(15, 520);
            this.buttonTicketSchliessen.Name = "buttonTicketSchliessen";
            this.buttonTicketSchliessen.Size = new System.Drawing.Size(153, 46);
            this.buttonTicketSchliessen.TabIndex = 17;
            this.buttonTicketSchliessen.Text = "Ticket schließen";
            this.buttonTicketSchliessen.UseVisualStyleBackColor = false;
            this.buttonTicketSchliessen.Click += new System.EventHandler(this.buttonTicketSchliessen_Click);
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnzeigen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnzeigen.Location = new System.Drawing.Point(330, 102);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(107, 25);
            this.buttonAnzeigen.TabIndex = 16;
            this.buttonAnzeigen.Text = "Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = false;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "bis :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Von :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 13;
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
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.übersichtToolStripMenuItem});
            this.ticketsToolStripMenuItem.Enabled = false;
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // übersichtToolStripMenuItem
            // 
            this.übersichtToolStripMenuItem.Name = "übersichtToolStripMenuItem";
            this.übersichtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.übersichtToolStripMenuItem.Text = "Übersicht";
            this.übersichtToolStripMenuItem.Click += new System.EventHandler(this.übersichtToolStripMenuItem_Click);
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
            this.übersichtToolStripMenuItem1.Click += new System.EventHandler(this.übersichtToolStripMenuItem1_Click);
            // 
            // neuesGerätToolStripMenuItem
            // 
            this.neuesGerätToolStripMenuItem.Name = "neuesGerätToolStripMenuItem";
            this.neuesGerätToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.neuesGerätToolStripMenuItem.Text = "Neues Gerät";
            this.neuesGerätToolStripMenuItem.Click += new System.EventHandler(this.neuesGerätToolStripMenuItem_Click);
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
            this.übersichtToolStripMenuItem2.Click += new System.EventHandler(this.übersichtToolStripMenuItem2_Click);
            // 
            // neuerMitarbeiterToolStripMenuItem
            // 
            this.neuerMitarbeiterToolStripMenuItem.Name = "neuerMitarbeiterToolStripMenuItem";
            this.neuerMitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.neuerMitarbeiterToolStripMenuItem.Text = "Neuer Mitarbeiter";
            this.neuerMitarbeiterToolStripMenuItem.Click += new System.EventHandler(this.neuerMitarbeiterToolStripMenuItem_Click);
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
            this.persönlicheDatenToolStripMenuItem.Click += new System.EventHandler(this.persönlicheDatenToolStripMenuItem_Click);
            // 
            // textBoxTicketSuchen
            // 
            this.textBoxTicketSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTicketSuchen.Location = new System.Drawing.Point(443, 107);
            this.textBoxTicketSuchen.Name = "textBoxTicketSuchen";
            this.textBoxTicketSuchen.Size = new System.Drawing.Size(293, 20);
            this.textBoxTicketSuchen.TabIndex = 23;
            this.textBoxTicketSuchen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTicketSuchen_KeyDown);
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuchen.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuchen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuchen.Location = new System.Drawing.Point(742, 104);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(107, 25);
            this.buttonSuchen.TabIndex = 24;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = false;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // FormAdminTicketuebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 578);
            this.Controls.Add(this.buttonSuchen);
            this.Controls.Add(this.textBoxTicketSuchen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGespraechsuebersicht);
            this.Controls.Add(this.dateTimePickerBis);
            this.Controls.Add(this.dateTimePickerVon);
            this.Controls.Add(this.dataGridViewTickets);
            this.Controls.Add(this.buttonTicketSchliessen);
            this.Controls.Add(this.buttonAnzeigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminTicketuebersicht";
            this.Text = "IT-Support Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminTicketuebersicht_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGespraechsuebersicht;
        private System.Windows.Forms.DateTimePicker dateTimePickerBis;
        private System.Windows.Forms.DateTimePicker dateTimePickerVon;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Button buttonTicketSchliessen;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geräteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persönlicheDatenToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTicketSuchen;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem neuerMitarbeiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesGerätToolStripMenuItem;
    }
}