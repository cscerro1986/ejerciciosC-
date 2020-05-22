using System;
using CentralitaHerencia;


namespace Consola40
{
    class Program
    {
        static void Main(string[] args)
        {

            Centralita central1 = new Centralita("Telefonica Argentina");

            Local local1 = new Local("44312310", "46133637", 4, 43);
            Local local2 = new Local("44312310", "42094369", 12, 10);
            Local local3 = new Local("44312310", "43213244", 32, 12);
            Local local4 = new Local("44312310", "46113123", 43, 41);

            Provincial provincial1 = new Provincial("44312310", Provincial.Franja.Franja_2, "46133637", 4);
            Provincial provincial2 = new Provincial("44312310", Provincial.Franja.Franja_2, "46133637", 4);
            Provincial provincial3 = new Provincial("44312310", Provincial.Franja.Franja_2, "46133637", 4);

            central1 = central1 + local1;
            Console.WriteLine(central1.ToString());
            Console.ReadKey();
            central1 = central1 + local2;
            Console.WriteLine(central1.ToString());
            Console.ReadKey();
            central1 = central1 + local3;
            Console.WriteLine(central1.ToString());
            Console.ReadKey();
            central1 = central1 + local4;

            Console.WriteLine(central1.ToString());
            Console.ReadKey();
            central1 = central1 + provincial1;
            Console.WriteLine(central1.ToString());
            Console.ReadKey();
            central1 = central1 + provincial2;
            Console.WriteLine(central1.ToString());
            Console.ReadKey();
            central1 = central1 + provincial3;
            Console.WriteLine(central1.ToString());
            Console.ReadKey();
            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
    }
}
