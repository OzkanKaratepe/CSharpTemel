namespace _05Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForachDonguOrnek();
            ForDonguOrnek();

            WhileLoopOrnek();
            DoWhileLoopOrnek();

            int toplam = Toplama( 10,20 );
          
        }

        static int Toplama( int sayi1, int sayi2 ) {
            return sayi1 + sayi2;
        }

        private static void DoWhileLoopOrnek()
        {
            int sayimiz = 100;
            do
            {
                Console.WriteLine(sayimiz);
                sayimiz--;
            }
            while (sayimiz >= 0);

            Console.WriteLine("Sayınız bu{0}", sayimiz);
            Console.ReadLine();
        }

        private static void WhileLoopOrnek()
        {
            int adet = 100;
            Dondurme(adet);
            Console.WriteLine("Sayınız bu {0}", adet);
            Console.ReadLine();
        }

        private static void Dondurme(int Deger)
        {
            while (Deger >= 0)
            {
                Console.WriteLine(Deger);
                Deger--;
            }
        }

        private static void ForDonguOrnek()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Döngü Durdu");
            Console.ReadLine();
        }

        private static void ForachDonguOrnek()
        {
            string[] ogrenciler = new string[3] { "Ali", "Veli", "Hüseyin" };
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}