using System;

namespace Lamps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uruchomienie programu");
            LampsController lc = new LampsController();
            NewLampsController nlc = new NewLampsController();
            Console.WriteLine("Uruchomienie starego systemu");
            lc.Toggle();
            lc.Toggle();
            Console.WriteLine("Uruchomienie nowego systemu");
            nlc.MakeSound();
            nlc.Toggle();
            nlc.Toggle();
            nlc.MakeSound();
            Console.ReadKey();
        }

    }
}