namespace Soru_10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir ondalıklı sayı girin: ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kaç ondalık basamağa yuvarlamak istersiniz? ");
        int ondalikBasamak = Convert.ToInt32(Console.ReadLine());

        double yuvarlanmisSayi = Math.Round(sayi, ondalikBasamak);

        Console.WriteLine($"Girdiğiniz sayının {ondalikBasamak} ondalık basamağa yuvarlanmış hali: {yuvarlanmisSayi}");
    }
}
