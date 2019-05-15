using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Security;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using bewerberpool.benutzerverwaltungDataSet;
using Microsoft.VisualBasic.CompilerServices;

namespace bewerberpool
{
    public partial class frmLogin
    {
        private frmMain _frmMain;

        public frmLogin(frmMain frmMain)
        {
            // TODO: Complete member initialization 
            _frmMain = frmMain;
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BenutzerTableAdapter.Fill(this.BenutzerverwaltungDataSet.benutzer);
            this.KeyTableAdapter.Fill(this.BenutzerverwaltungDataSet.key);
            var encryptionrow = (benutzerverwaltungDataSet.keyRow)((DataRowView)KeyBindingSource.Current).Row;
            crypto.Encryptionkey = System.Convert.ToString(encryptionrow.keycol);
        }

        public bool GetBenutzernameExists(string benutzername)
        {
            string test1 = System.Convert.ToString(crypto.Encrypt(txtUsername.Text));
            return this.BenutzerverwaltungDataSet.benutzer.Any(rw => Operators.CompareString(rw.benutzername, test1, TextCompare: false) == 0);
        }

        public bool GetPasswordExists(string benutzername)
        {
            string test2 = System.Convert.ToString(crypto.Encrypt(txtPassword.Text));
            return this.BenutzerverwaltungDataSet.benutzer.Any(rw => Operators.CompareString(rw.kennwort, test2, TextCompare: false) == 0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Module1.usernameklar = System.Convert.ToString(txtUsername.Text);
            string username = System.Convert.ToString(crypto.Encrypt(txtUsername.Text));
            string password = System.Convert.ToString(crypto.Encrypt(txtPassword.Text));
            bool vorhanden1 = GetBenutzernameExists(username);
            bool vorhanden2 = GetPasswordExists(password);

            if (string.IsNullOrEmpty(username))
                return; // Ausführung anhalten, wenn nichts eingetragen wurde
            if (string.IsNullOrEmpty(password))
                return; // Ausführung anhalten, wenn nichts eingetragen wurde

            if (vorhanden1 && vorhanden2)
            {
                this.BenutzerTableAdapter.ScalarQuery(this.BenutzerverwaltungDataSet.benutzer, username, password);
                var loginflagausdataset = (benutzerverwaltungDataSet.benutzerRow)((DataRowView)this.BenutzerBindingSource.Current).Row;
                Module1.loginflag = System.Convert.ToInt32(loginflagausdataset.zugang_bewpool);
                this.Close();
            }
            else
            {
                Interaction.MsgBox("Username und/oder Passwort ist falsch.");
                Module1.loginflag = 0;
                bewerberpool.My.MyProject.MyForms.frmMain.Close();
                this.Close();
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            bewerberpool.My.MyProject.MyForms.frmMain.Close();
            this.Close();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            AcceptButton = btnOK;
        }
    }
}
