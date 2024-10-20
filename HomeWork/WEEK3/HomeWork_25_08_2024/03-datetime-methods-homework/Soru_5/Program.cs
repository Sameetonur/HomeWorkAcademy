namespace Soru_5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir tarih girin (YYYY-MM-DD formatında): ");
        string tarihStr = Console.ReadLine();


        DateTime tarih;


        if (DateTime.TryParse(tarihStr, out tarih))
        {
            int gunSayisi = tarih.DayOfYear;
            
            Console.WriteLine($"Girdiğiniz tarih, yılın {gunSayisi}. günü.");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen YYYY-MM-DD formatında bir tarih girin.");
        }
    }
}
