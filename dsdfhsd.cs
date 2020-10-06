using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double AnzahlPersonen = 0, AufenthaltsDauer = 0, Zimmerpreis = 70;
            double Nettopreis = 0, Gesamtpreis = 0, MwSt = 7;

            Console.WriteLine("Mit wie vielen Personen reisen Sie an?");
            AnzahlPersonen = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie viele Tage wollen Sie übernachten?");
            AufenthaltsDauer = Convert.ToDouble(Console.ReadLine());

            Nettopreis = AnzahlPersonen * AufenthaltsDauer * Zimmerpreis;

            Gesamtpreis = Nettopreis + Nettopreis * MwSt / 100;

            Console.WriteLine("Ihre Buchung ergibt einen Nettopreis von {0} Euro", Nettopreis);

            Console.WriteLine("So ergibt sich ein Gesamtpreis von : {0} Euro (inkl. {1} % MwSt)", Gesamtpreis, MwSt);


        }
    }
}
