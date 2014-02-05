using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Win32;

namespace BrasseLutterbeck
{
    public partial class FormClientTicketuebersicht : Form
    {
        OleDbConnection Con;
        string MAID, FIID;
        string selectedTicketID;
        public FormClientTicketuebersicht()
        {
            InitializeComponent();
        }
        public FormClientTicketuebersicht(OleDbConnection con, string maID, string fiID)
        {
            InitializeComponent();
            Con = con;
            MAID = maID;
            FIID = fiID;
            buttonAnzeigen_Click(this,new EventArgs());
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            string VonDat = dateTimePickerVon.Text.ToString();
            string BisDat = dateTimePickerBis.Text.ToString();
            string queryAnzeigen = "SELECT ti.TICKETID, ti.PRIORITAET, ti.TICKETSTATUS as STATUS, ti.BETREFFKATEGORIE as KATEGORIE, ma.MVORNAME as VORNAME," +
            "ma.MNACHNAME as NACHNAME, ti.ERSTELLDATUM FROM TICKET ti, MITARBEITER ma " +
            "WHERE ti.MITARBEITERID = '" + MAID + "' AND ti.FIRMAID ='" + FIID + "' AND ti.MITARBEITERID = ma.MITARBEITERID;";
            
            try
            {
                Con.Open();
                DataTable dtAnzeigen = new DataTable();
                OleDbDataAdapter daAnzeigen = new OleDbDataAdapter(queryAnzeigen, Con);
                daAnzeigen.Fill(dtAnzeigen);

                dataGridViewTickets.DataSource = dtAnzeigen;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void dataGridViewTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedCells.Count > 0)
            {
                buttonGespraechsuebersicht.Enabled = true;
                int selectedrowindex = dataGridViewTickets.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewTickets.Rows[selectedrowindex];
                selectedTicketID = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }
         
        private void buttonGespraechsuebersicht_Click(object sender, EventArgs e)
        {

        }
        private void übersichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormClientTicketuebersicht fCT = new FormClientTicketuebersicht(Con, MAID, FIID);
            fCT.Show();
        }

        private void neuesTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormClientNeuesTicket fCNT = new FormClientNeuesTicket(Con, MAID, FIID);
            fCNT.Show();
        }

        private void übersichtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormClientGeraeteuebersicht fCG = new FormClientGeraeteuebersicht(Con, MAID, FIID);
            fCG.Show();
        }

        private void persönlicheDatenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormClientEinstellungen fCE = new FormClientEinstellungen(Con, MAID, FIID);
            fCE.Show();
        }
    }
}