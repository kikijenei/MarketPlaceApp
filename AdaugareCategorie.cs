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
    public partial class AdaugareCategorie : Form
    {
        public AdaugareCategorie()
        {
            InitializeComponent();
        }

        private async void categorieBtn_Click(object sender, EventArgs e)
        {
            bool rez = await Task.Run(() => {
                using (CategorieDBContext ctx = new CategorieDBContext())
                {
                    CategorieProdus categorie = new CategorieProdus();
                    categorie.Denumire = categorieTxt.Text;
                    ctx.CategorieProdus.Add(categorie);
                    ctx.SaveChanges();
                    return true;
                }
            });

            if (rez){
                MessageBox.Show("Categoria produsului a fost actualizata.", "Actualizare Categorie Produs");
                this.Close();
            }
            else{
                MessageBox.Show("Eroare.", "Eroare");
            }
        }

        private void categorieBtn_KeyDown(object sender, KeyEventArgs e)
        {}
    }
}
