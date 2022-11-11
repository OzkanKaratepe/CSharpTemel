namespace _01VeriTipleri
{
    internal class Program
    {

        enum Days
        {
            Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba İlk Konsol Uygulaması!");
            Console.ReadLine();

            int number1 = 2147483647;
            int number2 = -2147483647;
            long number3 = 214748323232326427;
            long number4 = -214748323232326427;
            short number5 = -32768;
            short number6 = 32767;
            byte number7 = 255;
            bool dogruMu = true;
            char karakter = 's';
            string karakterler = "Samet";
            double number8 = 10.5;
            decimal number9 = 4232124124.12323232m;
            decimal number10 = 4232124124;
            var veriTipiNey = "10";
            var veriTipiNey2 = "Samet";

            Console.WriteLine("Sayı 1: " + number1 + "TL, Sayi 2:" + number2 + " TL ");
            Console.WriteLine("Sayı 2: {0} TL, Sayi 2: {1} TL" , number1, number2);
            Console.WriteLine("Sayı 3 {0}", number3);
            Console.WriteLine("Sayı 3 {0}", number4);
            Console.WriteLine("Sayı 3 {0}", number5);
            Console.WriteLine("Sayı 3 {0}", number6);
            Console.WriteLine("Sayı 3 {0}", number7);
            Console.WriteLine("Doğrumu {0}", dogruMu);
            Console.WriteLine("Karakter {0}", karakter);
            Console.WriteLine("karakterler {0}", karakterler);
            Console.WriteLine("karakterler {0}", karakterler[2]);
            Console.WriteLine("Sayı 8 {0}", number8);
            Console.WriteLine("Sayı 9 {0}", number9);
            Console.WriteLine("Sayı 10 {0}", number10);
            Console.WriteLine("Enum Tipi {0}", Days.Cuma);
            Console.WriteLine("Enum Tipi İndex {0}", (int)Days.Cuma);
            Console.WriteLine("Veri Tipi: {0}", veriTipiNey);
            Console.WriteLine("Veri Tipi 2: {0}", veriTipiNey2);
            Console.WriteLine("");





        }
    }
}