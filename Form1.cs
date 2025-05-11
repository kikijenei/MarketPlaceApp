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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListaCategorii();
        }

        private void produsNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareProdus ap = new AdaugareProdus();
            ap.ShowDialog();
        }
        private void actualizareCantitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizareCantitate ac = new ActualizareCantitate();
            ac.ShowDialog();
        }
        private void vanzareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VanzareProduse vanzare = new VanzareProduse();
            vanzare.ShowDialog();
        }
        private void cautareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CautareProduse cautare = new CautareProduse();
            cautare.ShowDialog();
        }
        private async void stergereProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergerePrroduse stergere = new StergerePrroduse();
            stergere.ShowDialog();
            await RefreshListaProduse();
        }
        private async void vizualizareToateProduseleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           await RefreshListaProduse();
        }
        private void adaugareBtn_Click(object sender, EventArgs e)
        {
            AdaugareProdus ap = new AdaugareProdus();
            ap.ShowDialog();
        }
        private async void produseGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                string denumire = produseGridView.Rows[e.RowIndex].Cells["Denumire"].Value.ToString();
                int cantitate = (int)produseGridView.Rows[e.RowIndex].Cells["Cantitate"].Value;
                //int id = (int)produseGridView.Rows[e.RowIndex].Cells["Id"].Value;

                VanzareProduse vanzare = new VanzareProduse();
                vanzare.ShowDialog();

            }
            await RefreshListaProduse();
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Istoric istoric = new Istoric();
            istoric.ShowDialog();

        }
        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bun venit! Acesta este al treilea proiect!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private async void refreshBtn_Click(object sender, EventArgs e)
        {
           await RefreshListaProduse(); 
           produseGridView.Refresh();
        }
        public async Task RefreshListaProduse()
        {
            var res2 = await Task.Run(() =>
            {
                using (ProdusDBContext ctx = new ProdusDBContext())
                {
                    var res = from produs in ctx.Produs
                              select new
                              {
                                  produs.Id,
                                  produs.Denumire,
                                  produs.Descriere,
                                  produs.DataIntrare,
                                  produs.DataExpirare,
                                  produs.Cantitate,
                                  produs.IdCategorie
                              };
                    return res.ToList();
                }

            });
            Invoke((Action)(() =>
            {
                produseGridView.DataSource = res2;
            }));

        }
        private void adaugareCategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareCategorie adaugareCategorie = new AdaugareCategorie();
            adaugareCategorie.ShowDialog();
            ListaCategorii();
        }

        private void categoriiCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (CategorieDBContext ctx = new CategorieDBContext())
            //{
            //    var res = ctx.CategorieProdus.ToList();
            //    categoriiCBox.DisplayMember = "Denumire";
            //    categoriiCBox.DataSource = res;
            //}
        }
        public void ListaCategorii()
        {
            using (CategorieDBContext ctx = new CategorieDBContext())
            {
                var categorii = ctx.CategorieProdus
                                .Select(cat => new { cat.Id, cat.Denumire })
                                .ToList();
                categoriiCBox.DataSource = categorii;
                categoriiCBox.DisplayMember = "Denumire";
                categoriiCBox.ValueMember = "Id";

            }
        }

        private void afisareUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfisareUtilizatori afisare = new AfisareUtilizatori();  
            afisare.ShowDialog();
        }

        private void cautareUtilizatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CautareUtilizator cautareUtilizator = new CautareUtilizator();
            cautareUtilizator.ShowDialog();
        }

        private void stergereUtilizatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergereUtilizator stergere = new StergereUtilizator();
            stergere.ShowDialog();

        }
    }
}
