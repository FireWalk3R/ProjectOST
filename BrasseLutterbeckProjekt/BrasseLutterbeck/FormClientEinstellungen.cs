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
    public partial class FormClientEinstellungen : Form
    {
        OleDbConnection Con;
        string MAID, FIID;
        public FormClientEinstellungen(OleDbConnection con, string maID, string fiID)
        {
            InitializeComponent();
            Con = con;
            MAID = maID;
            FIID = fiID;
        }
    }
}
