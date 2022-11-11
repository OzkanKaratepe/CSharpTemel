using System;

namespace _03._1Medotornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int number3 = 40;
            int number4 = 100;
            int sonuc2 = OrnekTopla2(ref number3, number4);

            Console.WriteLine(sonuc2);
            Console.WriteLine(number3);
            Console.ReadLine();

            int number5;
            int number6 = 100;
            int sonuc3 = OrnekTopla3(out number5, number6);

            Console.WriteLine(sonuc3);
            Console.WriteLine(number5);
            Console.ReadLine();

            Console.WriteLine(ToplamaIslemiToplu(200, 1, 2, 23, 3, 59, 5, 6, 7, 8, 95));
            Console.ReadLine();

            static int ToplamaIslemiToplu(params int[] sayilar)
            {
                return sayilar.Sum();
            }

     
        }
        

        static int OrnekToplam1(int number1, int number2)
        {
            number1 = 50;
            int sonuc = number1 + number2;
            return sonuc;
        }

        static int OrnekTopla2(ref int number3, int number4)
        {
            number3 = 50;
            int sonuc = number3 + number4;
            return sonuc;
        }

        static int OrnekTopla3(out int number1, int number2)
        {
            number1 = 60;
                int sonuc = number1 + number2;
            return sonuc;
        }

        static int OrnekTopla3(out int number1, int number2, int number3)
        {
            number1 = 60;
            int sonuc = number1 + number2 + number3;
            return sonuc;
        }

    }

}