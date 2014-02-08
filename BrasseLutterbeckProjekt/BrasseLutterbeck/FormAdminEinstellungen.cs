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
        string Passwort = "";
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
            Start();
        }
        public void Start()
        {


            try
            {
                string queryAnzeigen = "SELECT * FROM  MITARBEITER ma WHERE ma.MFIRMAID ='" + FIID + "' AND ma.MITARBEITERID ='" + MAID + "';";

                Con.Open();

                DataTable dtAnzeigen = new DataTable();
                OleDbDataAdapter daAnzeigen = new OleDbDataAdapter(queryAnzeigen, Con);

                daAnzeigen.Fill(dtAnzeigen);

                textBoxMitarbeiterID.Text = dtAnzeigen.Rows[0]["MITARBEITERID"].ToString();
                textBoxMFirmaID.Text = dtAnzeigen.Rows[0]["MFIRMAID"].ToString();
                textBoxMVName.Text = dtAnzeigen.Rows[0]["MVORNAME"].ToString();
                textBoxMName.Text = dtAnzeigen.Rows[0]["MNACHNAME"].ToString();
                textBoxMTelNr.Text = dtAnzeigen.Rows[0]["MTELNR"].ToString();
                textBoxEmail.Text = dtAnzeigen.Rows[0]["MEMAIL"].ToString();
                Passwort = dtAnzeigen.Rows[0]["MKENNWORT"].ToString();

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

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            try
            {

                Con.Open();


                if (textBoxKennwortAlt.Text != null && textBoxKennwortNeu1.Text != null && textBoxKennwortNeu2.Text != null && textBoxKennwortAlt.Text != "" && textBoxKennwortNeu1.Text != "" && textBoxKennwortNeu2.Text != "")
                {
                    if (Passwort == textBoxKennwortAlt.Text)
                    {
                        if (textBoxKennwortNeu1.Text.Equals(textBoxKennwortNeu2.Text))
                        {
                            if (textBoxKennwortNeu1.Text.Length >= 4)
                            {
                                Passwort = textBoxKennwortNeu1.Text;
                                EinstellungenAendern();
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
                    else
                    {
                        MessageBox.Show("Das Passwort ist falsch!");
                    }
                }
                else
                {
                    
                    EinstellungenAendern();
                    
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

        public void EinstellungenAendern()
        {
            try
            {
                string queryRaeume = "INSERT INTO RAEUME (RAUM) VALUES (@RAUM);";
                OleDbCommand cmdInsR = new OleDbCommand(queryRaeume, Con);
                cmdInsR.Parameters.AddWithValue("@RAUM", comboBoxRaumNr.Text);

                cmdInsR.ExecuteNonQuery();
                cmdInsR.Dispose();
                cmdInsR = null;
            }
            catch
            {

            }



            string queryMitarbeiter = "UPDATE MITARBEITER SET MVORNAME=@MVORNAME,MNACHNAME=@MNACHNAME,MRAUMNR=@MRAUMNR,MTELNR=@MTELNR,MKENNWORT=@MKENNWORT,MRANG=@MRANG,MEMAIL=@MEMAIL WHERE MITARBEITERID ='" + MAID + "'";
            OleDbCommand cmdInsM = new OleDbCommand(queryMitarbeiter, Con);
            cmdInsM.Parameters.AddWithValue("@MVORNAME", textBoxMVName.Text);
            cmdInsM.Parameters.AddWithValue("@MNACHNAME", textBoxMName.Text);
            cmdInsM.Parameters.AddWithValue("@MRAUMNR", comboBoxRaumNr.Text);
            cmdInsM.Parameters.AddWithValue("@MTELNR", textBoxMTelNr.Text);
            cmdInsM.Parameters.AddWithValue("@MKENNWORT", Passwort);
            cmdInsM.Parameters.AddWithValue("@MRANG", comboBoxRang.Text);
            cmdInsM.Parameters.AddWithValue("@MEMAIL", textBoxEmail.Text);


            cmdInsM.ExecuteNonQuery();
            cmdInsM.Dispose();
            cmdInsM = null;

            MessageBox.Show("Der Account wurde erfolgreich bearbeitet!");



            this.Close();
        }
    }




}


