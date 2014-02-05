namespace BrasseLutterbeck
{
    partial class FormClientTicketuebersicht
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übersichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geräteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übersichtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persönlicheDatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.dateTimePickerVon = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGespraechsuebersicht = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketsToolStripMenuItem,
            this.geräteToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.übersichtToolStripMenuItem,
            this.neuesTicketToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // übersichtToolStripMenuItem
            // 
            this.übersichtToolStripMenuItem.Name = "übersichtToolStripMenuItem";
            this.übersichtToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.übersichtToolStripMenuItem.Text = "Übersicht";
            this.übersichtToolStripMenuItem.Click += new System.EventHandler(this.übersichtToolStripMenuItem_Click);
            // 
            // neuesTicketToolStripMenuItem
            // 
            this.neuesTicketToolStripMenuItem.Name = "neuesTicketToolStripMenuItem";
            this.neuesTicketToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.neuesTicketToolStripMenuItem.Text = "Neues Ticket";
            this.neuesTicketToolStripMenuItem.Click += new System.EventHandler(this.neuesTicketToolStripMenuItem_Click);
            // 
            // geräteToolStripMenuItem
            // 
            this.geräteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.übersichtToolStripMenuItem1});
            this.geräteToolStripMenuItem.Name = "geräteToolStripMenuItem";
            this.geräteToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.geräteToolStripMenuItem.Text = "Geräte";
            // 
            // übersichtToolStripMenuItem1
            // 
            this.übersichtToolStripMenuItem1.Name = "übersichtToolStripMenuItem1";
            this.übersichtToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.übersichtToolStripMenuItem1.Text = "Übersicht";
            this.übersichtToolStripMenuItem1.Click += new System.EventHandler(this.übersichtToolStripMenuItem1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "IT-Support Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Von :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "bis :";
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAnzeigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnzeigen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnzeigen.Location = new System.Drawing.Point(330, 97);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(107, 25);
            this.buttonAnzeigen.TabIndex = 4;
            this.buttonAnzeigen.Text = "Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = false;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
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
            this.dataGridViewTickets.Location = new System.Drawing.Point(15, 128);
            this.dataGridViewTickets.MultiSelect = false;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.Size = new System.Drawing.Size(834, 391);
            this.dataGridViewTickets.TabIndex = 7;
            this.dataGridViewTickets.SelectionChanged += new System.EventHandler(this.dataGridViewTickets_SelectionChanged);
            // 
            // dateTimePickerVon
            // 
            this.dateTimePickerVon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerVon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVon.Location = new System.Drawing.Point(57, 99);
            this.dateTimePickerVon.Name = "dateTimePickerVon";
            this.dateTimePickerVon.Size = new System.Drawing.Size(111, 23);
            this.dateTimePickerVon.TabIndex = 8;
            this.dateTimePickerVon.Value = new System.DateTime(2014, 1, 1, 8, 31, 0, 0);
            // 
            // dateTimePickerBis
            // 
            this.dateTimePickerBis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBis.Location = new System.Drawing.Point(213, 99);
            this.dateTimePickerBis.Name = "dateTimePickerBis";
            this.dateTimePickerBis.Size = new System.Drawing.Size(111, 23);
            this.dateTimePickerBis.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "- Ticketübersicht -";
            // 
            // buttonGespraechsuebersicht
            // 
            this.buttonGespraechsuebersicht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGespraechsuebersicht.BackColor = System.Drawing.Color.DarkGray;
            this.buttonGespraechsuebersicht.Enabled = false;
            this.buttonGespraechsuebersicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGespraechsuebersicht.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGespraechsuebersicht.Location = new System.Drawing.Point(696, 525);
            this.buttonGespraechsuebersicht.Name = "buttonGespraechsuebersicht";
            this.buttonGespraechsuebersicht.Size = new System.Drawing.Size(153, 46);
            this.buttonGespraechsuebersicht.TabIndex = 10;
            this.buttonGespraechsuebersicht.Text = "Gesprächsübersicht";
            this.buttonGespraechsuebersicht.UseVisualStyleBackColor = false;
            this.buttonGespraechsuebersicht.Click += new System.EventHandler(this.buttonGespraechsuebersicht_Click);
            // 
            // FormClientTicketuebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGespraechsuebersicht);
            this.Controls.Add(this.dateTimePickerBis);
            this.Controls.Add(this.dateTimePickerVon);
            this.Controls.Add(this.dataGridViewTickets);
            this.Controls.Add(this.buttonAnzeigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientTicketuebersicht";
            this.Text = "IT-Support Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geräteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persönlicheDatenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.DateTimePicker dateTimePickerVon;
        private System.Windows.Forms.DateTimePicker dateTimePickerBis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGespraechsuebersicht;
    }
}