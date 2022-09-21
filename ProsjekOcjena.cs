using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekOcjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //varijable
            int ocjena, brojOcjena = 0, negativno = 0;
            double prosjek, zbrojOcjena = 0;

            //zaglavlje aplikacije
            Console.WriteLine("###########################");
            Console.WriteLine("# Izračunjavanje Prosjeka #");
            Console.WriteLine("###########################");
            Console.WriteLine("Za kraj unesi nulu");

            //unos ocjena
            try
            {
                do
                {
                    Console.WriteLine("Unesi ocjenu: ");

                    ocjena = Convert.ToInt32(Console.ReadLine());
                    if (ocjena == 0)
                    {
                        break;
                    }
                    if (ocjena > 1 && ocjena <= 5)
                    {
                        if (ocjena == 1)
                        {
                            Console.WriteLine("Imate negativnu ocjenu.");
                            negativno++;
                            break;
                        }
                        zbrojOcjena = zbrojOcjena + ocjena;
                        brojOcjena++;
                    }
                    else
                    {
                        Console.WriteLine("Upisan je ne ispravan broj, upisi te ponovno");
                    }
                } while (ocjena != 0);
            }
            catch (Exception greska)
            {
                Console.WriteLine("Neispravan unos, pokušajte ponovno");
                Console.WriteLine("Opis greške: " + greska.Message);
            }
            //Izracun i ispis prosjeka
            if (negativno == 0)
            {
                prosjek = zbrojOcjena / brojOcjena;
                Console.WriteLine("Prosjek Ocjena je:");
                Console.WriteLine(prosjek);
            }

            //Zatvaranje aplikacije
            Console.ReadKey();
        }
    }
}