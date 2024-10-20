namespace Soru_3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());


        double mutDeger = Math.Abs(sayi);

        Console.WriteLine($"Girdiğiniz sayının mutlak değeri: {mutDeger}");
    }
}
