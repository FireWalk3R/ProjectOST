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
    public partial class FormAdminEinstellungen : Form
    {
        OleDbConnection Con;
        public string MAID, FIID;
        public FormAdminEinstellungen()
        {
            InitializeComponent();
            Start();
        }
        public FormAdminEinstellungen(OleDbConnection con, string maID, string fiID)
        {
            InitializeComponent();
            Con = con;
            MAID = maID;
            FIID = fiID;
        }
        public void Start()
        {
            string queryAnzeigen = "SELECT * FROM  MITARBEITER ma WHERE ma.MFIRMAID ='" + FIID + "' AND ma.MITARBEITERID ='" + MAID + "';";
            try
            {
                Con.Open();

                DataTable dtAnzeigen = new DataTable();
                OleDbDataAdapter daAnzeigen = new OleDbDataAdapter(queryAnzeigen, Con);

                daAnzeigen.Fill(dtAnzeigen);

                textBoxMitarbeiterID.Text = dtAnzeigen.Rows[0]["MITARBEITERID"].ToString();
                textBoxMFirmaID.Text = dtAnzeigen.Rows[0]["MFIRMAID"].ToString();
                textBoxMVName.Text = dtAnzeigen.Rows[0]["MVORNAME"].ToString();
                textBoxMName.Text = dtAnzeigen.Rows[0]["MNACHNAME"].ToString();

                textBoxMTelNr.Text = dtAnzeigen.Rows[0]["MTELNR"].ToString();
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

