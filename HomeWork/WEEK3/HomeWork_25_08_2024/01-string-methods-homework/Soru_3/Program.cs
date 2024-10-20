namespace Soru_3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();

        Console.Write("Hangi kelimeyi saymak istersiniz? ");
        string kelime = Console.ReadLine();

        string[] kelimeler = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int kelimeSayisi = 0;


        for (int i = 0; i < kelimeler.Length; i++)
        {
            if (kelimeler[i].ToLower() == kelime.ToLower()) // 
            {
                kelimeSayisi++;
            }
        }

        Console.WriteLine($"'{kelime}' kelimesi {kelimeSayisi} kere geçiyor.");
    }
}
