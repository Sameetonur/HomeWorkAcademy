namespace Soru_3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir tarih girin (YYYY-MM-DD formatında): ");
        string tarihStr = Console.ReadLine();


        DateTime tarih;


        if (DateTime.TryParse(tarihStr, out tarih))
        {
            Console.Write("Eklenecek gün sayısını girin: ");
            int gunSayisi = Convert.ToInt32(Console.ReadLine());

            DateTime yeniTarih = tarih.AddDays(gunSayisi);

            Console.WriteLine($"Girdiğiniz tarihe {gunSayisi} gün eklendi. Yeni tarih: {yeniTarih.ToShortDateString()}");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı. Lütfen YYYY-MM-DD formatında bir tarih girin.");
        }
    }
}
