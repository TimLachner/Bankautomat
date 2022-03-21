using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;



namespace Bankautomat

{
    public class Db
    {

        public MySqlConnection conn;
        public string server;
        public string database;
        public string uid;
        public string password;
        public string user;
        public double Kontostand;
        public double ID;
        public int gibtesuser;
        public List<string> thisrow = new List<string>();

        public void dbconn()
        {
            server = "localhost";
            database = "bank";
            uid = "root";
            password = "";

            string connString;
            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            conn = new MySqlConnection(connString);
                        
        }

        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Keine Verbindung zur Datenbank möglich");
                        break;
                    case 1045:
                        MessageBox.Show("Benutzer oder Passwort der Datenbank ist Falsch");
                        break;
                }
                return false;



            }
        }



        public bool register(string user, string pw)
        {
            string query = $"INSERT INTO users (id, username, password) VALUES ('', '{user}', '{pw}');";


            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        string ex_STR = Convert.ToString(ex);
                        MessageBox.Show(ex_STR);
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                string ex_STR = Convert.ToString(ex);
                MessageBox.Show(ex_STR);
                conn.Close();
                return false;
            }

        }





        public bool login(string user, string pw)
        {
            string query = $"SELECT * FROM users WHERE username =  '{user}'AND password= '{pw}';";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                string ex_STR = Convert.ToString(ex);
                MessageBox.Show(ex_STR);
                conn.Close();
                return false;
            }

        }



        public double KontostandAnzeigen(string user)
        {
            string KontostandAbfrage = $"SELECT kontostand FROM users WHERE username = '{user}';";

           
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(KontostandAbfrage, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Kontostand = reader.GetDouble(0);
            }
            reader.Close();
            conn.Close();
                                                
            return Kontostand;
                        
           
        }

        public void GeldEinzahlen(string newKontostand, string id)
        {
            conn.Open();
            try
            {
                string updateData = $"UPDATE `users` SET `kontostand` = '{newKontostand}' WHERE `users`.`id` = {id};";


                MySqlCommand cmdEinzahlen = new MySqlCommand(updateData, conn);

                cmdEinzahlen.ExecuteNonQuery();
                MessageBox.Show("Einzahlen Erfolgreich");
                conn.Close();
            }

            catch (Exception ex)
            {
                string ex_STR = Convert.ToString(ex);
                MessageBox.Show(ex_STR);
                conn.Close();
            }
        }



        public void GeldAuszahlen(string newKontostand, string id)
        {
            conn.Open();
            try
            {
                string updateData = $"UPDATE users SET kontostand = '{newKontostand}' WHERE id = {id};";

                MySqlCommand cmdAuszahlen = new MySqlCommand(updateData, conn);

                cmdAuszahlen.ExecuteNonQuery();
                MessageBox.Show("Auszahelen Erfolgreich");
                conn.Close();

            }

            catch (Exception ex)
            {
                string ex_STR = Convert.ToString(ex);
                MessageBox.Show(ex_STR);
                conn.Close();
            }
        }






        public double GetID(string user)
        {

            string getid = $"SELECT id FROM users WHERE username = '{user}';";

            conn.Open();

            MySqlCommand cmdId = new MySqlCommand(getid, conn);

            MySqlDataReader reader = cmdId.ExecuteReader();

            while (reader.Read())
            {
                ID = reader.GetDouble(0);
            }
            reader.Close();

            conn.Close();

            return ID;

        }


        public void Überweisung(string kontostand, string kontostand2, string id, string id2)
        {
            conn.Open();

            try
            {

                string updateData = $"UPDATE `users` SET `kontostand` = '{kontostand}' WHERE `users`.`id` = {id};";
                string updateData2 = $"UPDATE `users` SET `kontostand` = '{kontostand2}' WHERE `users`.`id` = {id2};";

                MySqlCommand cmdÜberweisung = new MySqlCommand(updateData, conn);
                MySqlCommand cmdÜberweisung2 = new MySqlCommand(updateData2, conn);

                cmdÜberweisung.ExecuteNonQuery();
                cmdÜberweisung2.ExecuteNonQuery();
                                
                conn.Close();

            }

            catch (Exception ex)
            {
                string ex_STR = Convert.ToString(ex);
                MessageBox.Show(ex_STR);
                conn.Close();
            }
            MessageBox.Show("Überweisung Erfolgreich");



        }
        public void Kontoauszug(string UserID, string Zeit, string Datum, string Betrag, string Zweck)
        {
            conn.Open();
            try
            {
                string kontoauszugerstellen = $"INSERT INTO kontoauszüge (userid, zeit, datum, betrag, zweck) VALUES ('{UserID}', '{Zeit}', '{Datum}', '{Betrag}', '{Zweck}');";
                MySqlCommand cmdKontoauszug = new MySqlCommand(kontoauszugerstellen, conn);

                cmdKontoauszug.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                string ex_STR = Convert.ToString(ex);
                MessageBox.Show(ex_STR);
                conn.Close();
            }


        }

        public void KontoauszugÜberweisung(string UserID, string Zeit, string Datum, string Betrag, string Zweck, string Person)
        {
            conn.Open();
            try
            {
                string kontoauszugerstellenÜberweisung = $"INSERT INTO kontoauszüge (userid, zeit, datum, betrag, zweck, person) VALUES ('{UserID}', '{Zeit}', '{Datum}', '{Betrag}', '{Zweck}', '{Person}');";
                MySqlCommand cmdKontoauszugÜberweisung = new MySqlCommand(kontoauszugerstellenÜberweisung, conn);

                cmdKontoauszugÜberweisung.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                string ex_STR = Convert.ToString(ex);
                MessageBox.Show(ex_STR);
                conn.Close();
            }


        }

        public List<string> GetKontoauszug(string userid)
        {
            string GetKontoauszug = $"SELECT zeit, datum, betrag, zweck, person FROM kontoauszüge WHERE userid = '{userid}';";


            conn.Open();
            MySqlCommand cmd = new MySqlCommand(GetKontoauszug, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            string tempo =   ""; //TEMPORÄR

            while (reader.Read())
            {
                tempo = "";
                int fc = reader.FieldCount;
                                
                for (int i = 0; i < fc; i++)
                {
                    string StringValue = reader.GetValue(i).ToString();
                                      
                    if (i == fc - 1 || StringValue == "")
                    {
                        tempo = tempo + StringValue;

                    } else {  
                        tempo = tempo + StringValue + ",";
                    }
                                        
                }
                thisrow.Add(tempo);

            }

            reader.Close();
            conn.Close();
            return thisrow;

        }


        public bool UserAbFrage(string user)
        {

            string getuserabfrage = $"SELECT COUNT(*) FROM `users` WHERE username = '{user}';";

            conn.Open();

            MySqlCommand cmduser = new MySqlCommand(getuserabfrage, conn);

            MySqlDataReader reader = cmduser.ExecuteReader();

            while (reader.Read())
            {
                gibtesuser = reader.GetInt32(0);
            }

            if (gibtesuser == 1)
            {
                reader.Close();
                conn.Close();
                return true;
            }
            else
            {
                reader.Close();

                conn.Close();
                return false;
            }
            

            

        }

    }
}