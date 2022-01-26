using System;

namespace ForİleÇarpımTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Döngüsü İle Çarpım Tablosu

            for (int i = 1; i <= 10; i++)
            {
                for (int a = 0; a <= 10; a++)
                {
                    Console.WriteLine(i + "*" + a + "=" + (i * a));
                }
            }
            Console.ReadLine();
        }
    }
}
