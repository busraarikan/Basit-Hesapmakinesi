namespace Basit_Hesapmakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HesapMakinesi();
        }

        static void HesapMakinesi()
        {
            Console.Write("1. Sayiyi girin: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayiyi girin: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toplama icin 1`e basin");
            Console.WriteLine("Cikarma icin 2`e basin");
            Console.WriteLine("Carpma icin 3`e basin");
            Console.WriteLine("Bolme icin 4`e basin");

            Console.Write("Seciminiz: ");
            string secim = Console.ReadLine();
            double sonuc = 0;
            if (secim == "1")
            {
                sonuc = Toplama(sayi1, sayi2);
            }
            else if (secim == "2")
            {
                sonuc = Cikartma(sayi1, sayi2);
            }
            else if (secim == "3")
            {
                sonuc = Carpma(sayi1, sayi2);
            }
            else if (secim == "4")
            {
                sonuc = Bolme(sayi1, sayi2);
            }
            Console.WriteLine(sonuc);

        }
        static int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int Cikartma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        static int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        static float Bolme(int sayi1, int sayi2)
        {
            return sayi1 / (float)sayi2;
        }
       
    }
}
