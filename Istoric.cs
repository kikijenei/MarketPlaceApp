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
    public partial class Istoric : Form
    {
        public Istoric()
        {
            InitializeComponent();
        }

        private async void istoricBtn_Click(object sender, EventArgs e)
        {
            var rez = await Task.Run(() =>
            {
                using (IstoricDBContext ctx1 = new IstoricDBContext())
                {
                    using (ProdusDBContext ctx2 = new ProdusDBContext())
                    {
                        using (CategorieDBContext ctx3 = new CategorieDBContext())
                        {
                            var istoric = ctx1.IstoricVanzari.ToList();
                            var produs = ctx2.Produs.ToList();
                            var categorie = ctx3.CategorieProdus.ToList();
                            var res = from ist in istoric
                                      join prod in produs on ist.IdProdus equals prod.Id
                                      join cat in categorie on prod.IdCategorie equals cat.Id into cp
                                      from cat in cp.DefaultIfEmpty()
                                      select new
                                      {
                                          ist.Id,
                                          ist.IdProdus,
                                          prod.Denumire,
                                          ist.Cantitate,
                                          //DenumireCat = cat.Denumire
                                      };
                            return res.ToList();
                        }
                    }
                }
            });
            istoricGridView.AutoGenerateColumns = true;
            istoricGridView.DataSource = null;
            istoricGridView.Rows.Clear();
            istoricGridView.DataSource = rez;


            this.Invoke((Action)(() =>
            {
                istoricGridView.DataSource = rez;

            }));
        }

    }
}
