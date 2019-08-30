using System;

namespace Odev2_PoligonSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Atış Poligonuna 10 adet atış yapılacaktır. atışların başarılı olup olmadığı 
               kontrol edilecek ve ona göre puanlama yapılacaktır. */
            ushort puan = 0;
            ConsoleKeyInfo yanit;

            for (ushort i = 0; i < 10; i++)
            {
            farkliTus:
                Console.WriteLine(i + 1 + ". atış hedefi vurdu mu? (E/H)");
                yanit = Console.ReadKey();
                Console.WriteLine();

                if (yanit.Key == ConsoleKey.E)
                {
                    puan += 1;
                }
                else if (yanit.Key == ConsoleKey.H)
                {
                    puan += 0;
                }
                else
                {
                    Console.WriteLine("Yanlış Tuş Girildi !!!");
                    goto farkliTus;
                }
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Atış Bitmiştir. Puanınız : " + puan);
            Console.ReadLine();
        }
    }
}
