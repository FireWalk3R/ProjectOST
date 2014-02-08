using Microsoft.Win32;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BrasseLutterbeck
{
    public partial class FormLogin : Form
    {
        OleDbConnection Con;
        string MAID, FAID, cmd;
        RegistryKey regKey;

        public FormLogin()
        {
            InitializeComponent();
            regKey = Registry.CurrentUser;

            try
            {
                textBoxFirmaID.Text = regKey.OpenSubKey("ITVerwaltung").GetValue("Firma").ToString();
                textBoxMitarbeiterID.Text = regKey.OpenSubKey("ITVerwaltung").GetValue("Mitarbeiter-ID").ToString();
            }
            catch
            {
            }
        }

        private void buttonAnmelden_Click(object sender, EventArgs e)
        {
            try
            {
                regKey = Registry.CurrentUser.CreateSubKey("ITVerwaltung");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            if (textBoxFirmaID != null && textBoxMitarbeiterID != null && textBoxKennwort != null &&
                 textBoxFirmaID.Text != "" && textBoxMitarbeiterID.Text != "" && textBoxKennwort.Text != "" &&
                 textBoxFirmaID.Text.StartsWith("FA") && textBoxMitarbeiterID.Text.StartsWith("MA"))
            {
                Con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\itv.accdb");

                try
                {
                    Con.Open();

                    MAID = textBoxMitarbeiterID.Text;
                    FAID = textBoxFirmaID.Text;

                    cmd = "SELECT ma.MFIRMAID, ma.MITARBEITERID, ma.MKENNWORT, ma.MRANG FROM MITARBEITER AS ma WHERE ma.MITARBEITERID = '" + MAID + "' AND ma.MFIRMAID = '" + FAID + "';";

                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd, Con);

                    da.Fill(dt);

                    if (textBoxKennwort.Text == dt.Rows[0]["MKENNWORT"].ToString())
                    {
                        if (dt.Rows[0]["MRANG"].ToString() == "Admin")
                        {
                            Con.Close();
                            FormAdminTicketuebersicht fAT = new FormAdminTicketuebersicht(Con, MAID, FAID);
                            
                            fAT.Show();
                        }

                        if (dt.Rows[0]["MRANG"].ToString() == "User")
                        {
                            Con.Close();
                            FormClientTicketuebersicht fCT = new FormClientTicketuebersicht(Con, MAID, FAID);
                            
                            fCT.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ihr Passwort war falsch!", "Falsches Passwort");
                    }
                }
                catch
                {
                    MessageBox.Show("Bitte korrekte Daten eingeben!", "Fehler");
                }
                finally
                {
                    Con.Close();
                }
            }
            else
            {
                MessageBox.Show("Bitte alle Felder ausfüllen", "Fehler");
            }

            if (checkBoxMerken.Checked)
            {
                regKey = Registry.CurrentUser;
                regKey.OpenSubKey("ITVerwaltung", true).SetValue("Firma", textBoxFirmaID.Text);
                regKey.OpenSubKey("ITVerwaltung", true).SetValue("Mitarbeiter-ID", textBoxMitarbeiterID.Text);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Con != null)
            {
                Con.Close();
            }
        }

        private void textBoxKennwort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAnmelden_Click(this, e);
            }
        }
    }
}