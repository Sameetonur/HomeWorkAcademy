namespace Soru_5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Üs almak istediğiniz taban sayısını girin: ");
        double taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üs değerini girin: ");
        double ust = Convert.ToDouble(Console.ReadLine());


        double sonuc = Math.Pow(taban, ust);

        Console.WriteLine($"{taban} üssü {ust} = {sonuc}");
    }
}
