using System.Linq;

namespace _04.Diziler
{
    internal class Program
    {
        static void Main(string[] args) 
        { 
            //{
            //   string[] ogrenciler = new string[3];
            //    ogrenciler[0] = "Ali";
            //    ogrenciler[1] = "Veli";
            //    ogrenciler[2] = "Hüseyin";

            //    foreach (var ogrenci in ogrenciler)
            //    {
            //        Console.WriteLine(ogrenci);
            //    }
            //   EkranaYazdır("Ali", "Veli", "Hüseyin", "Mehmet");

            //    static void EkranaYazdır(params string[] isimler)
            //    {
            //        foreach (var isim in isimler)
            //        {
            //            Console.WriteLine(isim);
            //        }
            //    }

            //    string[] ogrenciler2 = new[] { "Samet", "Ege", "Ali" };

            //    string[] ogrenciler3 = { "Samet", "Özge", "Ege" };


            string[,] bolgeler2 = new string[7, 3]
            {
                {"İstanbul","Edirne","Tekirdağ"},
                {"Ankara","Edirne","Tekirdağ"},
                {"Antalya","Edirne","Tekirdağ"},
                {"Rize","Edirne","Tekirdağ"},
                {"İzmir","Edirne","Tekirdağ"},
                {"Muş","Edirne","Tekirdağ"},
                {"Urfa","Edirne","Tekirdağ"},

            };

            Console.WriteLine(bolgeler2[0,2]);
            Console.WriteLine(bolgeler2[5, 1]);

            for (int i = 0; i <= bolgeler2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolgeler2.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler2[i, j]);

                }
                Console.WriteLine("*************");
            }
            Console.ReadLine();

            Console.ReadLine();

        }
    }
}