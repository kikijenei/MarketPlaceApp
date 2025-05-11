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
    public partial class Cumparare : Form
    {
        private string denumire;
        private int cantitate;
        public Cumparare()
        {
            InitializeComponent();
            AfisareComboBox();
        }
        private async void AfisareComboBox()
        {
            var produs = await Task.Run(() =>
            {
                using (ProdusDBContext ctx = new ProdusDBContext())
                {
                    return ctx.Produs.Select(p => p.Denumire).ToList();
                }
            });
            denumireCBox.Invoke(new Action(() =>
            {
                denumireCBox.DataSource = produs;
            }));
        }


        private async void cumparaBtn_Click(object sender, EventArgs e)
        {
            int cantitate_cumparat = (int)numCantCumparat.Value;
            if (cantitate_cumparat < 0)
            {
                MessageBox.Show("Trebuie o cantitate valida..", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cantitate_cumparat > cantitate)
            {
                MessageBox.Show("Trebuie o cantitate valida..", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await Task.Run(() =>
            {
                using (ProdusDBContext ctx = new ProdusDBContext())
                using (IstoricDBContext ctx2 = new IstoricDBContext())
                {
                    var produs = ctx.Produs.FirstOrDefault(p => p.Denumire == denumire);
                    if (produs != null)
                    {
                        produs.Cantitate -= cantitate_cumparat;
                        var istoric = new IstoricVanzari
                        {
                            IdProdus = produs.Id,
                            Cantitate = cantitate_cumparat
                        };
                        ctx2.IstoricVanzari.Add(istoric);
                        if (produs.Cantitate == 0)
                        {
                            ctx.Produs.Remove(produs);
                        }

                        ctx.SaveChanges();
                        ctx2.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Eroare", "Eroare");
                    }
                }

            });
            this.Invoke(new Action(() => {
                MessageBox.Show("O anume cantitate din produs s-a cumparat cu succes.", "Cumparare Cantitate Produs");
                RefreshLista();
                this.Close();
            }));

        }

        private async void RefreshLista()
        {
            var produs = await Task.Run(() => {
                using (ProdusDBContext ctx = new ProdusDBContext())
                {
                    return ctx.Produs.FirstOrDefault(p => p.Denumire == denumire);
                }
            });
            if (produs != null)
            {
                cantitate = produs.Cantitate;
                cantitatedispLbl.Text = cantitate.ToString();
            }
            else
            {
                cantitatedispLbl.Text = "0";
            }

        }

        private async void denumireCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string denumirealeasa = denumireCBox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(denumirealeasa) && !string.IsNullOrWhiteSpace(denumirealeasa))
            {
                var produs = await Task.Run(() =>
                {
                    using (ProdusDBContext ctx = new ProdusDBContext())
                    {
                        return ctx.Produs.FirstOrDefault(p => p.Denumire == denumirealeasa);
                    }
                });

                if (produs != null)
                {
                    denumire = produs.Denumire;
                    cantitate = produs.Cantitate;
                    cantitatedispLbl.Invoke(new Action(() =>
                    {
                        cantitatedispLbl.Text = cantitate.ToString();
                    }));
                }
                else
                {
                    MessageBox.Show("Produsul nu are nici o cantitate...");
                }

            }

        }
    }
}
