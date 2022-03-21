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
    public partial class FormDashboard : Form
    {
        Db myData = new Db();
        public string CustomUser { get; set; }
        public FormDashboard()
        {
            myData.dbconn();
            InitializeComponent();
        }

        

        private void FormDashboard_Load(object sender,EventArgs e)
        {
            lblWelcome.Text = "Herzlich Willkommen " + CustomUser;
        }


     

        private void bttnKontostand_Click(object sender, EventArgs e)
        {
            
            FormKontostand frm3 = new FormKontostand(CustomUser);
            frm3.TopLevel = false;
            frm3.AutoScroll = true;
            frm3.FormBorderStyle = FormBorderStyle.None;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(frm3);
            frm3.Show();


        }

        private void bttnEinzahlen_Click(object sender, EventArgs e)
        {
            FormEinzahlen frm4 = new FormEinzahlen(CustomUser);
            frm4.TopLevel = false;
            frm4.AutoScroll = true;
            frm4.FormBorderStyle = FormBorderStyle.None;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(frm4);
            frm4.Show();

        }

        private void bttnKontoa_Click(object sender, EventArgs e)
        {
            FormKontoauszüge frm7 = new FormKontoauszüge(CustomUser);
            frm7.TopLevel = false;
            frm7.AutoScroll = true;
            frm7.FormBorderStyle = FormBorderStyle.None;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(frm7);
            frm7.Show();
           
        }

        private void bttnAuszahlen_Click(object sender, EventArgs e)
        {
            FormAuszahlen frm5 = new FormAuszahlen(CustomUser);
            frm5.TopLevel = false;
            frm5.AutoScroll = true;
            frm5.FormBorderStyle = FormBorderStyle.None;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(frm5);
            frm5.Show();
        }

        private void bttnÜberweisung_Click(object sender, EventArgs e)
        {
            FormÜberweisung frm6 = new FormÜberweisung(CustomUser);
            frm6.TopLevel = false;
            frm6.AutoScroll = true;
            frm6.FormBorderStyle = FormBorderStyle.None;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(frm6);
            frm6.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {
        }

        
    }
}
