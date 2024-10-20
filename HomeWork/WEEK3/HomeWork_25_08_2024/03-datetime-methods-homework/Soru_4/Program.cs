namespace Soru_4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci tarihi girin (YYYY-MM-DD formatında): ");
        string tarih1Str = Console.ReadLine();

        Console.Write("İkinci tarihi girin (YYYY-MM-DD formatında): ");
        string tarih2Str = Console.ReadLine();

        DateTime tarih1;
        DateTime tarih2;


        if (DateTime.TryParse(tarih1Str, out tarih1) && DateTime.TryParse(tarih2Str, out tarih2))
        {

            TimeSpan fark = tarih2 - tarih1;
            Console.WriteLine($"İki tarih arasındaki gün farkı: {Math.Abs(fark.Days)} gün");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen YYYY-MM-DD formatında tarihler girin.");
        }
    }
}
