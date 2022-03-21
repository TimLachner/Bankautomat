using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bankautomat
{
    public partial class FormKontoauszüge : Form
    {

        string user2;
        
        Db myData = new Db();
        public FormKontoauszüge(string CustomUser)
        {
            myData.dbconn();
            InitializeComponent();
            user2 = CustomUser;

        }
        private void FormKontoauszüge_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LBKontoauszüge_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormKontoauszüge_Load(object sender, EventArgs e)
        {
            string userID = Convert.ToString(myData.GetID(user2));

            List<string> KontoAuszug = new List<string>();
            KontoAuszug = myData.GetKontoauszug(userID);
            foreach (string Auszug in KontoAuszug)
            {
                LBKontoauszüge.Items.Add(Auszug);
            }
        }
    }
}
