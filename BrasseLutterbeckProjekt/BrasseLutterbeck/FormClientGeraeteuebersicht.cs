﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BrasseLutterbeck
{
    public partial class FormClientGeraeteuebersicht : Form
    {
        OleDbConnection Con;
        string MAID, FIID;

        public FormClientGeraeteuebersicht(OleDbConnection con, string maID, string fiID)
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
                "SELECT ge.GERAETEID, ma.MVORNAME, ma.MNACHNAME, ge.GERAETEART, ge.BEZEICHNUNG, ge.BETRIEBSSYSTEM, ge.SERIENNUMMER, pr.PROZESSORBEZEICHNUNG, ge.RAM " +
                "FROM MITARBEITER ma, GERAETE ge, MITARBEITERGERAETE mg, PROZESSOREN pr " +
                "WHERE ge.GERAETEID = mg.MGGERAETEID " +
                "AND mg.MGMITARBEITERID = ma.MITARBEITERID " +
                "AND ge.PROZESSORBEZEICHNUNG = pr.PROZESSORBEZEICHNUNG " +
                "AND ma.MITARBEITERID = '" + MAID + "' " +
                "AND ma.MFIRMAID = '" + FIID + "';";

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
}