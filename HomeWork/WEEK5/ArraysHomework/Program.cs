using System.IO.Compression;
using System.Reflection.PortableExecutable;

namespace ArraysHomework;

class Program
{
    static void Main(string[] args)
    {
        #region soru1
        //10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisi içinde, dizinin her bir elemanının yalnızca bir önceki ve bir sonraki elemanı ile kıyaslandığı bir algoritma yazın. Bu algoritma, yalnızca kendinden önceki sayı ve kendinden sonraki sayı büyük olan elemanları bulmalı ve bunları ekrana yazdırmalıdır.
        // int[] sayılar = { 3, 5, 2, 8, 4, 15, 20, 11, 12, 9 };

        // for (int i = 1; i < sayılar.Length - 1; i++)
        // {
        //     if (sayılar[i] > sayılar[i - 1] && sayılar[i] > sayılar[i + 1])
        //     {
        //         System.Console.WriteLine($"{sayılar[i]} sağındaki ve solundaki sayılardan büyüktür!");
        //     }   
        // }
        #endregion

        #region Soru2
        // Klavyeden girilen 10 sayıyı bir diziye atayın. Bu sayılardan çift olanları `for` döngüsü kullanarak ayrı bir diziye aktarın.Ardından bu çift sayı dizisini küçükten büyüğe sıralayın.
        // int[] dizi = new int[10];
        // int[] ciftDizi = new int[10];
        // int sayaç = 0;
        // System.Console.WriteLine("10 adet sayı giriniz = ");

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     while (!int.TryParse(Console.ReadLine(), out dizi[i]))
        //     {
        //         System.Console.WriteLine("geçerli sayı giriniz");
        //     }
        // }

        // System.Console.WriteLine("------------------------------------------------");

        // foreach (var sayı in dizi)
        // {
        //     System.Console.WriteLine(sayı);
        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     if (dizi[i] % 2 == 0)
        //     {
        //         ciftDizi[sayaç] = dizi[i];
        //         sayaç++;

        //     }

        // }
        // Array.Resize(ref ciftDizi,sayaç);
        // Array.Sort(ciftDizi,0,sayaç);
        // System.Console.WriteLine("Çiftve küçükten büyüğe sıralı dizilerim ");
        // foreach (var item in ciftDizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        #endregion

        #region Soru3

        // 10 elemanlı rastgele değerlerden oluşan bir dizideki tüm pozitif sayıları ve negatif sayıları ayrı dizilere ayıran ve her iki diziyi de ekrana yazdıran bir program yazın.İşlemi gerçekleştirmek için `while` döngüsü kullanın.

        // int[] dizi = new int[10];
        // int[] pozDizi = new int[10];
        // int[] negdİZİ = new int[10];
        // int sayaç = 0;
        // int sıra = 1;
        // int sayaç1 = 1;

        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(-10, 11);
        // }

        // foreach (var eleman in dizi)
        // {
        //     // for (int i = 1; i <= dizi.Length ; i++)
        //     // {
        //     //      sıra = i;
        //     // }
        //     System.Console.WriteLine($"{sayaç1}. {eleman}");
        //     sayaç1++;

        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     if (dizi[i] > 0)
        //     {
        //         pozDizi[sayaç] = dizi[i];
        //         sayaç++;
        //     }

        //     if (dizi[i] < 0)
        //     {
        //         negdİZİ[sayaç] = dizi[i];
        //         sayaç++;
        //     }


        // }
        // System.Console.WriteLine("Negatif dizim");
        // System.Console.WriteLine("---------------------------------");
        // foreach (var item in negdİZİ)
        // {
        //     System.Console.WriteLine(item);
        // }
        // System.Console.WriteLine("pozitif dizim");
        // System.Console.WriteLine("---------------------------------");
        // foreach (var item in pozDizi)
        // {
        //     System.Console.WriteLine(item);
        // }


        #endregion

        #region Soru4

        // //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde tekrar eden elemanları bulan bir program yazın.Diziyi tararken, elemanların hangi pozisyonlarda(kaçıncı indexte) tekrarlandığını ekrana yazdırın.Bu işlemi hem `for` hem de `foreach` döngüleri ile gerçekleştirin.
        // int sayaç=0;
        // int sayaç1 = 0;
        // int sayaç2= 0;
        // bool tekrar=false;
        // int[] dizi = new int[20];
        // int[] tekrarElDiz = new int[20];

        // int addSayaç=0;

        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length ; i++)
        // {
        //     dizi[i]=rnd.Next(1,21);
        // }

