using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bilgileri alma
        Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

        Console.Write("T.C. Kimlik Numarası:");
        string tcKimlikNo = Console.ReadLine();

        Console.Write("Ad:");
        string ad = Console.ReadLine();

        Console.Write("Soyad:");
        string soyad = Console.ReadLine();

        Console.Write("Telefon Numarası:");
        string telefon = Console.ReadLine();

        Console.Write("Yaş:");
        int yas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İlk Aldığınız Ürünün Fiyatı:");
        decimal urunFiyati1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("İkinci Aldığınız Ürünün Fiyatı:");
        decimal urunFiyati2 = Convert.ToDecimal(Console.ReadLine());

        // Toplam harcama ve puan hesaplama
        decimal toplamHarcama = urunFiyati1 + urunFiyati2;
        decimal kazanilanPuan = toplamHarcama * 0.1M; // %10 puan hesaplama

        // Çıktıların yazdırılması
        Console.WriteLine("\n-------------------------------------------------");
        Console.WriteLine($"{tcKimlikNo} T.C. numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
        Console.WriteLine($"{telefon} telefon numarasına bildirim mesajı gönderilmiştir.");
        Console.WriteLine($"{toplamHarcama} toplam harcama karşılığı kazanılan %10 Patika puan miktarı -> {kazanilanPuan} TL'dir.");
    }
}
