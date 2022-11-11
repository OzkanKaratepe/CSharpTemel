namespace _03.Methotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Çalıştığı anda çalışan method içerisindeyim!");
            Console.ReadLine();

            EkranaYaz();
            Console.ReadLine();
        }

        static void EkranaYaz()
        {
            Console.WriteLine("Özkan KARATEPE");
        }

        static int Toplama(int sayi1 , int sayi2)
        {
           return sayi1 + sayi1;
        }

        // static double KdvHesapYap(double Fiyat, ;)
        static double KdvHesapYap(double Fiyat,double kDVOrani)
        {
            return Fiyat+(Fiyat * kDVOrani)/100;
        }
        static void Deneme() {
            int toplamSonuc = Toplama(50, 100);
            Console.WriteLine(toplamSonuc);
            Console.WriteLine("----------------");
            double urunFiyat = 999.90;
            int kDVOrani = 8;
            double kDVUcreti = KdvHesapYap(urunFiyat, kDVOrani);
            double toplamFiyat = urunFiyat + kDVUcreti;

            Console.WriteLine("Ürün Fiyat: {0} Tl olan bir ürünün KDV oranı: {1}, Vergi Ücreti: {2} Tl Toplam Ücret: {3} Tl", urunFiyat,
                kDVOrani, kDVUcreti, toplamFiyat);

            Console.ReadLine();

           }
    }
}