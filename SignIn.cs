using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect2
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void bnSalvare_Click(object sender, EventArgs e)
        {
            using (UtilizatorDBContext ctx = new UtilizatorDBContext()) {
                string username = txtUtilizator.Text;
                string parola = txtParola.Text;
                string confirmare = txtConfirmareParola.Text;
                string status = btnAdmin.Checked ? "admin" : btnUtilizator.Checked ? "user" : null;
                if (status == null) {
                    MessageBox.Show("Trebuie sa alegeti tipul de utilizator!", "Eroare", MessageBoxButtons.OK);
                    return;
                }
                if (parola != confirmare) {
                    MessageBox.Show("Parolele nu sunt similare, incearca din nou!", "Eroare", MessageBoxButtons.OK);
                    return;
                }
                if (ctx.Utilizator.Any(u => u.Username == username)) {
                    MessageBox.Show("Acest utilizator exista deja!!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                var parola_hash = parolaHash(parola);
                var utilizator = new Utilizator { 
                    Username = username,
                    Parola = parola_hash,
                    Status = status
                };
                ctx.Utilizator.Add(utilizator);
                ctx.SaveChanges();
                MessageBox.Show("Noul utilizator s-a inregistrat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

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

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
