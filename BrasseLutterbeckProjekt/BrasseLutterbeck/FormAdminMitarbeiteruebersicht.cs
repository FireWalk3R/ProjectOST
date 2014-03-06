using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BrasseLutterbeck
{
    public partial class FormAdminMitarbeiteruebersicht : Form
    {
        OleDbConnection Con;
        string MAID, FIID;

        public FormAdminMitarbeiteruebersicht()
        {
            InitializeComponent();
        }

        public FormAdminMitarbeiteruebersicht(OleDbConnection con, string maID, string fiID)
        {
            InitializeComponent();
            Con = con;
            MAID = maID;
            FIID = fiID;
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

        }
    }
}
