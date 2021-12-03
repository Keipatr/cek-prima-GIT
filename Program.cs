using System;

namespace cek_prima_GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input angka = ");
            int angka = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i < angka; i++)
                if (angka % i == 0)
                    counter = counter + 1;
            if (counter > 2)
                Console.WriteLine("Bukan Bilangan Prima");
            else
                Console.WriteLine("Bilangan Prima");

        }
    }
}
