namespace Soru_6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir açı girin (derece cinsinden): ");
        double derece = Convert.ToDouble(Console.ReadLine());

        double radian = derece * (Math.PI / 180);

        double sinDegeri = Math.Sin(radian);

        Console.WriteLine($"Girdiğiniz açının sinüs değeri: {sinDegeri}");
    }
}
