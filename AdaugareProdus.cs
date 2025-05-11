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
    public partial class AdaugareProdus : Form
    {
        public AdaugareProdus()
        {
            InitializeComponent();
            ListaCategorii();
        }

        private void ListaCategorii() {
            using (CategorieDBContext ctx = new CategorieDBContext()) {
                var res = ctx.CategorieProdus.ToList();
                categorieCBox.ValueMember = "Id";
                categorieCBox.DisplayMember = "Denumire";
                categorieCBox.DataSource = res;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (categorieCBox.SelectedValue == null) {
                MessageBox.Show("Obligatoriu trebuie selectat o categorie!", "Eroare", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            using (ProdusDBContext ctx = new ProdusDBContext())
            {
                Produs p = new Produs();
                p.Denumire = txtDenumire.Text;
                p.Descriere = txtDescriere.Text;
                p.DataIntrare = dtpDataIntrare.Value.ToString();
                p.DataExpirare = dtpDataExpirare.Value.ToString();
                p.Cantitate = (int)nupCantitate.Value;
                p.IdCategorie = (int)categorieCBox.SelectedValue;

                ctx.Produs.Add(p);
                ctx.SaveChanges();
            }
            MessageBox.Show("Produsul a fost adaugat cu succes.", "Adaugare Produs");
            Refresh();
            this.Close();

        }
    }
}
