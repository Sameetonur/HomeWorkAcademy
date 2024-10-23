using System.Runtime.InteropServices;
using System.Web;

namespace MethodsHomeWork;

class Program
{
    #region Soru1   Method

    // static string YasBulma(int yas)
    // {
    //     string message;

    //     if (yas >= 65)
    //     {
    //         message = "emeklilik yaşınız geldi";
    //         System.Console.WriteLine(message);

    //     }
    //     else
    //     {
    //         message = "Çalışma yaşındasınız";
    //         System.Console.WriteLine(message);

    //     }
    //     return message;


    // }
    #endregion

    #region Soru2   Method


    // static int İkiSayBüyBul(int say1, int say2)
    // {
    //     int enBüyük;
    //     if(say1>say2)
    //     {
    //         enBüyük = say1;
    //         System.Console.WriteLine(enBüyük);
    //     }else
    //     {
    //         enBüyük=say2;
    //         System.Console.WriteLine(enBüyük);
    //     }
    //     return enBüyük;
    //     System.Console.WriteLine("iki tane aynı sayı girdiniz.");
    // }

    #endregion

    #region Soru3   Method


    // static string KelTerÇev (string dizi)
    // {
    //         string terskelime="";

    //         for (int i = dizi.Length - 1; i >= 0; i--)
    //         {
    //            terskelime+=dizi[i];

    //         }

    //         return terskelime;
    // }


    #endregion

    #region Soru4   Merhod

    // static double Ort(int vize , int final)
    // {
    //     double vizeNot  = vize*0.40;
    //     double finalNot = final*0.60;

    //     double top = vizeNot+finalNot;
    //     return top; 
    // }



    #endregion

    #region Soru5   Method


    // static string[] TersÇev(string[] dizi)
    // {
    //     foreach (var item in dizi)
    //     {
    //         System.Console.WriteLine(item.ToUpper());
    //     }
    //     return dizi;

    // }
    #endregion

    #region Soru6   Method
    //  static string TekCift(int sayi)
    // {
    // string message;
    // if(sayi%2==0)
    // {
    //     message=$"Bu sayı çifttir ve Girdiğiniz sayı => {sayi}";
    //     System.Console.WriteLine(message);

    // }
    // else
    // {
    //     message=$"Girdiğiniz sayı tektir ve girdiğiniz sayı => {sayi}";
    //     System.Console.WriteLine(message);

    // }
    // return message;

    #endregion

    #region Soru7   Metmod

    // static string Tarih(int saat, int dakika, int saniye)
    // {
    //     DateTime tar = new DateTime(1,1,1,saat,dakika,saniye);

    //     return tar.ToString("HH:mm:ss");
    // }

    #endregion

    #region Soru8   Method

    // static int FahÇevirme(int sayı)
    // {
    //    int sentgratÇev=sayı-32;
    //     return sentgratÇev;
    // }

    #endregion

    #region Soru9   Method

    // static int EnKucukSay(int[] dizi)
    // {
    //     int enkucuksay=dizi[2];
    //     for (int i = 0; i < dizi.Length; i++)
    //     {
    //         if(dizi[i] < enkucuksay)
    //         {
    //             enkucuksay=dizi[i];
    //         }
    //     }
    //     return enkucuksay;
    // }

    #endregion

    #region Soru10  Method

    // static int DiziTop(int[] dizi)
    // {
    //     int top=0;
    //     foreach (var item in dizi)
    //     {
    //         top+=item;
    //     }
    //     return top;
    // }
    #endregion

    #region Soru11  Method

    // static int SesliBulma(string dizi)
    // {
    //     char[] seslidizi = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
    //     int sayaç = 0;
    //     for (int i = 0; i < dizi.Length; i++)
    //     {
    //         for (int j = 0; j < seslidizi.Length; j++)
    //         {
    //             if (dizi[i] == seslidizi[j])
    //             {
    //                 sayaç++;

    //             }
    //         }
    //     }
    //     return sayaç;
    // }
    #endregion

