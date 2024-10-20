namespace Soru_5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Metni girin: ");
        string metin = Console.ReadLine();

        Console.Write("Aranacak metni girin: ");
        string aranan = Console.ReadLine();


        int index = metin.IndexOf(aranan, StringComparison.OrdinalIgnoreCase);

        if (index != -1)
        {
            Console.WriteLine($"'{aranan}' metin => {index} indeksinde bulunmuştur.");
        }
        else
        {
            Console.WriteLine($"'{aranan} metin yok!");
        }
    }
}
