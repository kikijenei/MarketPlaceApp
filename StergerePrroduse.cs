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
    public partial class StergerePrroduse : Form
    {
        public StergerePrroduse()
        {
            InitializeComponent();
            RefreshProduse();
        }

        private void denumireCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string denumire = denumireCBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(denumire))
            {
                using (ProdusDBContext ctx = new ProdusDBContext())
                {
                    var produs = ctx.Produs.FirstOrDefault(p => p.Denumire == denumire);
                    if (produs != null)
                    {
                        DialogResult res = MessageBox.Show("Sigur stergeti produsul?", "Stergere Produs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            ctx.Produs.Remove(produs);
                            ctx.SaveChanges();
                            MessageBox.Show("Produsul a fost sters.", "Stergere Produs");
                            RefreshProduse();
                        }
                        else if (res == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eroare", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Nu s-a gasit produs..");
                    }
                }
            }
        }

        private void RefreshProduse()
        {
            denumireCBox.SelectedIndexChanged -= denumireCBox_SelectedIndexChanged;
            using (ProdusDBContext ctx = new ProdusDBContext())
            {
                var produs = ctx.Produs.Select(p=>p.Denumire).ToList();
                denumireCBox.DataSource = produs;
            }
            denumireCBox.SelectedIndexChanged += denumireCBox_SelectedIndexChanged;
        }
    }
}
