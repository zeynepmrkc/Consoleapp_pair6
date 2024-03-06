

static void soru1()
{
    Console.WriteLine("Sipariş numarası giriniz:");
    int sip_no = Convert.ToInt32(Console.ReadLine());


    switch (sip_no)
    {
        case 1:
            Console.WriteLine("Telefon");
            break;
        case 2:
            Console.WriteLine("Bilgisayar");
            break;
        case 3:
            Console.WriteLine("Kullaklık");
            break;
        default:
            Console.WriteLine("Geçersiz sipariş numarası");
            break;
    }
    Console.ReadLine();
}
static void soru2()
{
    int urun_sayisi = Convert.ToInt32(Console.ReadLine());

    double toplam = 0;

    for (int i = 1; i <= urun_sayisi; i++)
    {
        Console.WriteLine($"Ürün {i} için fiyatı girin:");
        double fiyat = Convert.ToDouble(Console.ReadLine());
        toplam += fiyat;
    }

    Console.WriteLine($"Toplam alışveriş tutarı: {toplam} TL");

    Console.ReadLine();
}
static void soru3()
{ 
int sayi = 1;
while (sayi != 0)
{
    Console.WriteLine("bir sayı girin..:");
    sayi = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Bitti");
Console.ReadLine();
}
static void soru4()
{ 
int i = 1;
Random rdn = new Random();
int rastgele = rdn.Next(0, 10);
while (true)
{
    Console.Write("Sayı Giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == rastgele)
    {
        break;
    }
    i++;
}
Console.WriteLine(i + ". tahmininizde sayıyı buldunuz.");
Console.ReadKey();
}
static void soru5()
{
    Console.WriteLine("Bir sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    int toplam = 0;
    for (int i = 1; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            toplam += i;
        }
    }

    if (toplam == sayi)
    {
        Console.WriteLine(sayi + " mükemmel bir sayıdır.");
    }
    else
    {
        Console.WriteLine(sayi + " mükemmel bir sayı değildir.");
    }

}
static void soru6()
{
   /* ToLower Metod:  küçük harfe dönüştürmek için kullanılmaktadır.*/
    string isim = "ZEYNEP";

    string metin = isim.ToLower();

    Console.WriteLine(metin);
    /*Compare metod: büyük küçük harfe duyarlı veya duyarsız olarak yapmak için compare metoduna 3. parametre eklenir  eğer true ise:küçük-büyük harfe duyarsız olacaktır..*/
    string degisken1, degisken2;

    degisken1 = "Azkod";
    degisken2 = "Azkod";

    int sonuc = String.Compare(degisken1, degisken2);

    Console.WriteLine(sonuc);
    Console.ReadLine();
    /*Concat metodu: string ifadeleri  birleştirmek için kullanılan bir metod.*/
    string ifade1 = "İstanbul ";
    string ifade2 = "Kodluyor";

    string s=String.Concat(ifade1, ifade2);

    Console.WriteLine("Sonuc : " + sonuc);
    Console.ReadLine();



}
static void soru7()
{
    Console.WriteLine("Öğrenci sayısını girin ");
    int ogr_say = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= ogr_say; i++)
    {
        Console.WriteLine("Öğrenc" + i + " için bilgileri giriniz");

        Console.Write("Adı soyadı  ");
        string ad_soyad = Console.ReadLine();



        Console.Write("1. sınav notu ");
        double s1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. sınav notu ");
        double s2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("3.sınav notu ");
        double s3 = Convert.ToDouble(Console.ReadLine());

        double ortalama = (s1 + s2 + s3) / 3;
        Console.WriteLine("Not ortalaması" + ortalama);
    }
}


