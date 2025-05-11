using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace Proiect2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //AplicareLimbaj();
        }
        public static string parolaHash(string parola)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] input = Encoding.UTF8.GetBytes(parola);
                byte[] hash = sha256.ComputeHash(input);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)

                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUtilizator.Text;
            string parola = txtParola.Text;
            var parola_hash = parolaHash(parola);
            using (UtilizatorDBContext ctx = new UtilizatorDBContext()) {
                var utilizator = ctx.Utilizator.FirstOrDefault(u=>u.Username == username && u.Parola == parola_hash);
                if (utilizator == null) {
                    MessageBox.Show("Trebuie sa definiti logarea!", "Logare", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (utilizator.Status == "admin")
                {
                    MessageBox.Show("Bun venit, admin!", "Logare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 formadmin = new Form1();
                    formadmin.ShowDialog();
                }
                else if (utilizator.Status == "user") {
                    MessageBox.Show("Bun venit, user!", "Logare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 formuser = new Form2();
                    formuser.ShowDialog();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("Sigur doriti sa iesiti?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
            {
                MessageBox.Show("La revedere!", "Iesire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnUitareParola_Click(object sender, EventArgs e)
        {
            ModificareParola mod = new ModificareParola();
            mod.ShowDialog();
        }

        //private void initializarelimbaj()
        //{
        //    languagecombobox.items.add(new { text = "العربية", value = "ar" });
        //    languagecombobox.items.add(new { text = "Deutsch", value = "de" });
        //    languagecombobox.items.add(new { text = "Español", value = "es" });
        //    languagecombobox.items.add(new { text = "Français", value = "fr" });
        //    languagecombobox.items.add(new { text = "English", value = "en" });
        //    languagecombobox.displaymember = "text";
        //    languagecombobox.valuemember = "value";
        //    languagecombobox.selectedindex = 0;

        //}
        //private void aplicarelimbaj()
        //{
        //    lbllogin.text = globalsettings.getstring("lbllogin");
        //    lblusername.text = globalsettings.getstring("lblusername");
        //    lblparola.text = globalsettings.getstring("lblparola");
        //    btnlogin.text = globalsettings.getstring("btnlogin");
        //    btnexit.text = globalsettings.getstring("btnexit");
        //    lbluitareparola.text = globalsettings.getstring("lbluitareparola");
        //    lbluitatparola.text = globalsettings.getstring("lbluitatparola");
        //}

        public void refreshlanguage()
        {
           // aplicarelimbaj();
        }

        //private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(languageComboBox.Text == "العربية")
        //    {


        //    }else if () { }

        //}
    }
}
