using System;
using System.Windows.Forms;


namespace Bankautomat
{
    public partial class FormLogin : Form
    {
        Db myData = new Db();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myData.dbconn();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        

        public void bttnRegister_Click(object sender, EventArgs e)
        {
            string user = tbUser.Text;
            string pw = tbPw.Text;
            myData.UserAbFrage(user);

            if(user == "" && pw == "")
            {
                MessageBox.Show("Ungültige Eingabe");
                return;
            }

            else if (myData.UserAbFrage(user))
            {
                MessageBox.Show($"Es gibt schon einen Account mit dem Namen: {user}");
                return;
                
            }
            else
            {
                myData.register(user, pw);
                MessageBox.Show($"{user} wurde erstellt");
            }
        }



        public void bttnLogin_Click(object sender, EventArgs e)
        {
            string user = tbUser.Text;
            string pw = tbPw.Text;
            if (myData.login(user, pw))
            {

               
                FormDashboard frm2 = new FormDashboard();
                frm2.CustomUser = user;
                frm2.Show();

                this.Hide();


            }
            else
            {
                MessageBox.Show($"{user} exestiert nicht oder das Password ist falsch");
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

