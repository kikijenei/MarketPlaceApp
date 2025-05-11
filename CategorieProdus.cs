using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2
{
    [Table("CategorieProdus")]
    public class CategorieProdus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Denumire { get; set; }

        // public virtual Produs Produs { get; set; }
        public virtual ICollection<Produs> Produs { get; set; }
    }

    //nu a functionat cu migrarea datelor folosind System.Data.SQLite.EF6.Migrations

    //public class CategorieDBContext : DbContext
    //{
    //    public CategorieDBContext() : base("name=MagazinDbContext")
    //    {

    //    }
    //    //public DbSet<Produs> Produs { get; set; }
    //    public DbSet<CategorieProdus> CategorieProdus { get; set; }
    //    //public DbSet<IstoricVanzari> IstoricVanzari { get; set; }


    //}

    public class CategorieDBContext : DbContext
    {
        public CategorieDBContext() : base("name=MagazinDbContext")
        {

        }
        public DbSet<CategorieProdus> CategorieProdus { get; set; }
    }
}
