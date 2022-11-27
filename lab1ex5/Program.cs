using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //citim doua numere si le afisar crescator
            Console.WriteLine("Introduceti doua numere: ");
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x < y) Console.WriteLine(x + " " + y);
            else Console.WriteLine(y + " " + x);

        }
    }
}
