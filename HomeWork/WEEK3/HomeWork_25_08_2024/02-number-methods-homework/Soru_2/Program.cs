namespace Soru_2;

class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());


            if (sayi1 > sayi2)
            {
                Console.WriteLine($"Büyük sayı: {sayi1}");
            }
            else if (sayi2 > sayi1)
            {
                Console.WriteLine($"Büyük sayı: {sayi2}");
            }
            else
            {
                Console.WriteLine("İki sayı eşittir.");
            }
        }
    }
}