        // foreach (var eleman in dizi)
        // {
        //     System.Console.WriteLine($" {sayaç}. Elemanı =>{eleman}");
        //     sayaç++;
        // }

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     for (int j = i + 1; j < dizi.Length; j++)
        //     {
        //         if (dizi[i] == dizi[j])
        //         {
        //             Console.WriteLine($"Sayı {dizi[i]} index {i} ve index {j} tekrar ediyor.");
        //         }
        //     }
        // }
        #endregion

        #region Soru5
        //Klavyeden girilen bir sayının, 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde olup olmadığını kontrol eden bir algoritma yazın.Eğer sayı  dizide varsa, sayının dizideki yerini ve tekrar sayısını ekrana yazdırın.
        //     int sayaç = 0;
        //     int[] dizi = new int[20];
        //     int sayaç1=0;

        //     Random rnd = new Random();

        // System.Console.WriteLine("bir sayı giriniz");
        // int input = int.Parse(Console.ReadLine());

        //     for (int i = 0; i < dizi.Length; i++)
        //     {
        //         dizi[i] = rnd.Next(1, 21);
        //     }
        //     foreach (var item in dizi)
        //     {
        //         System.Console.WriteLine($" {sayaç}.İndex = {item}");
        //         sayaç++;
        //     }
        //     for (int i = 0; i < dizi.Length; i++)
        //     {

        //         if(dizi[i] == input)
        //         {
        //             sayaç1++;
        //             System.Console.WriteLine($"Girilen sayı => {i}.İndexte bulunuyor. "); 
        //         }

        //     }
        //     System.Console.WriteLine($"Girdiğiniz (sayı= {input}) dizide {sayaç1} kere geçiyor");
        #endregion

        #region Soru6
        //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en büyük ve en küçük sayıyı bulan programı yazın.

