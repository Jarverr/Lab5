using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPT
{
    public class TPHContext:DbContext
    {
        public DbSet<Computer> Computers{ get; set; } //table per herarchy jest domyslny  jedna tabela i reszta dziedziczy?
        //przez to robi sie bałagan po stronie BD
        
    }
}
