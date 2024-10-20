namespace Soru_10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        bool asalMi = true;

        if (sayi <= 1)
        {
            asalMi = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }
            }
        }

        if (asalMi)
        {
            Console.WriteLine($"{sayi} asal'dır.");
        }
        else
        {
            Console.WriteLine($"{sayi} asal değildir!");
        }
    }
}
