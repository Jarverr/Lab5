using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TSES
{
    public class Context: DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Computer>().Map(map =>
            {
                map.Properties(prop => new //chcemy do jednej tabeli stringi do dugiej inty
                {
                    prop.CoolingType,
                    prop.Description
                });
                map.ToTable("PolaTekstowe");
            }).Map(map =>
            {
                map.Properties(prop => new
                {
                    prop.Price,
                    prop.Weight
                });
                map.ToTable("PolaLiczbowe");
            });

        }
    }
}
