namespace Soru_9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double kucukSayi = (sayi1 < sayi2) ? sayi1 : sayi2;

        Console.WriteLine($"Küçük sayı: {kucukSayi}");
    }
}
