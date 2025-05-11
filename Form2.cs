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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void produseGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string denumire = produseGridView.Rows[e.RowIndex].Cells["Denumire"].Value.ToString();
                string descriere = produseGridView.Rows[e.RowIndex].Cells["Descriere"].Value.ToString();
                int cantitate = (int)produseGridView.Rows[e.RowIndex].Cells["Cantitate"].Value;

                Cumparare cumparare = new Cumparare();
                cumparare.ShowDialog();

            }
            await RefreshListaProduse();
        }
        private async void produseBtn_Click(object sender, EventArgs e)
        {
            await RefreshListaProduse();
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
                                  produs.Denumire,
                                  produs.Descriere,
                                  produs.Cantitate
                              };
                    return res.ToList();
                }

            });
            Invoke((Action)(() =>
            {
                produseGridView.DataSource = res2;
            }));

        }
    }
}
