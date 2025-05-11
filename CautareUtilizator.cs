using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class CautareUtilizator : Form
    {
        public CautareUtilizator()
        {
            InitializeComponent();
        }

        private void cautareUtilizatorTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                e.SuppressKeyPress = true;
                CautareUtilizatori();
            }
        }

        private void cautareBtn_Click(object sender, EventArgs e)
        {
            CautareUtilizatori();
        }

        private async void CautareUtilizatori() {
            string cautare = cautareUtilizatorTxt.Text;
            if (string.IsNullOrEmpty(cautare) | string.IsNullOrWhiteSpace(cautare))
            {
                MessageBox.Show("Trebuie sa introduceti un nume de utilizator valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var rez = await Task.Run(() => {
                using (UtilizatorDBContext ctx = new UtilizatorDBContext())
                {
                    var utilizatorgasit = (from utilizator in ctx.Utilizator
                                     where utilizator.Username == cautare
                                     select utilizator).FirstOrDefault();

                    return utilizatorgasit;
                }
            });

            if (rez != null)
            {
                this.Invoke((Action)(() => {
                    MessageBox.Show($"Utilizatorul '{rez.Username}' se afla pe lista de utilizatori.\nStatus: {rez.Status}", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
            else
            {
                this.Invoke((Action)(() => {
                    MessageBox.Show("Utilizatorul nu a fost gasit, incearca din nou.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }

        }
    }
}
