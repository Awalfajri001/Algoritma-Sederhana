using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            // c = b+a;
            int b;
            int a;
            int c;
            Console.WriteLine("Masukkan Nilai b =");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Nilai a=");
            a = int.Parse(Console.ReadLine());

            c= b+a;

            Console.WriteLine("Masukkan Hasil c adalah "+c);
        }
    }
}
