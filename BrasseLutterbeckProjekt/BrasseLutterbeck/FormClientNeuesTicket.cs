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
            string neuTicketID = "";
            string neuGespraechsID = "";
            string query = "INSERT INTO TICKET ti (ti.TICKETID,ti.BETREFFKATEGORIE, ti.BETREFFZEILE, ti.MITARBEIETERID, ti.PRIORITAET, ti.ERSTELLDATUM, ti.TICKETSTATUS, ti.BEARBEITERID, ti.GESPRAECHSID, ti.FIRMAID)" +
                            "VALUES (@TID,@BETREFFART,@BETREFFZEILE,@MID,@PRIORITAET,@DATUM,@STATUS,@BEARBEITER,@GESPRAECH,@FIRMA)";
            OleDbCommand cmdIns = new OleDbCommand(query, Con);
            cmdIns.Parameters.Add("@TID", neuTicketID);
            cmdIns.Parameters.Add("@BETREFFART", comboBoxBetreffArt.SelectedValue.ToString());
            cmdIns.Parameters.Add("@BETREFFZEILE", textBoxBetreffzeile.Text);
            cmdIns.Parameters.Add("@MID", MAID);
            cmdIns.Parameters.Add("@STATUS", "Offen");
            cmdIns.Parameters.Add("@DATUM", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() );
            cmdIns.Parameters.Add("@PRIORITAET", comboBoxPriorität.SelectedValue.ToString());
            cmdIns.Parameters.Add("@BEARBEITER", null);
            cmdIns.Parameters.Add("@GESPRAECH", neuGespraechsID);
            cmdIns.Parameters.Add("@FIRMA", FIID);
            
            //cmdIns.ExecuteNonQuery();
            //cmdIns.Dispose();
            //cmdIns = null;

            MessageBox.Show(query.ToString());
            MessageBox.Show(cmdIns.ToString());
            //try
            //{
               
            //    Con.Open();
            //    DataTable dtSchliessen = new DataTable();
            //    OleDbCommand cmd = new OleDbCommand(query, Con);
            //    cmd.ExecuteNonQuery();
            

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    Con.Close();
            //}
        }
    }
}