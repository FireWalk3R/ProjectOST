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
using System.Data.Sql;

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
                OleDbCommand cmdGID = new OleDbCommand("SELECT MAX(gs.GESPRAECHSID) FROM GESPRAECH gs;", Con);
                neuGespraechsID = cmdGID.ExecuteScalar().ToString();
                int TicketID = Convert.ToInt32(neuTicketID.Substring(2)) + 1;
                int GespraechsID = Convert.ToInt32(neuGespraechsID.Substring(2)) + 1;

                string queryGESPRAECH = "INSERT INTO GESPRAECH (GESPRAECHSID,NACHRICHTDATUM,NACHRICHT,MITARBEITERID) " +
                "VALUES (@GID,@DATUM,@NACHRICHT,@MID);";
                OleDbCommand cmdInsG = new OleDbCommand(queryGESPRAECH, Con);
                cmdInsG.Parameters.AddWithValue("@GID", "GS" + GespraechsID.ToString().PadLeft(8, '0'));
                cmdInsG.Parameters.AddWithValue("@DATUM", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                cmdInsG.Parameters.AddWithValue("@NACHRICHT", richTextBoxTicketNachricht.Text.ToString());
                cmdInsG.Parameters.AddWithValue("@MID", MAID);

                cmdInsG.ExecuteNonQuery();
                cmdInsG.Dispose();
                cmdInsG = null;


                string queryTICKET = "INSERT INTO TICKET (TICKETID,BETREFFKATEGORIE,BETREFFZEILE,MITARBEITERID,PRIORITAET,ERSTELLDATUM,TICKETSTATUS,BEARBEITERID,GESPRAECHSID,FIRMAID) " +
                                "VALUES (@TID,@BETREFFART,@BETREFFZEILE,@MID,@PRIORITAET,@DATUM,@STATUS,@BEARBEITER,@GESPRAECH,@FIRMA);";
                OleDbCommand cmdInsT = new OleDbCommand(queryTICKET, Con);
                cmdInsT.Parameters.AddWithValue("@TID", "TI" + TicketID.ToString().PadLeft(8, '0'));
                cmdInsT.Parameters.AddWithValue("@BETREFFART", comboBoxBetreffArt.SelectedItem.ToString());
                cmdInsT.Parameters.AddWithValue("@BETREFFZEILE", textBoxBetreffzeile.Text.ToString());
                cmdInsT.Parameters.AddWithValue("@MID", MAID);
                cmdInsT.Parameters.AddWithValue("@PRIORITAET", comboBoxPriorität.SelectedItem.ToString());
                cmdInsT.Parameters.AddWithValue("@DATUM", DateTime.Now.ToShortDateString());
                cmdInsT.Parameters.AddWithValue("@STATUS", "Offen");
                cmdInsT.Parameters.AddWithValue("@BEARBEITER", "'´'");
                cmdInsT.Parameters.AddWithValue("@GESPRAECH", "GS" + GespraechsID.ToString().PadLeft(8, '0'));
                cmdInsT.Parameters.AddWithValue("@FIRMA", FIID);

                cmdInsT.ExecuteNonQuery();
                cmdInsT.Dispose();
                cmdInsT = null;



                //MessageBox.Show(query.ToString());
                //MessageBox.Show(cmdIns.CommandText);


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