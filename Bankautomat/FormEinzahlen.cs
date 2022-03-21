using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankautomat
{
    public partial class FormEinzahlen : Form
    {
        string user;
        Db myData = new Db();
        public FormEinzahlen(string CustomUser)
        {
            myData.dbconn();
            InitializeComponent();
            user = CustomUser;
        }
        
        private void tbEinzahlen_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbEinzahlen.Text, "[^0-9]"))
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden!");
                tbEinzahlen.Text = tbEinzahlen.Text.Remove(tbEinzahlen.Text.Length - tbEinzahlen.Text.Length);
            }
        }

        private void bttnEinzahlen_Click(object sender, EventArgs e)
        {
            double Kontostand = myData.KontostandAnzeigen(user);
            var Eingabe = tbEinzahlen.Text;
            double EingabeKon = Convert.ToDouble(Eingabe);
            if(EingabeKon % 5 != 0)     // if (EingabeKon % 5 != 0)
            {
                MessageBox.Show("Einzahlungen sind nur mit Banknoten möglich!");
                return;
            }
            else
            {

                string Kontostand_STR = Convert.ToString(Kontostand);
                Kontostand_STR = Kontostand_STR.Replace('.', ',');

                double Kontostand_Komma = Convert.ToDouble(Kontostand_STR);

                double newKontostand = Kontostand_Komma + EingabeKon;
                string money = Convert.ToString(newKontostand);
                money = money.Replace(',', '.');

                myData.GeldEinzahlen(money, Convert.ToString(myData.GetID(user)));




                string UserID = Convert.ToString(myData.GetID(user));
                string Zeit = DateTime.Now.ToString("HH:mm:ss");
                string Datum = DateTime.Now.ToString("d/M/yyyy");
                string Betrag = tbEinzahlen.Text;
                string Zweck = "Einzahlung";

                DialogResult dialogResult = MessageBox.Show("Wollen sie eine Quittung?", "Quittung", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string Pfad = "";
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "TXT files (*.txt)|*.txt";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Pfad = saveFileDialog.FileName;
                    }

                    string AusgabeQuittung = "TEST-Bank \n Quittungsbeleg für Bargeldeinzahlung \n " + Datum + " " + Zeit + "\n Summe:" + Betrag + " EUR" + "\n Rückfragen: \n Telefon: 015737908567";

                    File.WriteAllText(Pfad, AusgabeQuittung);
                    MessageBox.Show("Quittung erfolgreich gespeichert!");
                }

                myData.Kontoauszug(UserID, Zeit, Datum, Betrag, Zweck);
            }
            

        }

        private void FormEinzahlen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
