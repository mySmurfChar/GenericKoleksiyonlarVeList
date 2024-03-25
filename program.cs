using System.IO;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Program program = new Program();
          program.Listeler();
        }


private void Listeler()
{
    List<int> sayiListesi= new List<int>();

    sayiListesi.Add(1);
    sayiListesi.Add(2);
    sayiListesi.Add(3);
    sayiListesi.Add(4);
    sayiListesi.Add(5);


    List<string> renkler= new List<string>();

    renkler.Add("Kırmızı");
    renkler.Add("Mavi");
    renkler.Add("Yeşil");
    renkler.Add("Sarı");


    //Count
    Console.WriteLine("Count sayiListesi: " + sayiListesi.Count());
    Console.WriteLine("Count renkler"+renkler.Count());



    //foreach ve List.ForEach ile liste elemanlarına erişim
    //List.ForEach(variable=>Console.WriteLine(variable))
    foreach (var sayi in sayiListesi)
    {
        Console.WriteLine("foreach sayi: "+sayi);
    }
    foreach(var renk in renkler)
    {
        Console.WriteLine("foreach renk: " + renk);
    }

    sayiListesi.ForEach(sayi => Console.WriteLine("List.ForEach sayi: " + sayi));
    renkler.ForEach(renk=> Console.WriteLine("List.ForEach renk: " + renk));

    sayiListesi.Remove(4);
    renkler.Remove("Yeşil");

    sayiListesi.ForEach(sayi => Console.WriteLine("List.ForEach sayi: " + sayi));
    renkler.ForEach(renk => Console.WriteLine("List.ForEach renk: " + renk));


    //Listeden eleman çıkartma
    sayiListesi.RemoveAt(0);
    renkler.RemoveAt(1);

    sayiListesi.ForEach(sayi => Console.WriteLine("List.ForEach sayi: " + sayi));
    renkler.ForEach(renk => Console.WriteLine("List.ForEach renk: " + renk));

    Console.WriteLine();


    //Liste içerisinde arama
    Console.WriteLine("if contains sayi 2");
    if (sayiListesi.Contains(2))
    {
        Console.WriteLine("2 sayı listesinde bulundu");

    }
    else
    {
        Console.WriteLine("2 bulunamadı");
    }



    //Eleman ile İndex'e erişim
    Console.WriteLine(sayiListesi.BinarySearch(5));
    Console.WriteLine(renkler.BinarySearch("Sarı"));


    //Diziyi List'e çevirme
    string[] hayvanlar = { "at", "köpek", "kuş", "zebra" };
    List<string> hayvanListesi =new List<string>(hayvanlar);


    //Listeyi temizlemek
    hayvanListesi.Clear();


    //Liste içerisinde nesne tutmak
    //*//
    //kullanıcılar listesi oluşturma
    List<KullanicilarListeClass> kullanicilar = new List<KullanicilarListeClass>();
    //Şimdi bu listeye eleman atıyor olmamız lazım bunun için de kullanıcı sınıfının
    //nesnelerine ihtiyacımız var
    //nesnelerini oluşturalım

    KullanicilarListeClass kullanici1 = new KullanicilarListeClass();
    kullanici1.Isim = "Zikriye";
    kullanici1.Soyisim = "Ürkmez";
    kullanici1.Yas = "26";

    KullanicilarListeClass kullanici2 = new KullanicilarListeClass();
    kullanici2.Isim = "Özcan";
    kullanici2.Soyisim = "Çalışkan";
    kullanici2.Yas = "22";

    //Oluşturduğumuz nesneleri kullanicilar listesine atamış olduk
    kullanicilar.Add(kullanici1);
    kullanicilar.Add(kullanici2);


    //Yeni liste oluşturup eleman ekleyelim
    List<KullanicilarListeClass> yeniListe = new List<KullanicilarListeClass>();

    yeniListe.Add(new KullanicilarListeClass
    {
        Isim = "Deniz",
        Soyisim="Söke",
        Yas="24"
    });
    
    //Yukarıda yazdığımız elemanları foreach ile yazdıralım
    foreach(var kullanici in kullanicilar)
    {
        Console.WriteLine("Kullanıcı adı: "+ kullanici.Isim);
        Console.WriteLine("Kullanıcı soyadı: "+kullanici.Soyisim);
        Console.WriteLine("Kullanıcı yaşı: "+kullanici.Yas);
    }


}
}
public class KullanicilarListeClass
{
    //Encapsulation yapacağım
    //Yani getter ve setter'larını yazacağım
    //Bu kısma detaylı değeneceğiz



    private string isim; 
    private string soyisim;
    private string yas;

    //Alttaki 3 kod bir kısayol ile oluşturulmuştur
    //getter ve setter oluşturmanın VS Community'deki kısayolu
    //Ctrl+R , Ctrl+E , Enter


    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public string Yas { get => yas; set => yas = value; }

    //Yukarıdaki yapı bize get'i dışarıya kapatmak
    //Set'i dışarıya kapatmak
    //Get olacaksa geti manipüle ederek yollamak gibi 
    //Faydalar sağlıyor



}
