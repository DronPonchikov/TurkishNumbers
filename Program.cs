using System;

namespace TurkishNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            while (f != 10)
            {
                int inp = Int32.Parse(Console.ReadLine());
                if (inp < 0 || inp >99)
                {

                }
                string first = "";
                string second = "";
                int n = inp / 10;
                int ost = inp % 10;

                if (n == 0 && ost == 0)
                {
                    second = "sıfır";
                }
                else if (ost == 1)
                {
                    second = "bir";
                }
                else if (ost == 2)
                {
                    second = "iki";
                }
                else if (ost == 3)
                {
                    second = "üç";
                }
                else if (ost == 4)
                {
                    second = "dört";
                }
                else if (ost == 5)
                {
                    second = "beş";
                }
                else if (ost == 6)
                {
                    second = "altı";
                }
                else if (ost == 7)
                {
                    second = " yedi";
                }
                else if (ost == 8)
                {
                    second = "sekiz";
                }
                else if (ost == 9)
                {
                    second = "dokuz";
                }
                if (n == 1)
                {
                    first = "on";
                }
                else if (n == 2)
                {
                    first = "yirmi";
                }
                else if (n == 3)
                {
                    first = "otuz";
                }
                else if (n == 4)
                {
                    first = "kırk";
                }
                else if (n == 5)
                {
                    first = "elli";
                }
                else if (n == 6)
                {
                    first = "altmış";
                }
                else if (n == 7)
                {
                    first = "yetmiş";
                }
                else if (n == 8)
                {
                    first = "seksen";
                }
                else if (n == 9)
                {
                    first = "doksan";
                }
                if (n <= 0)
                {
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine($"{first} {second}");

                }

                f++;
            }
            
           
            Console.Read();
        }
    }
}
