using System;
using System.Data;


namespace Calisma38_SampleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable definition
            double dizel = 7.2, benzin = 8.1, lpg = 3.25;
            double dizelTank = 1000, benzinTank = 1000, lpgTank = 1000;
            double satisMiktari = 0;
            char anamenüSecim = '0', altmemüSecim = '0', akaryakitFiyatGüncelle = '0', akaryakitSatisTipi = '0';

        // Creating a main menü
        MENU:
            Console.WriteLine("Akaryakİt Satis Takip");
            Console.WriteLine(".....................");
            Console.WriteLine("1->Birim fiyat goster");
            Console.WriteLine("2->Birim fiyat guncelle");
            Console.WriteLine("3->Akaryakit satis yap");
            Console.WriteLine("4->Depo durum goster");
            Console.WriteLine("5->Toplam satis goster");
            Console.WriteLine("6->Cikis");

            Console.Write("Seciminizi Yapiniz [1, 2, 3, 4, 5, 6] :");

            anamenüSecim = Convert.ToChar(Console.ReadLine());

            if (anamenüSecim == '1')
            {
                Console.Clear();
                Console.WriteLine(">>Seciminiz : 1");
                Console.WriteLine(".....Birim fiyat listesi....");
                Console.WriteLine("Dizel (D) {0} TL/LITRE", dizel);
                Console.WriteLine("Benzin (B) {0} TL/LITRE", benzin);
                Console.WriteLine("Lpg (L) {0} TL/LITRE", lpg);

            ALTMENU:
                Console.Write("Seciminizi yapiniz [1.Ana Menüye Dön  2.Programı Kapat] :");

                altmemüSecim = Convert.ToChar(Console.ReadLine());

                if (altmemüSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmemüSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1 ve 2 Secimleri Disinda Yanlis Secim Yaptiniz!");
                    goto ALTMENU;
                }



            }
            else if (anamenüSecim == '2')
            {
                Console.Clear();
                Console.WriteLine(">>Seciminiz : 2");
                Console.WriteLine(".....Birim fiyatlar guncelleme....");

            AKARYAKITTPI:
                Console.WriteLine("Akaryakıt Tipini Seciniz [D,B,L]");
                akaryakitFiyatGüncelle = Convert.ToChar(Console.ReadLine());

                if (akaryakitFiyatGüncelle == 'D' || akaryakitFiyatGüncelle == 'd')
                {
                    Console.WriteLine("Dizel (D) {0} TL/LITRE", dizel);
                    Console.Write("Dizel yakıt içiğn yeni fiyat giriniz :");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("Dizel (D) {0} TL/LITRE", dizel);
                }
                else if (akaryakitFiyatGüncelle == 'B' || akaryakitFiyatGüncelle == 'b')
                {
                    Console.WriteLine("Benzin (B) {0} TL/LITRE", benzin);
                    Console.Write("Benzin yakıt içiğn yeni fiyat giriniz :");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("Benzin (B) {0} TL/LITRE", benzin);
                }
                else if (akaryakitFiyatGüncelle == 'L' || akaryakitFiyatGüncelle == 'l')
                {
                    Console.WriteLine("Lpg (L) {0} TL/LITRE", lpg);
                    Console.Write("Lpg yakıt içiğn yeni fiyat giriniz :");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("Lpg (L) {0} TL/LITRE", lpg);
                }
                else
                {
                    Console.WriteLine("D,B,L Dışında Yanlış Seçim Yaptınız!");
                    goto AKARYAKITTPI;
                }
            ALTMENU:
                Console.Write("Seciminizi yapiniz [1.Ana Menüye Dön  2.Programı Kapat] :");

                altmemüSecim = Convert.ToChar(Console.ReadLine());

                if (altmemüSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmemüSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1 ve 2 Secimleri Disinda Yanlis Secim Yaptiniz!");
                    goto ALTMENU;
                }



            }
            else if (anamenüSecim == '3')
            {
                Console.Clear();
                Console.WriteLine(">>Seciminiz : 3");
                Console.WriteLine(".....Akaryakıt Satış İşlemleri....");

            AKARYAKITSATISI:
                Console.WriteLine("Akaryakıt Tipini Seciniz [D,B,L]");
                akaryakitSatisTipi = Convert.ToChar(Console.ReadLine());
                if (akaryakitSatisTipi == 'D' || akaryakitSatisTipi == 'd')
                {
                    if (dizel == 0)
                    {
                        Console.WriteLine("Depoda Hiç Dizel Yakıt Kalmadı!");
                        goto MENU;
                    }
                    else
                    {
                        Console.Write("Ne kadar yakıt alacaksınız :");
                        satisMiktari = Convert.ToDouble(Console.ReadLine());
                        if (satisMiktari > dizelTank)
                        {
                            Console.WriteLine("Dizel yakıt tankında  {0} Litre yakıt vardır! Satış yapılamadı.", dizelTank);
                            goto MENU;
                        }
                        else if (satisMiktari <= dizelTank)
                        {
                            dizelTank = dizelTank - satisMiktari;
                            Console.WriteLine("Satış işlemi başarı ile tamamlandı.");
                            Console.WriteLine("Yakıt tankında {0} Litre dizel yakıt kaldı. ", dizelTank);
                        }
                    }

                }
                else if (akaryakitSatisTipi == 'B' || akaryakitSatisTipi == 'b')
                {
                    if (benzin == 0)
                    {
                        Console.WriteLine("Depoda Hiç Benzin Yakıt Kalmadı!");
                        goto MENU;
                    }
                    else
                    {
                        Console.Write("Ne kadar yakıt alacaksınız :");
                        satisMiktari = Convert.ToDouble(Console.ReadLine());
                        if (satisMiktari > benzinTank)
                        {
                            Console.WriteLine("Benzin yakıt tankında {0} Litre yakıt vardır! Satış yaılamadı.", benzinTank);
                            goto MENU;
                        }
                        else if (satisMiktari <= benzinTank)
                        {
                            benzinTank = benzinTank - satisMiktari;
                            Console.WriteLine("Satış işlemi başarı ile tamamlandı.");
                            Console.WriteLine("Yakıt tankında {0} Litre Benzin yakıtı kaldı. ", benzinTank);
                        }
                    }
                }
                else if (akaryakitSatisTipi == 'L' || akaryakitSatisTipi == 'l')
                {
                    if (lpg == 0)
                    {
                        Console.WriteLine("Depoda Hiç Lpg Yakıt Kalmadı!");
                        goto MENU;
                    }
                    else
                    {
                        Console.Write("Ne kadar yakıt alacaksınız :");
                        satisMiktari = Convert.ToDouble(Console.ReadLine());
                        if (satisMiktari > lpgTank)
                        {
                            Console.WriteLine("Lpg yakıt tankında {0} Litre  yakıt vardır! Satış yaılamadı.", lpgTank);
                            goto MENU;
                        }
                        else if (satisMiktari <= lpgTank)
                        {
                            lpgTank = lpgTank - satisMiktari;
                            Console.WriteLine("Satış işlemi başarı ile tamamlandı.");
                            Console.WriteLine("Yakıt tankında {0} Litre 'Lpg' yakıtı kaldı. ", lpgTank);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("D,B,L Seçimi dışında işlem yaptınız işleminiz gerçekleştirilemedi.");
                    goto AKARYAKITSATISI;
                }

            ALTMENU:
                Console.Write("Seciminizi yapiniz [1.Ana Menüye Dön  2.Programı Kapat] :");

                altmemüSecim = Convert.ToChar(Console.ReadLine());

                if (altmemüSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmemüSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1 ve 2 Secimleri Disinda Yanlis Secim Yaptiniz!");
                    goto ALTMENU;
                }



            }
            else if (anamenüSecim == '4')
            {
                Console.Clear();
                Console.WriteLine("...Depo Doluluk Durumu...");
                Console.WriteLine("Dizel yakıt tankı %{0} doludur", (dizelTank / 10));
                Console.WriteLine("Benzin yakıt tankı %{0} doludur", (benzinTank / 10));
                Console.WriteLine("Lpg yakıt tankı %{0} doludur", (lpgTank / 10));

            ALTMENU:
                Console.Write("Seciminizi yapiniz [1.Ana Menüye Dön  2.Programı Kapat] :");

                altmemüSecim = Convert.ToChar(Console.ReadLine());

                if (altmemüSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmemüSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1 ve 2 Secimleri Disinda Yanlis Secim Yaptiniz!");
                    goto ALTMENU;
                }

            }
            else if (anamenüSecim == '5')
            {
                Console.Clear();
                Console.WriteLine("...Yakıt Satış Durumu...");
                Console.WriteLine("Satılan Toplam Dizel Yakıt  {0}Litre", (1000 - dizelTank));
                Console.WriteLine(" Dizel Yakıt Tutarı : {0}", (1000 - dizelTank) * dizel);
                Console.WriteLine("Satılan Toplam Benzin Yakıt  {0}Litre", (1000 - benzinTank));
                Console.WriteLine("Dizel Yakıt Tutarı : {0}", (1000 - benzinTank) * benzin);
                Console.WriteLine("Satılan Toplam Dizel Yakıt  {0}Litre", (1000 - lpgTank));
                Console.WriteLine("Lpg Yakıt Tutarı : {0}", (1000 - lpgTank) * lpg);
                Console.WriteLine();
                Console.WriteLine("Satılan toplam yakıt tutarı : {0}", ((1000 - dizelTank) * dizel + (1000 - benzinTank) * benzin + (1000 - lpgTank) * lpg));


            ALTMENU:
                Console.Write("Seciminizi yapiniz [1.Ana Menüye Dön  2.Programı Kapat] :");

                altmemüSecim = Convert.ToChar(Console.ReadLine());

                if (altmemüSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmemüSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1 ve 2 Secimleri Disinda Yanlis Secim Yaptiniz!");
                    goto ALTMENU;
                }

            }

            Console.ReadKey();
        }

    }
}

