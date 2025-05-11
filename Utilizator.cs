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
   [Table ("Utilizator")]
    public class Utilizator
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Parola { get; set; }
        
        public string Status { get; set; }// admin sau user simplu 
    }

    public class UtilizatorDBContext : DbContext
    {
        public UtilizatorDBContext() : base("name=MagazinDbContext")
        {

        }
        public DbSet<Utilizator> Utilizator { get; set; }

    }

}
