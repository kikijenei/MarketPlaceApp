using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace Proiect2
{

    internal sealed class ConfigurareMigrare : DbMigrationsConfiguration<ProdusDBContext>
    {
        public ConfigurareMigrare()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }
        protected override void Seed(ProdusDBContext context){
            
        }
    }
}
