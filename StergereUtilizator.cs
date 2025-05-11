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
    public partial class StergereUtilizator : Form
    {
        public StergereUtilizator()
        {
            InitializeComponent();
            RefreshUtilizatori();
        }

        private void stergereBtn_Click(object sender, EventArgs e)
        {
            string username = utilizatorCBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(username))
            {
                using (UtilizatorDBContext ctx = new UtilizatorDBContext())
                {
                    var utilizator = ctx.Utilizator.FirstOrDefault(x => x.Username == username);
                    if (utilizator != null)
                    {
                        DialogResult res = MessageBox.Show("Siguri doresti sa stergi utilizatorul?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            ctx.Utilizator.Remove(utilizator);
                            ctx.SaveChanges();
                            MessageBox.Show("Utilizatorul a fost sters cu succes", "Stergere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshUtilizatori();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Utilizatorul nu a fst gasit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else {
                MessageBox.Show("Selecteaza un utilizator!", "Stergere", MessageBoxButtons.OK);
                
            }

        }

        private void utilizatorCBox_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void RefreshUtilizatori()
        {
            utilizatorCBox.SelectedIndexChanged -= utilizatorCBox_SelectedIndexChanged;

            using (UtilizatorDBContext ctx = new UtilizatorDBContext())
            {
                var utilizatori = ctx.Utilizator.Select(u => u.Username).ToList();
                utilizatorCBox.DataSource = utilizatori;
            }

            utilizatorCBox.SelectedIndexChanged += utilizatorCBox_SelectedIndexChanged;
        }

    }
}
