using System;

namespace ProjectC
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Prosze wprowadzic wartosc rejestru AX: ");
            int pudelkoA = int.Parse(Console.ReadLine());

            Console.Write("Prosze wprowadzic wartosc rejestru BX: ");
            int pudelkoB = int.Parse(Console.ReadLine());

            Console.Write("Prosze wprowadzic wartosc rejestru CX: ");
            int pudelkoC = int.Parse(Console.ReadLine());

            Console.Write("Prosze wprowadzic wartosc rejestru DX: ");
            int pudelkoD = int.Parse(Console.ReadLine());
            Console.WriteLine();
          
            Console.WriteLine("Twoje wartosci to: ");

            Console.WriteLine();
            Console.WriteLine($"1. AX: {pudelkoA}");
            Console.WriteLine($"1. BX: {pudelkoB}");
            Console.WriteLine($"1. CX: {pudelkoC}");
            Console.WriteLine($"1. DX: {pudelkoD}");
            Console.WriteLine();


            int[] tablica = new int[]
            {
                pudelkoA,
                pudelkoB,
                pudelkoC,
                pudelkoD,
            };


            Wybor:
            Console.WriteLine("Wybierz swoje 2 rejestry na ktorych chcesz wykonac rozkaz");
            Console.WriteLine("A=1, B=2, C=3, D=4");
            int pudelkowybor1 = int.Parse(Console.ReadLine());
            switch (pudelkowybor1)
            {
                case 1:
                    Console.WriteLine($"Rejestr 1: {pudelkoA}");
                    break;
                case 2:
                    Console.WriteLine($"Rejestr 1: {pudelkoB}");
                    break;
                case 3:
                    Console.WriteLine($"Rejestr 1: {pudelkoC}");
                    break;
                case 4:
                    Console.WriteLine($"Rejestr 1: {pudelkoD}");
                    break;
                default:
                    Console.WriteLine("Ups sprobuj jeszcze raz");
                    goto Wybor;

            }

            int pudelkowybor2 = int.Parse(Console.ReadLine());



            switch (pudelkowybor2)
            {
                case 1:
                    Console.WriteLine($"Rejestr 2: {pudelkoA}");
                    break;
                case 2:
                    Console.WriteLine($"Rejestr 2: {pudelkoB}");
                    break;
                case 3:
                    Console.WriteLine($"Rejestr 2: {pudelkoC}");
                    break;
                case 4:
                    Console.WriteLine($"Rejestr 2: {pudelkoD}");
                    break;
                default:
                    Console.WriteLine("Ups sprobuj jeszcze raz");
                    goto Wybor;
                    
            }

            
            Console.WriteLine($"Przed zmiana {pudelkowybor1}");

            Console.WriteLine($"Przed zmiana {pudelkowybor2}");


























            //while (pudelkowybor==pudelkoa)
            //{
            //    Console.WriteLine("Rejestr 1: A");

            //}










            //interchange(ref , ref )



















        }
    }
}
