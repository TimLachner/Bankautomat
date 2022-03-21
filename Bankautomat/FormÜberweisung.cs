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
    
    public partial class FormÜberweisung : Form
    {
        Db myData = new Db();
        string user;
        public FormÜberweisung(string CustomUser)
        {
            myData.dbconn();
            InitializeComponent();
            user = CustomUser;
        }

        private void tbBetrag_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbBetrag.Text, "[^0,0-9,0]"))
            {
                MessageBox.Show("Es können nur Zahlen mit einem Komma eingegeben werden!");
                tbBetrag.Text = tbBetrag.Text.Remove(tbBetrag.Text.Length - tbBetrag.Text.Length);
            }
        }

        private void tbPerson_TextChanged(object sender, EventArgs e)
        {
        }


        

        private void bttnÜberweisen_Click(object sender, EventArgs e)
        {

            string Person = tbPerson.Text;
            if (myData.UserAbFrage(Person))
            {
                if (user == Person)
            {
                MessageBox.Show("Bitte gebe einen gültigen Benutzer an!");
                return;
            }
            else
            {
                    string Betragstr = tbBetrag.Text;
                    double Betrag = Convert.ToDouble(Betragstr);
                    string IDPerson = Convert.ToString(myData.GetID(Person));
                    string IDUser = Convert.ToString(myData.GetID(user));


                    if (Betragstr.Contains(".")) {
                        MessageBox.Show("Bitte verwenden Sie ein Komma");
                        return;
                    }

                    else
                    {
                        if (Betrag <= 0)
                        {
                            MessageBox.Show("Der geringste Wert den man Überweisen kann ist 1 EUR");
                            return;
                        }
                        else
                        {
                            double KontoUser = myData.KontostandAnzeigen(user);
                            double KontoPerson = myData.KontostandAnzeigen(Person);

                            double KontoBerechnungUser = KontoUser - Betrag;
                            double KontoBerechnungPerson = KontoPerson + Betrag;

                            string Kontostand1_STR = Convert.ToString(KontoBerechnungUser);
                            Kontostand1_STR = Kontostand1_STR.Replace(',', '.');

                            string Kontostand2_STR = Convert.ToString(KontoBerechnungPerson);
                            Kontostand2_STR = Kontostand2_STR.Replace(',', '.');

                            myData.Überweisung(Kontostand1_STR, Kontostand2_STR, IDUser, IDPerson);

                            string UserID = Convert.ToString(myData.GetID(user));
                            string Zeit = DateTime.Now.ToString("HH:mm:ss");
                            string Datum = DateTime.Now.ToString("d/M/yyyy");
                            string Zweck = "Überweisung";

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

                                string AusgabeQuittung = "TEST-Bank \n Quittungsbeleg für Geldtransfer \n " + Datum + " " + Zeit + "\n Summe:" + Betrag + " EUR" + "\n Empfänger:" + Person + "\n Rückfragen: \n Telefon: 015737908567";

                                File.WriteAllText(Pfad, AusgabeQuittung);
                                MessageBox.Show("Quittung erfolgreich gespeichert!");
                            }

                            myData.KontoauszugÜberweisung(UserID, Zeit, Datum, Betragstr, Zweck, Person);
                        }
                    }

            }
        }
            else
            {
                MessageBox.Show("Dieser Benutzer ist nicht vorhanden");
                return;
            }

        }

        private void FormÜberweisung_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
