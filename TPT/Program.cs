using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPT
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Computers.Add(new Laptop() { Price = 1000, Description = "Standard Laptop", Weight = 3 });
            tph.SaveChanges();
            //tph zrobione baza utworzone (podejscie code first)
            var tpt = new TPTContext();
            tpt.Computers.Add(new Laptop() { Price = 1000, Description = "Lightwaight Laptop", Weight = 1 });
            tpt.SaveChanges();
            //zrobione  ladniej poukładane powydzielane na ab   stracty na dziedziczone itd ale wada jest ze trzeba robic joiny
            //ale uwaga joiny obnizaja wydajnosc dla tego tph tego nie ma (ale tam dane puchna połowa kolumn nullowych)
            var tpc = new TPCContext();
            tpc.Computers.Add(new Laptop() { Price = 1000, Description = "Lightwaight Laptop", Weight = 1 });
            tpc.SaveChanges();
            //tutaj zrobione juz TPC nie bedzie computers tylko pc i laptops mamy dwie tabele z relacja ale brak joinow odczyty szybkie


            Console.WriteLine("Ready");
            Console.ReadKey();
        }
    }
}
