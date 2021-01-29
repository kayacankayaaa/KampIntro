using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bistDun = 1524.49;
            double bistBugun = 1524.49;

            if (bistBugun>bistDun)
            {
                Console.WriteLine("Borsa bugün yükselmiş!");
            }
            else if (bistBugun < bistDun)
            {
                Console.WriteLine("Borsa bugün düşmüş!");
            }
            else
            {
                Console.WriteLine("Borsa bugün yatay!");
            }

        }
    }
}
