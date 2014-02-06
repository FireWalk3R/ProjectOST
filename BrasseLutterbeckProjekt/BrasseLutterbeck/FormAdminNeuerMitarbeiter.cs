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
    public partial class FormAdminNeuerMitarbeiter : Form
    {
        OleDbConnection Con;
        string MAID, FIID;
        public FormAdminNeuerMitarbeiter()
        {
            InitializeComponent();
        }
        public FormAdminNeuerMitarbeiter(OleDbConnection con, string maID, string fiID)
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
                string queryKataloge = "SELECT * FROM RAEUME ";
                DataTable dtKataloge = new DataTable();
                OleDbDataAdapter daKataloge = new OleDbDataAdapter(queryKataloge, Con);
                daKataloge.Fill(dtKataloge);
                if (dtKataloge.Rows.Count != 0)
                {
                    foreach (DataRow row in dtKataloge.Rows)
                    {
                        if (row["RAUM"] != null || (!row["RAUM"].Equals("")))
                        {
                            comboBoxRaumNr.Items.Add(row["RAUM"]);

                        }
                    }
                }

                queryKataloge = "SELECT * FROM RAENGE ";
                dtKataloge = new DataTable();
                daKataloge = new OleDbDataAdapter(queryKataloge, Con);
                daKataloge.Fill(dtKataloge);

                if (dtKataloge.Rows.Count != 0)
                {
                    foreach (DataRow row in dtKataloge.Rows)
                    {
                        if (row["RANG"] != null || (!row["RANG"].Equals("")))
                        {
                            comboBoxRang.Items.Add(row["RANG"]);
                        }
                    }
                }
                comboBoxRang.SelectedIndex = 0;
                comboBoxRaumNr.SelectedIndex = 0;
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

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxKennwortNeu1.Text.Equals(textBoxKennwortNeu2.Text))
                {
                    if (textBoxKennwortNeu1.Text.Length >= 4)
                    {
                        Con.Open();

                        OleDbCommand cmdMID = new OleDbCommand("SELECT MAX(ma.MITARBEITERID) FROM MITARBEITER ma;", Con);
                        string neuMitarbeiterID = cmdMID.ExecuteScalar().ToString();
                        int MitarbeiterID = Convert.ToInt32(neuMitarbeiterID.Substring(2)) + 1;


                        string queryRaeume = "INSERT INTO RAEUME (RAUM) VALUES (@RAUM);";
                        OleDbCommand cmdInsR = new OleDbCommand(queryRaeume, Con);
                        cmdInsR.Parameters.AddWithValue("@RAUM", comboBoxRaumNr.SelectedItem.ToString());

                        cmdInsR.ExecuteNonQuery();
                        cmdInsR.Dispose();
                        cmdInsR = null;

                        string queryMitarbeiter = "INSERT INTO MITARBEITER (MITARBEITERID,MVORNAME,MNACHNAME,MRAUMNR,MTELNR,MKENNWORT,MFIRMAID,MRANG,MEMAIL) " +
                        "VALUES (@MITARBEITERID,@MVORNAME,@MNACHNAME,@MRAUMNR,@MTELNR,@MKENNWORT,@MFIRMAID,@MRANG,@MEMAIL);";
                        OleDbCommand cmdInsM = new OleDbCommand(queryMitarbeiter, Con);
                        cmdInsM.Parameters.AddWithValue("@MITARBEITERID", "MA" + MitarbeiterID.ToString().PadLeft(8, '0'));
                        cmdInsM.Parameters.AddWithValue("@MVORNAME", textBoxMVName.Text);
                        cmdInsM.Parameters.AddWithValue("@MNACHNAME", textBoxMName.Text);
                        cmdInsM.Parameters.AddWithValue("@MRAUMNR", comboBoxRaumNr.SelectedItem.ToString());
                        cmdInsM.Parameters.AddWithValue("@MTELNR", textBoxMTelNr.Text);
                        cmdInsM.Parameters.AddWithValue("@MKENNWORT", textBoxKennwortNeu1.Text);
                        cmdInsM.Parameters.AddWithValue("@MFIRMAID", FIID);
                        cmdInsM.Parameters.AddWithValue("@MRANG", comboBoxRang.SelectedItem.ToString());
                        cmdInsM.Parameters.AddWithValue("@MEMAIL", textBoxEmail.Text);


                        cmdInsM.ExecuteNonQuery();
                        cmdInsM.Dispose();
                        cmdInsM = null;
                        
                        MessageBox.Show("Der Account wurde erfolgreich angelegt:\r\nMitarbeiterID:\t" + "MA" + MitarbeiterID.ToString().PadLeft(8, '0') + "");


                    }
                    else
                    {
                        MessageBox.Show("Das Passwort muss mindestens 4 oder mehr Zeichen enthalten");
                    }
                }
                else
                {
                    MessageBox.Show("Die eingegebenen Passwörter stimmen nicht überein!");
                }
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
