namespace İlkHaftaÖdevleri_1._Soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kitap sorusu

            int ilkGunOkunan = 50;
            int ToplamSayfa = 900;
            int GunlukOkunan = 30;
            int Gun = 0;

            ToplamSayfa = ToplamSayfa - ilkGunOkunan;
            Gun++;

            while (ToplamSayfa >= 0)
            {
                ToplamSayfa = ToplamSayfa - GunlukOkunan;
                Gun++;

            }
            Console.WriteLine(" Gün Sayısı " + Gun);

            Console.WriteLine("******************************");

            int Gun2 = 1;
            for (int i = 50; i <= 900; i=i+30)
            {
                Gun2++;

            }
            Console.WriteLine(" Gün Sayısı " + Gun2);

        }
    }
}