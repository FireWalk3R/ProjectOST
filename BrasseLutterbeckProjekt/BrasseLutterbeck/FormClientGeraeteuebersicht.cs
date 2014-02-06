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
            string queryAnzeigen = "SELECT ma.MVORNAME, ma.MNACHNAME, ge.GERAETEID FROM MITARBEITER ma, MITARBEITERGERAETE mg, GERAETE ge WHERE ma.MFIRMAID='" + FIID + "' AND ma.MITARBEITERID ='" + MAID + "' AND mg.MGMITARBEITERID = ma.MITARBEITERID AND mg.MGGERAETEID = ge.GERAETEID ;";
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
