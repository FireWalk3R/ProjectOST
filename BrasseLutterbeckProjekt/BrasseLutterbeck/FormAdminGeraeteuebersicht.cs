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
    public partial class FormAdminGeraeteuebersicht : Form
    {
        OleDbConnection Con;
        string MAID, FIID;
        //public FormAdminGeraeteuebersicht()
        //{
        //    InitializeComponent();

        //}
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
            string queryAnzeigen = "SELECT ma.MVORNAME, ma.MNACHNAME, ge.GERAETEID FROM MITARBEITER ma, GERAETE ge WHERE ma.MFIRMAID='" + FIID + "';";
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
