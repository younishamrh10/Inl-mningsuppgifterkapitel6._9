using System;

namespace Inlämningsuppgifterkapitel6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            do
            {
                Console.WriteLine("1. Är ett primtal?");
                Console.WriteLine("2. Antalet primtal mindre än n");
                Console.WriteLine("3. Avsluta programmet");
                val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        {
                            Console.WriteLine("Skriv ett tal för att veta om det är ett primtal eller inte");
                            int tal = int.Parse(Console.ReadLine());
                            Console.WriteLine(Prim(tal));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Skriv ett tal för att veta hur många primtal som är innan detta talet du valde");
                            int tal = int.Parse(Console.ReadLine());
                            Console.WriteLine(Primtal(tal));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Programmet avslutas");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Inte ett giltigt svar");
                            break;
                        }
                }
            } while (val != 3);
            Console.ReadKey();
        }
        static bool Prim(int tal)
        {
            int deltal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (tal % i == 0)
                {
                    deltal++;
                }
            }
            if (deltal == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int Primtal(int tal)
        {
            int deltal = 0;
            int primtal = 0;
            for (int j = 1; j < tal; j++)
            {
                for (int i = 2; i < tal; i++)
                {
                    if (j % i == 0 && j != i)
                    {
                        deltal++;
                    }
                }
                if (deltal == 0)
                {
                    primtal++;
                }
                deltal = 0;
            }
            return primtal;
        }
    }
}