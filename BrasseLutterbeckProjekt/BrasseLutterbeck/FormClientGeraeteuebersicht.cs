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
                "SELECT ge.GERAETEID, ma.MVORNAME, ma.MNACHNAME, ge.GERAETEART, ge.BEZEICHNUNG, ge.BETRIEBSSYSTEM, ge.SERIENNUMMER, pr.PROZESSORBEZEICHNUNG, pr.TAKTFREQUENZ, ge.RAM " +
                "FROM MITARBEITER ma, GERAETE ge, MITARBEITERGERAETE mg, PROZESSOREN pr " +
                "WHERE ma.MFIRMAID='" + FIID + "' " +
                "AND ma.MITARBEITERID = mg.MGMITARBEITERID " +
                "AND mg.MGGERAETEID = ge.GERAETEID " +
                "AND ge.PROZESSORID = pr.PROZESSORID " +
                "AND ma.MITARBEITERID = '" + MAID + "'" +
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
}
