namespace Soru_3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Bir harf giriniz :");
        char harf = char.ToLower(Console.ReadKey().KeyChar);

        if (harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'u' || harf == 'ü')
        {
            System.Console.WriteLine($"{harf} sesli bir harf girdiniz.");
        }
        else
        {
            System.Console.WriteLine($"{harf} sessiz bir harf girdiniz.");
        }


    }
}
