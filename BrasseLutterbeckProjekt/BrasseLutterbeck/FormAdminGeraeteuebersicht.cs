using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BrasseLutterbeck
{
    public partial class FormAdminGeraeteuebersicht : Form
    {
        OleDbConnection Con;
        string MAID, FIID;

        public FormAdminGeraeteuebersicht()
        {
            InitializeComponent();
        }

        public FormAdminGeraeteuebersicht(OleDbConnection con, string maID, string fiID)
        {
            InitializeComponent();
            Con = con;
            MAID = maID;
            FIID = fiID;
            Start();
        }
        
        public void Start()
        {
            string queryAnzeigen =
                "SELECT ge.GERAETEID, ma.MVORNAME, ma.MNACHNAME, ge.GERAETEART, ge.BEZEICHNUNG, ge.BETRIEBSSYSTEM, ge.SERIENNUMMER, pr.PROZESSORBEZEICHNUNG, pr.TAKTFREQUENZ, ge.RAM "+
                "FROM MITARBEITER ma, GERAETE ge, MITARBEITERGERAETE mg, PROZESSOREN pr "+
                "WHERE ma.MFIRMAID='" + FIID + "' " +
                "AND ma.MITARBEITERID = mg.MGMITARBEITERID " +
                "AND mg.MGGERAETEID = ge.GERAETEID " +
                "AND ge.PROZESSORID = pr.PROZESSORID" +
                ";";

            try
            {
                Con.Open();

                DataTable dtAnzeigen = new DataTable();
                OleDbDataAdapter daAnzeigen = new OleDbDataAdapter(queryAnzeigen, Con);

                daAnzeigen.Fill(dtAnzeigen);

                dataGridViewGeraete.DataSource = dtAnzeigen;
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

        private void textBoxGeraeteSuchen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSuchen_Click(this, e);
            }
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            if (textBoxGeraeteSuchen.Text == null || textBoxGeraeteSuchen.Text == "")
            {
                Start();
            }
            else
            {
                string queryAnzeigen = "SELECT ge.GERAETEID, ma.MVORNAME, ma.MNACHNAME, ge.GERAETEART, ge.BEZEICHNUNG, ge.BETRIEBSSYSTEM, ge.SERIENNUMMER, pr.PROZESSORBEZEICHNUNG, pr.TAKTFREQUENZ, ge.RAM " +
                "FROM MITARBEITER ma, GERAETE ge, MITARBEITERGERAETE mg, PROZESSOREN pr " +
                "WHERE ma.MFIRMAID='" + FIID + "' " +
                "AND ma.MITARBEITERID = mg.MGMITARBEITERID " +
                "AND mg.MGGERAETEID = ge.GERAETEID " +
                "AND ge.PROZESSORID = pr.PROZESSORID " +
                "AND (ge.GERAETEID LIKE '%" + textBoxGeraeteSuchen.Text + "%' OR ma.MNACHNAME LIKE '%" + textBoxGeraeteSuchen.Text + "%')" +
                ";";
                try
                {
                    Con.Open();

                    DataTable dtAnzeigen = new DataTable();
                    OleDbDataAdapter daAnzeigen = new OleDbDataAdapter(queryAnzeigen, Con);

                    daAnzeigen.Fill(dtAnzeigen);

                    dataGridViewGeraete.DataSource = dtAnzeigen;
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
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            string queryLoeschen = "DELETE FROM MITARBEITERGERAETE mg WHERE mg.MGGERAETEID = '" + dataGridViewGeraete[0, dataGridViewGeraete.CurrentRow.Index].Value + "';";

            try
            {
                Con.Open();

                OleDbCommand cmd = new OleDbCommand(queryLoeschen, Con);
                cmd.ExecuteNonQuery();

                queryLoeschen = "DELETE FROM GERAETE ge WHERE ge.GERAETEID = '" + dataGridViewGeraete[0, dataGridViewGeraete.CurrentRow.Index].Value + "';";

                cmd = new OleDbCommand(queryLoeschen, Con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
                Start();
            }
        }
    }
}
