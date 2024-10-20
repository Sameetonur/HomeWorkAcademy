namespace Soru_4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());


        if (sayi < 0)
        {
            Console.WriteLine("Negatif sayının karekökü hesaplanamaz.");
        }
        else
        {
            double karekök = Math.Sqrt(sayi);
            Console.WriteLine($"Girdiğiniz sayının karekökü: {karekök}");
        }
    }
}
