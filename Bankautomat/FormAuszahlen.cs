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
    public partial class FormAuszahlen : Form
    {
        string user;
        Db myData = new Db();
        public FormAuszahlen(string CustomUser)
        {
            myData.dbconn();
            InitializeComponent();
            user = CustomUser;
        }


        private void bttnAuszahlen_Click(object sender, EventArgs e)
        {
            double Kontostand = myData.KontostandAnzeigen(user);
            var Eingabe = tbAuszahlen.Text;
            double EingabeKon = Convert.ToDouble(Eingabe);

            if(EingabeKon % 5 != 0)
            {
                MessageBox.Show("Der geringste Betrag der Ausgezahlt werden kann ist 5 EUR");
                return;
            }
            else
            {

                string Kontostand_STR = Convert.ToString(Kontostand);
                Kontostand_STR = Kontostand_STR.Replace('.', ',');

                double newKontostand = Kontostand - EingabeKon;
                string money = Convert.ToString(newKontostand);
                money = money.Replace(',', '.');

                myData.GeldAuszahlen(money, Convert.ToString(myData.GetID(user)));


                string UserID = Convert.ToString(myData.GetID(user));
                string Zeit = DateTime.Now.ToString("HH:mm:ss");
                string Datum = DateTime.Now.ToString("d/M/yyyy");
                string Betrag = tbAuszahlen.Text;
                string Zweck = "Auszahlung";

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

                    string AusgabeQuittung = "TEST-Bank \n Quittungsbeleg für Bargeldauszahlung \n " + Datum + " " + Zeit + "\n Summe:" + Betrag + " EUR" + "\n Rückfragen: \n Telefon: 015737908567";

                    File.WriteAllText(Pfad, AusgabeQuittung);
                    MessageBox.Show("Quittung erfolgreich gespeichert!");
                }

                myData.Kontoauszug(UserID, Zeit, Datum, Betrag, Zweck);
            }
            
        }

        private void tbAuszahlen_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbAuszahlen.Text, "[^0-9]"))
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden!");
                tbAuszahlen.Text = tbAuszahlen.Text.Remove(tbAuszahlen.Text.Length - tbAuszahlen.Text.Length);
            }
        }

        private void FormAuszahlen_Load(object sender, EventArgs e)
        {
        }

        private void FormAuszahlen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