    #region Soru12 Method
    // static string HaftaninGunu(DateTime tarih)
    // {
    //     return tarih.DayOfWeek.ToString();
    // }

    #endregion

    #region Soru13 Metod

    // public static int KelimeSayisi(string metin)
    // {
    //     
    //     string[] kelimeler = metin.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);    
    //     return kelimeler.Length;
    // }

    #endregion

    #region Soru14 Method

    // public static int GunSayisi(DateTime tarih1, DateTime tarih2)
    // {
    //     TimeSpan fark = tarih2 - tarih1;
    //     return Math.Abs(fark.Days); 
    // }


    #endregion

    #region Soru15 Method

    // public static double Ortalama(int[] dizi)
    // {

    //     int toplamElemanSayisi = dizi.Length;
    //     if (toplamElemanSayisi == 0)
    //     {
    //         return 0; 
    //     }

    //     int toplam = 0;
    //     for (int i = 0; i < toplamElemanSayisi; i++)
    //     {
    //         toplam += dizi[i];
    //     }
    //     return (double)toplam / toplamElemanSayisi;
    // }

    #endregion
    #region Soru16 Method


    #endregion

    #region Soru17 Method

    // public static int SayiyiSay(List<int> liste, int sayi)
    // {
    //     int sayac = 0; 

    //     foreach (int eleman in liste)
    //     {
    //         if (eleman == sayi) 
    //         {
    //             sayac++; 
    //         }
    //     }
    //     return sayac; 
    // }

    #endregion

    #region Soru18 Method

    // public static string IsımDön(string ad, string soyad)
    // {
    //     return ad + " " + soyad; 
    // }

    #endregion

    #region Soru19 Method

    // public static List<int> AsalSayilariBul(int altSınır, int üstSınır)
    // {
    //     List<int> asalSayilar = new List<int>(); 

    //     for (int sayi = altSınır; sayi <= üstSınır; sayi++)
    //     {
    //         if (AsalMi(sayi)) 
    //         {
    //             asalSayilar.Add(sayi); 
    //         }
    //     }

    //     return asalSayilar; 
    // }
    // private static bool AsalMi(int sayi)
    // {
    //     if (sayi <= 1) return false; 

    //     for (int i = 2; i <= Math.Sqrt(sayi); i++)
    //     {
    //         if (sayi % i == 0) return false; 
    //     }

    //     return true; 
    // }


    #endregion

    #region Soru20 Method

    // public static string StringleriBirleştir(string[] dizi)
    // {
    //     string birlesikString = ""; 

    //     foreach (string eleman in dizi)
    //     {
    //         birlesikString += eleman;
    //     }

    //     return birlesikString;

    //     #endregion
    // }    
    
        
    #endregion


    static void Main(string[] args)
    {


        //  System.Console.WriteLine("Bir yaş giriniz => ");
        //  int input = int.Parse(Console.ReadLine());
        // YasBulma(input);

        //    İkiSayBüyBul(5,8);


        // Console.Write("Bir kelime girin: ");
        // string kullaniciKelime = Console.ReadLine();
        // System.Console.WriteLine(KelTerÇev(kullaniciKelime));


        // System.Console.WriteLine(Ort(50,90));


        // string[] mehmet= {"ahmet","murat","elif","burak","aleyna"};
        // TersÇev(mehmet);

        // TekCift(858);

        // System.Console.WriteLine("Saat giriniz (0-23)");
        // int input1 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Dakika giriniz (0-59)");
        // int input2 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Saat giriniz (0-59)");
        // int input3 = int.Parse(Console.ReadLine());

        // System.Console.WriteLine(Tarih(input1,input2,input3));  

        // System.Console.WriteLine($"{FahÇevirme(50)}Fah");

        // int[] dizi = {11,10,51,100,55,99,};

        // System.Console.WriteLine(EnKucukSay(dizi));

        // int[] dizi = { 5, 5, 5, 5, 5, 5,};

        // System.Console.WriteLine(DiziTop(dizi));

        // string nwedizi = "mehmetkerimie";

        // System.Console.WriteLine(SesliBulma(nwedizi));





    }
}
