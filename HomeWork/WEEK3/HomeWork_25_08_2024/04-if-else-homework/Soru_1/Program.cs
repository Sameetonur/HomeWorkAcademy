namespace Soru_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz :");
        int girSayi = Convert.ToInt32(Console.ReadLine());

        if (girSayi > 0)
        {
            System.Console.WriteLine($"{girSayi} Pozitiftir.");

        }
        else if (girSayi == 0)
        {
            System.Console.WriteLine($"{girSayi}(Sıfır)");


        }
        else
        {
            System.Console.WriteLine($"{girSayi} Negatiftir.");
        }
    }
}
