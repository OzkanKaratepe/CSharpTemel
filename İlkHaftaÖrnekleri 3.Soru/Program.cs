namespace İlkHaftaÖrnekleri_3.Soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi;
            int adet = 0;
            double fiyat = 0;
            double kdv = 18;
            double toplamFiyat = 0;

            Console.WriteLine(" Ürün Adı; ");
            adi = Console.ReadLine();

            Console.WriteLine(" Ürün Adeti; ");
            adet = int.Parse(Console.ReadLine());

            Console.WriteLine(" Ürün Fiyatı; ");
            fiyat = double.Parse(Console.ReadLine());

            //kdv = fiyat * 18 / 100;
            kdv = ((adet * fiyat) * kdv / 100);
            toplamFiyat = fiyat + kdv;
            Console.WriteLine("{0} Ürün Fiyatımız :{1} TL",adi,toplamFiyat);

            string mesaj = adi + "Ürün Fiyatımız :" + toplamFiyat + "TL";
            Console.WriteLine(mesaj);

        }
    }
}