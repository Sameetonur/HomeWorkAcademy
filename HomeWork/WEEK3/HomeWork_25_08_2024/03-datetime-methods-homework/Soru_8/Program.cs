namespace Soru_8;

class Program
{
    static void Main(string[] args)
    {
        DateTime suan = DateTime.Now;

        string ayAdi = suan.ToString("MMMM");

        Console.WriteLine($"Şu anki ay => {ayAdi}");
    }
}
