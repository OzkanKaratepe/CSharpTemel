namespace _02SartBloklar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 20;
            int sayi2 = 30;
            int sayi3 = 40;

            if(sayi1< sayi2)
            {
                Console.WriteLine("Sayi 1 Sayi 2 den küçüktür. Sayı: 1 {0}, Sayı: 2 {1}", sayi1, sayi2);
            }
            else
            {
                Console.WriteLine("Sayi 2 Sayi 1 den küçüktür.Yada eşittir. Sayı: 1 {0}, Sayı: 2 {1}", sayi1, sayi2);

            }

            if(sayi3<sayi2 || sayi3<sayi1)
            {
                Console.WriteLine("Sayi 3 Sayi 2 den küçüktür. Sayı: 1 {0}, Sayı: 2 {1}", sayi3, sayi2);
            }

            

            int switchSayimiz = 10;
            switch (switchSayimiz)
            {
                case 10:
                    Console.WriteLine("Sayımız 10dur.");
                    break;
                case 20:
                    Console.WriteLine("Sayımız 20dir.");
                    break;
                default:
                    Console.WriteLine("Sayımız 10 ve 20 değildir.");
                    break;
            }
            Console.ReadLine();


        }
    }
}