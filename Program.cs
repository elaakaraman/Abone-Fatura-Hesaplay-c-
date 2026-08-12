using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== ABONE FATURA HESAPLAYICI =====");

        Console.Write("Abone No: ");
        string aboneNo = Console.ReadLine();

        Console.Write("Abone Adı: ");
        string aboneAdi = Console.ReadLine();

        Console.Write("Kota (GB): ");
        double kota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kullanılan İnternet (GB): ");
        double kullanim = Convert.ToDouble(Console.ReadLine());

        Console.Write("Aylık Ücret (TL): ");
        double aylikUcret = Convert.ToDouble(Console.ReadLine());

        double asim = 0;
        double asimUcreti = 0;

        if (kullanim > kota)
        {
            asim = kullanim - kota;
            asimUcreti = asim * 5;
        }

        double toplamFatura = aylikUcret + asimUcreti;

        Console.WriteLine("\n===== FATURA BİLGİLERİ =====");
        Console.WriteLine("Abone No: " + aboneNo);
        Console.WriteLine("Abone Adı: " + aboneAdi);
        Console.WriteLine("Kota: " + kota + " GB");
        Console.WriteLine("Kullanım: " + kullanim + " GB");
        Console.WriteLine("Kota Aşımı: " + asim + " GB");
        Console.WriteLine("Aşım Ücreti: " + asimUcreti + " TL");
        Console.WriteLine("Toplam Fatura: " + toplamFatura + " TL");
    }
}
Console.WriteLine("Program çalışıyor!");
