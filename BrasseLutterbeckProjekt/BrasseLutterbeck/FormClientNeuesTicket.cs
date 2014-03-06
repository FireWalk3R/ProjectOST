using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BrasseLutterbeck
{
    public partial class FormClientNeuesTicket : Form
    {
        OleDbConnection Con;
        string MAID, FIID;
        public FormClientNeuesTicket(OleDbConnection con, string maID, string fiID)
        {
            InitializeComponent();
            Con = con;
            MAID = maID;
            FIID = fiID;
            Start();
        }

        public void Start()
        {
            try
            {
                if (Con != null)
                {
                    Con.Open();
                }

                string queryKataloge = "SELECT pr.* FROM PRIORITAET pr ";
                DataTable dtKataloge = new DataTable();
                OleDbDataAdapter daKataloge = new OleDbDataAdapter(queryKataloge, Con);
                daKataloge.Fill(dtKataloge);
                
                if (dtKataloge.Rows.Count != 0)
                {
                    foreach (DataRow row in dtKataloge.Rows)
                    {
                        if (row["PRIORITAET"] != null || (!row["PRIORITAET"].Equals("")))
                        {
                            comboBoxPriorität.Items.Add(row["PRIORITAET"]);
                        }
                    }
                }

                queryKataloge = "SELECT bk.* FROM BETREFFKATEGORIE bk ";
                dtKataloge = new DataTable();
                daKataloge = new OleDbDataAdapter(queryKataloge, Con);
                daKataloge.Fill(dtKataloge);

                if (dtKataloge.Rows.Count != 0)
                {
                    foreach (DataRow row in dtKataloge.Rows)
                    {
                        if (row["BKATEGORIE"] != null || (!row["BKATEGORIE"].Equals("")))
                        {
                            comboBoxBetreffArt.Items.Add(row["BKATEGORIE"]);
                        }
                    }
                }

                comboBoxPriorität.SelectedIndex = 0;
                comboBoxBetreffArt.SelectedIndex = 0;
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

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }

            this.Close();
        }

        private void buttonTicketErstellen_Click(object sender, EventArgs e)
        {
            try
            {
                string neuTicketID = "";
                string neuGespraechsID = "";

                Con.Open();

                OleDbCommand cmdTID = new OleDbCommand("SELECT MAX(ti.TICKETID) FROM TICKET ti;", Con);
                neuTicketID = cmdTID.ExecuteScalar().ToString();
                if (neuTicketID == null || neuTicketID == "") neuTicketID = "TI000000";
                neuGespraechsID = "GS001";
                int TicketID = Convert.ToInt32(neuTicketID.Substring(2)) + 1;

                string queryTICKET = "INSERT INTO TICKET (TICKETID,BETREFFKATEGORIE,BETREFFZEILE,MITARBEITERID,PRIORITAET,ERSTELLDATUM,TICKETSTATUS,BEARBEITERID,FIRMAID) " +
                                                "VALUES (@TID,@BETREFFART,@BETREFFZEILE,@MID,@PRIORITAET,@DATUM,@STATUS,@BEARBEITER,@FIRMA);";
                OleDbCommand cmdInsT = new OleDbCommand(queryTICKET, Con);
                cmdInsT.Parameters.AddWithValue("@TID", "TI" + TicketID.ToString().PadLeft(6, '0'));
                cmdInsT.Parameters.AddWithValue("@BETREFFART", comboBoxBetreffArt.SelectedItem.ToString());
                cmdInsT.Parameters.AddWithValue("@BETREFFZEILE", textBoxBetreffzeile.Text.ToString());
                cmdInsT.Parameters.AddWithValue("@MID", MAID);
                cmdInsT.Parameters.AddWithValue("@PRIORITAET", comboBoxPriorität.SelectedItem.ToString());
                cmdInsT.Parameters.AddWithValue("@DATUM", DateTime.Now.ToShortDateString());
                cmdInsT.Parameters.AddWithValue("@STATUS", "Offen");
                cmdInsT.Parameters.AddWithValue("@BEARBEITER", "''");
                cmdInsT.Parameters.AddWithValue("@FIRMA", FIID);

                cmdInsT.ExecuteNonQuery();
                cmdInsT.Dispose();
                cmdInsT = null;

                string queryGESPRAECH = "INSERT INTO GESPRAECH (TICKETID, GESPRAECHSID,NACHRICHTDATUM,NACHRICHT,MITARBEITERID) " +
                "VALUES (@TID, @GID,@DATUM,@NACHRICHT,@MID);";
                OleDbCommand cmdInsG = new OleDbCommand(queryGESPRAECH, Con);
                cmdInsG.Parameters.AddWithValue("@TID", "TI" + TicketID.ToString().PadLeft(6, '0'));
                cmdInsG.Parameters.AddWithValue("@GID", neuGespraechsID);
                cmdInsG.Parameters.AddWithValue("@DATUM", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                cmdInsG.Parameters.AddWithValue("@NACHRICHT", richTextBoxTicketNachricht.Text.ToString());
                cmdInsG.Parameters.AddWithValue("@MID", MAID);

                cmdInsG.ExecuteNonQuery();
                cmdInsG.Dispose();
                cmdInsG = null;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
            this.Close();
        }
    }
}