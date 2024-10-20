namespace Soru_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir tarih girin (YYYY-MM-DD formatında): ");
        string tarihStr = Console.ReadLine();


        DateTime tarih;


        if (DateTime.TryParse(tarihStr, out tarih))
        {
            string gun = tarih.DayOfWeek.ToString();

            Console.WriteLine($"Girdiğiniz tarih: {tarih.ToShortDateString()} - Haftanın Günü: {gun}");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen YYYY-MM-DD formatında bir tarih girin.");
        }
    }
}
