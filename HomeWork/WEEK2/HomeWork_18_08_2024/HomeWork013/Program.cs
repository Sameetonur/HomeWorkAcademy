namespace HomeWork013;

class Program
{
    static void Main(string[] args)
    {
        long sayi = 500000000000000000;
        int sayi2 = Convert.ToInt32(sayi);
        System.Console.WriteLine(sayi2);

        // long değişkeninin int değişkenine göre çok daha fazla sayı tutabildiği için int değerinin dönüştüremediğini görüyoruz.
    }
}
