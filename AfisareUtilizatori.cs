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
    public partial class AfisareUtilizatori : Form
    {
        public AfisareUtilizatori()
        {
            InitializeComponent();
        }

        private async void utilizatoriBtn_Click(object sender, EventArgs e)
        {
            await RefreshListaUtilizatori();
        }

        public async Task RefreshListaUtilizatori()
        {
            var utilizatori = await Task.Run(() =>
            {
                using (UtilizatorDBContext ctx = new UtilizatorDBContext())
                {
                    var res = from utilizator in ctx.Utilizator
                              select new
                              {
                                  utilizator.Id,
                                  utilizator.Username,
                                  utilizator.Parola,
                                  utilizator.Status
                              };
                    return res.ToList();
                }
            });
            Invoke((Action)(() =>
            {
                utilizatoriGridView.DataSource = utilizatori;
            }));
        }
    }
}
