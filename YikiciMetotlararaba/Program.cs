using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YikiciMetotlararaba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı.");
            Otomobil oto = new Otomobil();
            Console.WriteLine("Program bitti.");
        }
    }
    class Otomobil
    {
        string marka = "";
        string renk = "";
        public Otomobil()
        {
            marka ="TOGG";
            renk = "kırmızı";
            Console.WriteLine("Yapıcı metot çalıştı.");
        }
        ~Otomobil()
        {
            Console.WriteLine("Nesne hafızadan atıldı.");
        }
    }


}
    

