using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a nevet:");
            string nev = Console.ReadLine();

            Console.Write("Adja meg a korát:");
            int kor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg a magasságát:");
            int magassag = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adjon meg egy masik nevet:");
            string nev2 = Console.ReadLine();

            Console.Write("Adja meg a korát:");
            int kor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg a magasságát:");
            int magassag2 = Convert.ToInt32(Console.ReadLine());

            if (magassag > magassag2 && kor >kor2)
            {
                Console.WriteLine("{0} Magasabb és idősebb mint {1} ", nev, nev2);
            }
            else
            {
                Console.WriteLine("{0} Alacsonyabb és fiatalabb mint {1}" , nev, nev2);
            }

            string fileName = "adat.txt";


            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Név: " + nev);
                    writer.WriteLine("Kor: " + kor);
                    writer.WriteLine("Magasság: " + magassag);

                    writer.WriteLine("Név: " + nev2);
                    writer.WriteLine("Kor: " + kor2);
                    writer.WriteLine("Magasság: " + magassag2);
                }

                Console.WriteLine("Az adatok ki lettek írva a {0} fájlba", fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt a fájl írása közben:" + ex.Message);
            }

            Console.ReadKey();
        }
    }
}