using System;
using System.Diagnostics;

namespace Uppgift_2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad har du för lön?");
            string strLön = Console.ReadLine();
            Console.WriteLine("Vad har han för lön?");
            string strLön2 = Console.ReadLine();
            Console.WriteLine("Vad har hon för lön?");
            string strLön3 = Console.ReadLine();

            int intLön = int.Parse(strLön);
            int intLön2 = int.Parse(strLön2);
            int intLön3 = int.Parse(strLön3);

            int Summa = (intLön + intLön2 + intLön3) / 3 ;

            Console.WriteLine("Medelvärdet på era löner är " + Summa + "kr");


        }
    }
}