        // int[] dizi = new int[10];

        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length; i++)
        // {   
        //     dizi[i]=rnd.Next(1,11);
        // }

        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        // Array.Sort(dizi);
        // int enBuyuk = dizi[0];
        // System.Console.WriteLine($"Dizinin en küçüğü {enBuyuk}");
        // Array.Reverse(dizi);

        // int enKucuk =dizi[0];
        // System.Console.WriteLine($"Dizinin en Büyüğü {enKucuk}");


        #endregion

        #region Soru7
        // 50 elemanlı rastgele değerlerden oluşan bir tam sayı dizisindeki tüm çift sayıları toplayan ve bu toplamı ekrana yazdıran bir program yazın. `foreach` döngüsü kullanarak bu işlemi gerçekleştirin.
        // int toplam = 0;
        // int[] dizi = new int[10];


        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(1, 11);
        //     if (dizi[i] % 2 == 0)
        //     {
        //         toplam += dizi[i];
        //     }
        // }

        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }


        // System.Console.WriteLine($"Çiftlerin toplamı {toplam}");

        #endregion

        #region Soru8
        //Klavyeden girilen bir sayıyı, 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde aratın.Eğer sayı dizide yoksa, diziyi sıralayın ve sayıyı dizinin doğru(olması gereken sıra) yerine ekleyin. Ekledikten sonra yeni diziyi ekrana yazdırın.


        // System.Console.WriteLine("Bir sayı giriniz: ");
        // int sayi = int.Parse(Console.ReadLine());

        // Random rnd = new Random();
        // int[] numbers = new int[10];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 15);
        //     System.Console.Write(numbers[i] + " ");
        // }

        // System.Console.WriteLine();

        // if (!numbers.Contains(sayi))
        // {
        //     Array.Sort(numbers);

        //     foreach (var number in numbers)
        //     {
        //         System.Console.Write(number + " ");

        //     }
        //     System.Console.WriteLine();


        //     int[] newNumbers = new int[numbers.Length + 1];
        //     Array.Copy(numbers, newNumbers, numbers.Length);
        //     newNumbers[newNumbers.Length - 1] = sayi;

        //     Array.Sort(newNumbers);


        //     foreach (var item in newNumbers)
        //     {
        //         System.Console.Write(item + " ");
        //     }

        // }

        // Random random = new Random();
        // int[] dizi = new int[10];
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = random.Next(10);
        // }
        // Console.WriteLine("Dizi: " + string.Join(", ", dizi));
        // Console.WriteLine("Bir sayı giriniz:");
        // int sayi = Convert.ToInt32(Console.ReadLine());
        // bool varMi = false;

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] == sayi)
        //     {
        //         varMi = true;
        //         break;
        //     }
        // }
        // if (varMi)
        // {
        //     Console.WriteLine("Sayı Dizide Bulundu..");
        // }
        // else
        // {
        //     Console.WriteLine("Sayı Dizide Bulunamadı,Ekliyoruz");
        //     Array.Sort(dizi);

        //     int[] yeniDizi = new int[dizi.Length + 1];
        //     bool eklendi = false;
        //     int j = 0; //Yeni dizinin index başlangıç değeri

        //     for (int i = 0; i < dizi.Length; i++)
        //     {
        //         if (!eklendi && sayi < dizi[i])
        //         {
        //             yeniDizi[i] = sayi;
        //             eklendi = true;
        //             j++;
        //         }
        //         yeniDizi[j] = dizi[i];
        //         j++;
        //     }

        //     if (!eklendi)
        //     {
        //         yeniDizi[j] = sayi;
        //     }
        //     Console.WriteLine("Yeni Dizi:");
        //     foreach (int i in dizi)
        //     {
        //         Console.WriteLine(i + ",");
        //     }
        // }



        #endregion

        #region Soru9
        //Verilen bir dizinin yalnızca pozitif sayılarını ters çeviren bir algoritma yazın.Diziyi tararken, sadece pozitif sayıların yerini değiştirmelisiniz, diğer elemanlar aynı kalmalı.

        // int[] dizi={-6,5,6,-9,-8,2,6,7,1,-50};

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i]>0)
        //     {
        //         dizi[i]=-dizi[i];
        //     }
        // }

        // //Array.Sort(dizi);
        // // Array.Reverse(dizi);
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        #endregion

        #region Soru10
        // 10 elemanlı bir dizi oluşturun ve bu dizinin elemanlarını bir başka diziye ters sırada kopyalayın. İlk dizideki sıralama değişmeyecek, sadece ikinci dizideki sıralama ters olacak.
        // Random rnd=new Random();
        // int[] dizi =new int[5];
        // int[] dizi2 = new int[5];
        // int sayaç=0;
        // for (int i = 0; i < 5; i++)
        // {
        //     dizi[i]=rnd.Next(1,79);


        // }

        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }
        // System.Console.WriteLine("--------------------------");
        // Array.Reverse(dizi);
        // Array.Copy(dizi,dizi2,dizi.Length);

        // foreach (var item in dizi2)
        // {
        //     System.Console.WriteLine(item);
        // }

        #endregion

        #region soru11
        // Klavyeden girilen bir cümlenin kelimelerini bir diziye aktarın. `while` döngüsü ile bu kelimeleri tersten ekrana yazdırın.

        //    System.Console.Write("Bir kelime giriniz => ");
        //    string girKelime = Console.ReadLine();

        //    char[] kelDizi = girKelime.ToCharArray();
        //         Array.Reverse(kelDizi);
        //      string çevDiz = new string(kelDizi);

        //      foreach (var item in çevDiz)
        //      {
        //         System.Console.Write(item);
        //      }


        #endregion

        #region Soru12
        // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en sık tekrar eden elemanı bulan ve kaç defa tekrarlandığını ekrana yazdıran bir program yazın.Bu işlemi bir `foreach` döngüsü ile gerçekleştirin.

        // int[] dizi = new int[20];
        // Random rnd = new Random();
        // int sayaç = 1;

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(1, 11);

        // }
        // System.Console.WriteLine("Random dizimiz");
        // System.Console.WriteLine("---------------------------------------------------");
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine($"{sayaç}. ==> {item}");
        //     sayaç++;
        // }

        // int fazlaTekEleman = dizi[0];
        // int tekrareleman = 0;

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     int x = dizi[i];
        //     int teksay = 0;

        //     foreach (var eleman in dizi)
        //     {
        //         if (eleman == x)
        //         {
        //             teksay++;
        //         }
        //     }

        //     if (teksay > tekrareleman)
        //     {
        //         fazlaTekEleman = x;
        //         tekrareleman = teksay;
        //     }
        // }

        // System.Console.WriteLine($"En çok tekrar eden eleman {fazlaTekEleman} = {tekrareleman} kadar tekrarlanıyor.");
        #endregion

        #region Soru13
        // Bir dizideki tek sayıları toplayan ve bu toplamın çift mi, tek mi olduğunu kontrol eden bir program yazın.Toplamla birlikte eğer toplam tek ise, "Toplam tek sayı" mesajı, çift ise "Toplam çift sayı" mesajı ekrana yazdırılmalı.

        // int[] dizi = {2,4,5,7};
        // int çiftop=0;
        // int tektop=0;

        // System.Console.WriteLine("Dizimizdeki sayılar  ");
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        //  for (int i = 0; i < dizi.Length; i++)
        //  {
        //     if(dizi[i] % 2 == 0)
        //     {
        //         çiftop+=dizi[i];

        //     }else
        //     {
        //         tektop+=dizi[i];
        //     }
        //  }

        //  System.Console.WriteLine($"Dizideki tek sayıların toplamı = {tektop} /// Dizideki çift sayıların toplamı = {çiftop} ");

        #endregion

        #region Soru14

        //20 elemanlı bir dizi oluşturun. Bu dizideki elemanların 3’e bölünebilenlerin toplamını bulan bir algoritma yazın.Sonucu ekrana yazdırırken her 5.elemandan sonra bir boşluk bırakın.
        // int sayaç=0;
        // int sayaç1=0;
        // int[] dizi = {6,3,9,6,7,8,4,1,12,15,4,5,7,9,4,67,8,65,20,27};
        // int[] üçdizesi = new int[dizi.Length];
        // int tektop=0;
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if(dizi[i] % 3 ==0)
        //     {
        //         tektop+=dizi[i];
        //         üçdizesi[sayaç]=dizi[i];

        //         sayaç++;   
        //     }          
        // }
        //     System.Console.WriteLine($"Toplam ={tektop}");

        //    for (int i = 0; i < dizi.Length; i++)
        //    {
        //     System.Console.WriteLine(dizi[i]);
        //     if ((i+1) % 5 ==0)
        //     {
        //         System.Console.WriteLine(" ");
        //     }

        //    }

        #endregion

        #region Soru15

        //Bir dizideki elemanları küçükten büyüğe sıralayan bir algoritma yazın.Ancak sıralama sırasında sadece tek sayılar sıralanmalı, çift sayılar yerlerinde kalmalıdır.

        // int[] dizi = { 2, 5, 9, 10, 7, 8, 5, };

        // int teksayıadet = 0;


        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] % 2 != 0)
        //     {
        //         teksayıadet++;
        //     }
        // }

        // int[] tekdizi = new int[teksayıadet];

        // int index = 0;

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] % 2 != 0)
        //     {
        //         tekdizi[index] = dizi[i];
        //         index++;
        //     }
        // }

        // Array.Sort(tekdizi);

        // int index2 = 0;
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] % 2 != 0)
        //     {
        //         dizi[i] = tekdizi[index2];
        //         index2++;
        //     }
        // }

        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        #endregion

        #region Soru16
        // 16. `do -while` döngüsü kullanarak, klavyeden girilen sayıları bir diziye ekleyin.Kullanıcı sıfır girdiğinde döngüden çıkın ve dizideki tüm sayılarla birlikte ortalamayı ekrana yazdırın.
        //         int input ;
        //         int sayaç=0;
        //         int[] dizi = new int[10];
        //         int top =0;

        //     do
        //     {

        //         System.Console.WriteLine("Bir sayı giriniz => ");
        //         input = int.Parse(Console.ReadLine());


        //         if( input !=0)
        //         {
        //             dizi[sayaç] = input;
        //             top +=input;

        //             sayaç++;
        //         }



        // } while (input != 0 && sayaç < dizi.Length);
        //     Array.Resize(ref dizi, dizi.Length);
        //     foreach (var item in dizi)
        //     {
        //         System.Console.WriteLine(item);
        //     }

        //   if(sayaç >0)
        //   {
        //         double ort =(double)top/sayaç;
        //         System.Console.WriteLine($"Sayılarımızın ortalaması = {ort}");
        //   }

        #endregion

        #region Soru17
        // Bir dizideki en büyük iki sayıyı bulan bir program yazın. Bu programı bir `for` döngüsü ile yazın, ancak aynı sayının iki defa en büyük olarak seçilmesine izin vermeyin.

        // int[] dizi = new int[20];
        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(1, 20);
        // }

        // int enBüyük = int.MinValue;
        // int ikiBüyük = int.MinValue;


        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }


        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] > enBüyük)
        //     {
        //         ikiBüyük = enBüyük;
        //         enBüyük = dizi[i];S
        //     }
        //     else if (dizi[i] > ikiBüyük && dizi[i] != enBüyük)
        //     {
        //         ikiBüyük = dizi[i];
        //     }
        // }

        // if (ikiBüyük == int.MinValue)
        // {
        //     System.Console.WriteLine("Dizide sadece bir farklı sayı var.");
        // }
        // else
        // {
        //     System.Console.WriteLine($"Dizinin en büyük sayısı => {enBüyük} ve bir sonraki en büyük sayı => {ikiBüyük}");
        // }

        #endregion
    }
}
