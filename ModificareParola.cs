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

namespace Proiect2
{
    public partial class ModificareParola : Form
    {
        public ModificareParola()
        {
            InitializeComponent();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            using (UtilizatorDBContext ctx = new UtilizatorDBContext())
            {
                string username = txtUtilizator.Text;
                string parolaveche = txtParolaVeche.Text;
                string parolanoua = txtParolaNoua.Text;
                var utilizaor = ctx.Utilizator.SingleOrDefault(u => u.Username == username);
                var parola_hash = parolaHash(parolaveche);
                if (username == null) {
                    return;
                }
                if (utilizaor.Parola != parola_hash) {
                    MessageBox.Show("Parola nu este corecta, incearca din nou!", "Eroare", MessageBoxButtons.OK);
                    return;

                }
                if (parolaveche == parolanoua)
                {
                    MessageBox.Show("Parolele sunt similare, incearca din nou!", "Eroare", MessageBoxButtons.OK);
                    return;
                }
                DialogResult rez = MessageBox.Show("Sigur doriti modificarea parolei?", "Modificare parola", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rez == DialogResult.Yes) {
                    utilizaor.Parola = parolaHash(parolanoua);
                    ctx.SaveChanges();
                    MessageBox.Show("Parola s-a modificat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                
            }

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
