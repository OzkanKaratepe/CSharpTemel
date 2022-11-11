namespace İlkHaftaÖdevleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 50 ile 100 arasındaki 3'e tam bölünen sayıların toplamı.
            int sayi1, sayi2, toplam = 0;
            Console.WriteLine("İlk Sayı");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayı");
            sayi2 = int.Parse(Console.ReadLine());


            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    toplam = toplam + i;
                }
            }
            Console.WriteLine("3 e Bölünebilen sayıların toplamı {0}", toplam);
            Console.ReadLine();

        }
 

    }
}