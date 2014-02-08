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

namespace BrasseLutterbeck
{
    public partial class FormAdminTicketuebersicht : Form
    {
        OleDbConnection Con;
        string MAID, FIID;
        string selectedTicketID;
        public FormAdminTicketuebersicht()
        {
            InitializeComponent();
        }
        public FormAdminTicketuebersicht(OleDbConnection con, string maID, string fiID)
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
            string queryAnzeigen = "SELECT ti.TICKETID, ti.PRIORITAET, ti.TICKETSTATUS as STATUS, ti.BETREFFKATEGORIE as KATEGORIE, ti.BETREFFZEILE , ma.MVORNAME as VORNAME," +
            "ma.MNACHNAME as NACHNAME, ti.ERSTELLDATUM FROM TICKET ti, MITARBEITER ma " +
            "WHERE ti.MITARBEITERID = ma.MITARBEITERID AND ti.FIRMAID ='" + FIID + "';";
            try
            {
                Con.Open();

                DataTable dtAnzeigen = new DataTable();
                OleDbDataAdapter daAnzeigen = new OleDbDataAdapter(queryAnzeigen, Con);

                daAnzeigen.Fill(dtAnzeigen);

                BindingSource bscAnzeigen = new BindingSource()
                {
                    DataSource = dtAnzeigen
                };

                dataGridViewTickets.DataSource = bscAnzeigen;
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

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            string VonDat = dateTimePickerVon.Text.ToString();
            string BisDat = dateTimePickerBis.Text.ToString();
            string Suchen = textBoxTicketSuchen.Text.ToString();
            string querySuchen = "SELECT ti.TICKETID, ti.PRIORITAET, ti.TICKETSTATUS as STATUS, ti.BETREFFKATEGORIE as KATEGORIE, ti.BETREFFZEILE, ma.MVORNAME as VORNAME," +
            "ma.MNACHNAME as NACHNAME, ti.ERSTELLDATUM FROM TICKET ti, MITARBEITER ma " +
            "WHERE ti.MITARBEITERID = ma.MITARBEITERID AND ti.FIRMAID ='" + FIID + "' AND ti.TICKETID LIKE '%"+Suchen+"%' ;";
            try
            {
                Con.Open();

                DataTable dtSuchen = new DataTable();
                OleDbDataAdapter daSuchen = new OleDbDataAdapter(querySuchen, Con);

                daSuchen.Fill(dtSuchen);

                BindingSource bscSuchen = new BindingSource()
                {
                    DataSource = dtSuchen
                };

                dataGridViewTickets.DataSource = bscSuchen;
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
        private void ResizeColumns()
        {
            for (int i = 0; i < dataGridViewTickets.ColumnCount - 1; i++)
            {
                dataGridViewTickets.Columns[i].Width = dataGridViewTickets.Width / 8;
            }
        }


        private void dataGridViewTickets_SelectionChanged(object sender, EventArgs e)
        {
            ResizeColumns();
            if (dataGridViewTickets.SelectedCells.Count > 0)
            {
                buttonTicketSchliessen.Enabled = true;
                
                int selectedrowindex = dataGridViewTickets.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewTickets.Rows[selectedrowindex];
                selectedTicketID = Convert.ToString(selectedRow.Cells[0].Value);

                }
        }

        private void buttonTicketSchliessen_Click(object sender, EventArgs e)
        {
            string querySchliessen = "UPDATE TICKET ti SET ti.TICKETSTATUS = 'Geschlossen', ti.BEARBEITERID ='"+MAID+"' WHERE ti.TICKETID ='"+selectedTicketID+"';";
            string queryAnzeigen = "SELECT ti.TICKETID, ti.PRIORITAET, ti.TICKETSTATUS as STATUS, ti.BETREFFKATEGORIE as KATEGORIE, ti.BETREFFZEILE, ma.MVORNAME as VORNAME," +
            "ma.MNACHNAME as NACHNAME, ti.ERSTELLDATUM FROM TICKET ti, MITARBEITER ma " +
            "WHERE ti.MITARBEITERID = ma.MITARBEITERID AND ti.FIRMAID ='" + FIID + "';";
            
            try
            {
                Con.Open();

                DataTable dtSchliessen = new DataTable();
                OleDbDataAdapter daSchliessen = new OleDbDataAdapter(queryAnzeigen, Con);

                OleDbCommand cmd = new OleDbCommand(querySchliessen, Con);
                cmd.ExecuteNonQuery();

                daSchliessen.Fill(dtSchliessen);

                dataGridViewTickets.DataSource = dtSchliessen;
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

        private void buttonGespraechsuebersicht_Click(object sender, EventArgs e)
        {

        }

        private void FormAdminTicketuebersicht_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }
        }

        private void übersichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormAdminTicketuebersicht fAT = new FormAdminTicketuebersicht(Con,MAID,FIID);
            fAT.Show();
        }

        private void übersichtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormAdminGeraeteuebersicht fAG = new FormAdminGeraeteuebersicht(Con, MAID, FIID);
            fAG.Show();
        }

        private void neuesGerätToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormAdminNeuesGeraet fANG = new FormAdminNeuesGeraet(Con, MAID, FIID);
            fANG.Show();
        }

        private void übersichtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormAdminMitarbeiteruebersicht fAM = new FormAdminMitarbeiteruebersicht(Con, MAID, FIID);
            fAM.Show();
        }

        private void neuerMitarbeiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormAdminNeuerMitarbeiter fANM = new FormAdminNeuerMitarbeiter(Con, MAID, FIID);
            fANM.Show();
        }

        private void persönlicheDatenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            FormAdminEinstellungen fAE = new FormAdminEinstellungen(Con, MAID, FIID);
            fAE.Show();
        }

        private void textBoxTicketSuchen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSuchen_Click(this, e);
            }
        }
    }
}