namespace Soru_7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Tarihi girin (dd/MM/yyyy formatında): ");
        string tarihStr = Console.ReadLine();


        string format = "dd/MM/yyyy";
        DateTime tarih;


        if (DateTime.TryParseExact(tarihStr, format, null, System.Globalization.DateTimeStyles.None, out tarih))
        {
            Console.WriteLine($"Girdiğiniz tarih: {tarih.ToString("dd/MM/yyyy")}");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen dd/MM/yyyy formatında bir tarih girin.");
        }
    }
}
