using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;


namespace Proiect2
{
    [Table("Produs")]
    public class Produs
    {
        [Key]
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public string DataIntrare { get; set; }
        public string DataExpirare { get; set; }
        public int Cantitate { get; set; }

        [ForeignKey("CategorieProdus")]
        public int? IdCategorie { get; set; }
        public virtual ICollection<IstoricVanzari> IstoricVanzari { get; set; }
        public virtual CategorieProdus CategorieProdus { get; set; }

    }

    public class ProdusDBContext : DbContext
    {
        public ProdusDBContext() : base("name=MagazinDbContext")
        {

        }

        public DbSet<Produs> Produs { get; set; }
        public DbSet<CategorieProdus> CategorieProdus { get; set; }
        public DbSet<IstoricVanzari> IstoricVanzari { get; set; }

    }
}
