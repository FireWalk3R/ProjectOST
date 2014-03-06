using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BrasseLutterbeck
{
    public partial class FormAdminNeuesGeraet : Form
    {
        OleDbConnection Con;
        public string MAID, FIID;

        public FormAdminNeuesGeraet()
        {
            InitializeComponent();
        }

        public FormAdminNeuesGeraet(OleDbConnection con, string maID, string fiID)
        {
            InitializeComponent();
            Con = con;
            MAID = maID;
            FIID = fiID;
            Start();
        }

        public void Start()
        {
            string queryAnzeigen = "SELECT ma.MITARBEITERID, ma.MVORNAME, ma.MNACHNAME FROM  MITARBEITER ma WHERE ma.MFIRMAID ='" + FIID + "';";
            try
            {
                Con.Open();
                DataTable dtAnzeigen = new DataTable();
                OleDbDataAdapter daAnzeigen = new OleDbDataAdapter(queryAnzeigen, Con);
                Con.Close();
                daAnzeigen.Fill(dtAnzeigen);
                if (dtAnzeigen.Rows.Count != 0)
                {
                    for (int i = 0; i < dtAnzeigen.Rows.Count; i++)
                    {
                        string item = dtAnzeigen.Rows[i]["MITARBEITERID"].ToString();

                        comboBoxMitarbeiterID.Items.Add(item);
                    }
                }
                comboBoxMitarbeiterID.SelectedIndex = 0;
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

        public void DataGridViewFuellen(string MitarbeiterID)
        {
            string queryAnzeigen = "SELECT ma.MVORNAME, ma.MNACHNAME, ge.GERAETEID FROM MITARBEITER ma, GERAETE ge, MITARBEITERGERAETE mg WHERE ma.MFIRMAID='" + FIID +
                "' AND ma.MITARBEITERID = mg.MGMITARBEITERID AND mg.MGGERAETEID = ge.GERAETEID AND ma.MITARBEITERID = '" + comboBoxMitarbeiterID.Text + "';";

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

        private void comboBoxMitarbeiterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Mitarbeiter = comboBoxMitarbeiterID.SelectedItem.ToString();
            DataGridViewFuellen(Mitarbeiter);
            textBoxBezeichnung.Enabled = true;
            comboBoxArt.Enabled = true;
            comboBoxArt.Items.Clear();
            try
            {
                if (Con != null)
                {
                    Con.Open();
                }

                string queryKataloge = "SELECT ga.* FROM GERAETART ga ";
                DataTable dtKataloge = new DataTable();
                OleDbDataAdapter daKataloge = new OleDbDataAdapter(queryKataloge, Con);

                daKataloge.Fill(dtKataloge);

                if (dtKataloge.Rows.Count != 0)
                {
                    foreach (DataRow row in dtKataloge.Rows)
                    {
                        if (row["GERAETEART"] != null || (!row["GERAETEART"].Equals("")))
                        {
                            comboBoxArt.Items.Add(row["GERAETEART"]);
                        }
                    }
                }

                queryKataloge = "SELECT sp.* FROM SPEICHER sp ";
                dtKataloge = new DataTable();
                daKataloge = new OleDbDataAdapter(queryKataloge, Con);
                daKataloge.Fill(dtKataloge);

                if (dtKataloge.Rows.Count != 0)
                {
                    foreach (DataRow row in dtKataloge.Rows)
                    {
                        if (row["GROESSE"] != null || (!row["GROESSE"].Equals("")))
                        {
                            comboBoxHDD.Items.Add(row["GROESSE"]);
                            comboBoxArbeitsspeicher.Items.Add(row["GROESSE"]);
                        }
                    }
                }

                queryKataloge = "SELECT pr.* FROM PROZESSOREN pr ";
                dtKataloge = new DataTable();
                daKataloge = new OleDbDataAdapter(queryKataloge, Con);
                daKataloge.Fill(dtKataloge);

                if (dtKataloge.Rows.Count != 0)
                {
                    foreach (DataRow row in dtKataloge.Rows)
                    {
                        if (row["PROZESSORBEZEICHNUNG"] != null || (!row["PROZESSORBEZEICHNUNG"].Equals("")))
                        {
                            comboBoxProzessor.Items.Add(row["PROZESSORBEZEICHNUNG"]);
                        }
                    }
                }
                queryKataloge = "SELECT gr.* FROM GRAFIK gr ";
                dtKataloge = new DataTable();
                daKataloge = new OleDbDataAdapter(queryKataloge, Con);
                daKataloge.Fill(dtKataloge);
                if (dtKataloge.Rows.Count != 0)
                {
                    foreach (DataRow row in dtKataloge.Rows)
                    {
                        if (row["GRAFIKBEZEICHNUNG"] != null || (!row["GRAFIKBEZEICHNUNG"].Equals("")))
                        {
                            comboBoxGrafik.Items.Add(row["GRAFIKBEZEICHNUNG"]);
                        }
                    }
                }

                panelArt.Enabled = true;
                comboBoxArt.SelectedIndex = 0;
                comboBoxArbeitsspeicher.SelectedIndex = 0;
                comboBoxHDD.SelectedIndex = 0;
                comboBoxProzessor.SelectedIndex = 0;
                comboBoxGrafik.SelectedIndex = 0;
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

        private void comboBoxArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxArt.Text == "PC" || comboBoxArt.Text == "Notebook")
            {
                panelPC.Enabled = true;
                panelMobil.Enabled = false;
            }
            else
            {
                panelMobil.Enabled = true;
                panelPC.Enabled = false;
            }
        }
    }
}