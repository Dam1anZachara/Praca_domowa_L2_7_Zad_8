using System;

namespace L2_7_Zad_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzi czy kandydat może ubiegać się o miejsce na studiach.");
            Console.Write("Podaj wynik matury z matematyki: ");
            byte.TryParse(Console.ReadLine(), out byte mathScore);

            Console.Write("Podaj wynik matury z chemii: ");
            byte.TryParse(Console.ReadLine(), out byte chemistryScore);

            Console.Write("Podaj wynik matury z fizyki: ");
            byte.TryParse(Console.ReadLine(), out byte physicsScore);

            if ((mathScore > 70 && physicsScore > 55 && chemistryScore > 45) || (mathScore + physicsScore + chemistryScore > 180) || (mathScore + physicsScore > 150) || (mathScore + chemistryScore > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }
        }
    }
}
