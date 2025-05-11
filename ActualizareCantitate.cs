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
    public partial class ActualizareCantitate : Form
    {
        public ActualizareCantitate()
        {
            InitializeComponent();
        }

        private async void actualizareBtn_Click(object sender, EventArgs e)
        {
            int idProdus;
            if(!int.TryParse(idTxt.Text, out idProdus))
            {
                MessageBox.Show("Eroare, trebuie un id valid...", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool rez = await Task.Run(() => {
                using (ProdusDBContext ctx = new ProdusDBContext())
                {
                    var produs = ctx.Produs.FirstOrDefault(p => p.Id == idProdus);
                    if (produs == null)
                    {
                        return false;
                    }
                    else
                    {
                        produs.Cantitate = (int)nupCantitate.Value;

                        ctx.SaveChanges();

                        return true;
                    }
                }
            });

            if (rez) {

                MessageBox.Show("Cantitateta produsului a fost actualizata.", "Actualizare Cantitatea Produsului");
                this.Close();
            }
            else{
                MessageBox.Show("Eroare, produsul nu a fost gasit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
