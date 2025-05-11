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
    [Table("IstoricVanzari")]
    public class IstoricVanzari
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Produs")]
        public int IdProdus { get; set; }

        public int Cantitate { get; set; }

        public virtual Produs Produs { get; set; }
    }

    //public class IstoricDBContext : DbContext
    //{
    //    public IstoricDBContext() : base("name=MagazinDbContext")
    //    {
    //    }
    //    public DbSet<Produs> Produs { get; set; }
    //    public DbSet<CategorieProdus> CategorieProdus { get; set; }
    //    public DbSet<IstoricVanzari> IstoricVanzari { get; set; }
    //}

    public class IstoricDBContext : DbContext
    {
        public IstoricDBContext() : base("name=MagazinDbContext")
        {

        }
        public DbSet<IstoricVanzari> IstoricVanzari { get; set; }
    }
}
