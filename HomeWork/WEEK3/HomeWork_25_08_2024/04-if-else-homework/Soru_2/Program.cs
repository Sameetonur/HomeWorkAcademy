namespace Soru_2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz :");
        int girSayi = Convert.ToInt32(Console.ReadLine());

        Console.Write("Bir sayı giriniz :");

        int girSayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Bir sayı giriniz :");
        int girSayi3 = Convert.ToInt32(Console.ReadLine());
        int enBuyuk;
        int ort;
        int enKucuk;

        if (girSayi >= girSayi2 && girSayi >= girSayi3)
        {
            enBuyuk = girSayi;
            if (girSayi2 <= girSayi3)
            {
                ort = girSayi3;
                enKucuk = girSayi2;
            }
            else
            {
                enKucuk = girSayi3;
                ort = girSayi2;
            }
        }
        else if (girSayi2 >= girSayi && girSayi2 >= girSayi3)
        {
            enBuyuk = girSayi2;
            if (girSayi <= girSayi3)
            {
                ort = girSayi3;
                enKucuk = girSayi;
            }
            else
            {
                enKucuk = girSayi3;
                ort = girSayi;
            }
        }
        else
        {
            enBuyuk = girSayi3;
            if (girSayi <= girSayi2)
            {
                ort = girSayi2;
                enKucuk = girSayi;
            }
            else
            {
                enKucuk = girSayi2;
                ort = girSayi;
            }

        }
        System.Console.WriteLine("Sıralama: " + enBuyuk + ", " + ort + ", " + enKucuk);
    }




}
