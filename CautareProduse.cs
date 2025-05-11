using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class CautareProduse : Form
    {
        public CautareProduse()
        {
            InitializeComponent();
        }

        private void cautareBtn_Click(object sender, EventArgs e)
        {
            CautareProdus();
        }

        private void cautareTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CautareProdus();
            }
        }
        private async void CautareProdus() {
            string cautare = cautareTxt.Text;
            if (string.IsNullOrEmpty(cautare) | string.IsNullOrWhiteSpace(cautare))
            {
                MessageBox.Show("Trebuie sa introduceti un nume de produs valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var rez = await Task.Run(() => {
                using (ProdusDBContext ctx = new ProdusDBContext())
                {
                    var prodgasit = (from produs in ctx.Produs
                                     where produs.Denumire == cautare
                                     select produs).FirstOrDefault();

                    return prodgasit;
                }
            });

            if (rez != null) {
                this.Invoke((Action)(() => {
                    MessageBox.Show($"Produsul cu denumirea '{rez.Denumire}' se afla pe lista de produse.", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
            else{
                this.Invoke((Action)(() => {
                    MessageBox.Show("Produsul nu a fost gasit, incearca din nou.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }
    }
}
