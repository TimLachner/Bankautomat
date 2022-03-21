using System;
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
    public partial class FormKontostand : Form
    {
      
        Db myData = new Db();
        string user;
        public FormKontostand(string CustomUser)
        {
            myData.dbconn();
            InitializeComponent();
            user = CustomUser;
            lblKontostand.Text = Convert.ToString(myData.KontostandAnzeigen(user) + " EUR");
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void lblKontostandtext_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
        }

        private void FormKontostand_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bttnBackKontostand_Click(object sender, EventArgs e)
        {
        }
    }
}

