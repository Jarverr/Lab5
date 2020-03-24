using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TSES
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();
            ctx.Computers.Add(new Computer() { Description = "Test Laptop", CoolingType = "Air", Weight = 2, Price = 1500 });
            ctx.SaveChanges();
            //zrobione ES entitySpliting idk sam sie przydziela, jeden entity podzielony na dwie rzone tabele
            var ts = new TSContext();
            ts.Computers.Add(new ComputerTS()
            {
                Description = "Test Laptop",
                CoolingType = "Air",
                Weight = 2,
                Price = 1500,
                Server = new Server() { BandWidth = 1000 } //musi byc seerver bo ustawiony hasRequired
            });

            ts.SaveChanges();
            Console.WriteLine("Ready");
            Console.ReadKey();
        }
    }
}
