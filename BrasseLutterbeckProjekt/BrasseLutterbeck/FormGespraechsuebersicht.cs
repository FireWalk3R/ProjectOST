using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BrasseLutterbeck
{
    public partial class FormGespraechsuebersicht : Form
    {
        string TID, MAID;
        OleDbConnection Con;

        public FormGespraechsuebersicht()
        {
            InitializeComponent();
        }

        public FormGespraechsuebersicht(string ticketID, string maid, OleDbConnection con)
        {
            InitializeComponent();
            TID = ticketID;
            MAID = maid;
            Con = con;
        }

        private void FormGespraechsuebersicht_Load(object sender, EventArgs e)
        {
            string query = "SELECT ma.MVORNAME, MA.MNACHNAME, ge.NACHRICHTDATUM, ti.BETREFFKATEGORIE, ti.BETREFFZEILE, ge.Nachricht " +
                "FROM GESPRAECH ge, MITARBEITER ma, TICKET ti " +
                "WHERE ge.MITARBEITERID = ma.MITARBEITERID " +
                "AND ti.TICKETID = '" + TID + "' " +
                "AND ge.TICKETID ='" + TID + "' ORDER BY(ge.NACHRICHTDATUM);";

            try
            {
                Con.Open();

                DataTable dtAnzeigen = new DataTable();
                OleDbDataAdapter daAnzeigen = new OleDbDataAdapter(query, Con);
                daAnzeigen.Fill(dtAnzeigen);

                dataGridView1.DataSource = dtAnzeigen;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    richTextBox1.AppendText("VON:\t\t" + dataGridView1[0, i].Value.ToString() + " " + dataGridView1[1, i].Value.ToString() + "\n" +
                                            "DATUM:\t\t" + dataGridView1[2, i].Value.ToString() + "\n" +
                                            "KATEGORIE:\t" + dataGridView1[3, i].Value.ToString() + "\n" +
                                            "BETREFF:\t" + dataGridView1[4, i].Value.ToString() + "\n" +
                                            "NACHRICHT:\n\n" + dataGridView1[5, i].Value.ToString() + "\n" +
                                            "__________________________________________________________" + "\n\n");
                }
            }
            catch { }
            finally { Con.Close(); }
        }

        private void buttonGespraechsuebersicht_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();

                OleDbCommand cmd = new OleDbCommand("SELECT MAX(ge.GESPRAECHSID) FROM GESPRAECH ge WHERE ge.TICKETID = '" + TID + "';", Con);
                int maxGespraechID = Convert.ToInt32(cmd.ExecuteScalar().ToString().Substring(2)) + 1;

                cmd = new OleDbCommand("INSERT INTO GESPRAECH (TICKETID, GESPRAECHSID, NACHRICHTDATUM, NACHRICHT, MITARBEITERID) " +
                    "VALUES('" +
                    TID +
                    "', 'GS" + maxGespraechID.ToString().PadLeft(3, '0') +
                    "','" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() +
                    "','" + richTextBox2.Text +
                    "','" + MAID + "');", Con);

                cmd.ExecuteNonQuery();

                string query = "SELECT ma.MVORNAME, MA.MNACHNAME, ge.Nachrichtdatum, ti.BETREFFKATEGORIE, ti.BETREFFZEILE, ge.Nachricht " +
                "FROM GESPRAECH ge, MITARBEITER ma, TICKET ti " +
                "WHERE ge.MITARBEITERID = ma.MITARBEITERID " +
                "AND ti.TICKETID = '" + TID + "' " +
                "AND ge.TICKETID ='" + TID + "';";

                richTextBox1.Clear();

                DataTable dtAnzeigen = new DataTable();
                OleDbDataAdapter daAnzeigen = new OleDbDataAdapter(query, Con);
                daAnzeigen.Fill(dtAnzeigen);

                dataGridView1.DataSource = dtAnzeigen;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    richTextBox1.AppendText("VON:\t\t" + dataGridView1[0, i].Value.ToString() + " " + dataGridView1[1, i].Value.ToString() + "\n" +
                                            "DATUM:\t\t" + dataGridView1[2, i].Value.ToString() + "\n" +
                                            "KATEGORIE:\t" + dataGridView1[3, i].Value.ToString() + "\n" +
                                            "BETREFF:\t" + dataGridView1[4, i].Value.ToString() + "\n" +
                                            "NACHRICHT:\n\n" + dataGridView1[5, i].Value.ToString() + "\n" +
                                            "__________________________________________________________" + "\n\n");
                }
            }
            catch { }
            finally { Con.Close(); }
        }
    }
}