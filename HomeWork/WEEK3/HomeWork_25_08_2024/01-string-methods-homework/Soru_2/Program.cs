namespace Soru_2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir metin girin: ");
        string metin = Console.ReadLine();


        string buyukHarf = metin.ToUpper();
        string kucukHarf = metin.ToLower();


        Console.WriteLine($"{buyukHarf}\n{kucukHarf}");
    }
}
