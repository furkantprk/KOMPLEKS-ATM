using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {   int islem;
            int yatirilacakTutar; 
            int cekilecekTutar;
            float bakiye=1239.41f;
            int sifre = 1234;
            int hak = 3;
            Console.WriteLine("Şifrenizi giriniz.");
            int girilen = Convert.ToInt32(Console.ReadLine());
            if (girilen!=sifre)
            {
                hak--;
                if (hak == 2)
                {
                    Console.WriteLine("Yanlış şifre girdiniz. Tekrar giriniz.");
                    girilen=Convert.ToInt32(Console.ReadLine());
                    hak--;
                }
                if (hak == 1)
                {
                    Console.WriteLine("Yanlış şifre girdiniz. Tekrar giriniz.");
                    girilen = Convert.ToInt32(Console.ReadLine());
                    hak--;
                }
                if(hak==0 && girilen!=sifre)
                { Console.WriteLine("KARTINIZ BLOKE OLMUŞTUR. YETKİLİLER İLE İLETİŞİME GEÇİNİZ."); }
            }

            if (girilen==sifre)
            {
                Console.WriteLine("Hangi işlemi yapmak istersiniz?");
                Console.WriteLine("1-Para Yatırma");
                Console.WriteLine("2-Para Çekme");
                Console.WriteLine("3-Bakiye Sorgulama");
                Console.WriteLine("4-Fatura ödeme");
                Console.WriteLine("5-Çıkış");
                islem = Convert.ToInt32(Console.ReadLine());
                while (islem!=5)
                {
                   
                    switch (islem)
                    {
                        case 1:
                            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                            yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                            if (yatirilacakTutar % 10 == 0)
                            {
                                bakiye = bakiye + yatirilacakTutar;
                                Console.WriteLine("Yeni bakiyeniz= " + bakiye);
                                Console.WriteLine("Para yatırma başarılı. Ana menüye dönmek için 0'ı tuşlayınız.");
                                islem = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Sadece 10 ve katları şeklinde para yatırabilirsiniz.");
                                Console.WriteLine("Ana menüye dönmek için 0'ı tuşlayınız.");
                                islem = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                        case 2:
                            Console.WriteLine("Çekmek istediğiniz tutarı giriniz.");
                            cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                            bakiye = bakiye - cekilecekTutar;
                            Console.WriteLine("Yeni bakiyeniz= " + bakiye);
                            Console.WriteLine("Para çekildi. Yeni bakiyeniz= " + bakiye);
                            Console.WriteLine("Para yatırma başarılı. Ana menüye dönmek için 0'ı tuşlayınız.");
                            islem = Convert.ToInt32(Console.ReadLine()); break;
                        case 3:
                            Console.WriteLine("Bakiyeniz= " + bakiye);
                            Console.WriteLine("Ana menüye dönmek için 0'ı tuşlayınız.");
                            islem = Convert.ToInt32(Console.ReadLine()); break;
                        case 4:
                            Console.WriteLine("Ne faturası ödemek istersiniz");
                            Console.WriteLine("1-Elektrik");
                            Console.WriteLine("2-Su");
                            Console.WriteLine("3-Doğal gaz");
                            int fatura = Convert.ToInt32(Console.ReadLine());
                            switch (fatura)
                            {
                                case 1:
                                    Console.WriteLine("Elektrik faturası tutarı olan 71,41 Türk lirası hesabınızdan alınmıştır.");
                                    bakiye = bakiye - 71.41f;
                                    Console.WriteLine("Fatura ödeme başarılı. Ana menüye dönmek için 0'ı tuşlayınız.");
                                    islem = Convert.ToInt32(Console.ReadLine()); break;
                                case 2:
                                    Console.WriteLine("Su faturası tutarı olan 71,41 Türk lirası hesabınızdan alınmıştır.");
                                    bakiye = bakiye - 71.41f;
                                    Console.WriteLine("Fatura ödeme başarılı. Ana menüye dönmek için 0'ı tuşlayınız.");
                                    islem = Convert.ToInt32(Console.ReadLine()); break;
                                case 3:
                                    Console.WriteLine("Doğal gaz faturası tutarı olan 71,41 Türk lirası hesabınızdan alınmıştır.");
                                    bakiye = bakiye - 71.41f;
                                    Console.WriteLine("Fatura ödeme başarılı. Ana menüye dönmek için 0'ı tuşlayınız.");
                                    islem = Convert.ToInt32(Console.ReadLine()); break;
                                default: Console.WriteLine("Yanlış tuşladınız."); break;
                            }break;
                     
                        default: Console.WriteLine("Yanlış tuşlama yaptınız."); break;

                    }
                    while (islem == 0)
                    {
                        Console.WriteLine("Hangi işlemi yapmak istersiniz?");
                        Console.WriteLine("1-Para Yatırma");
                        Console.WriteLine("2-Para Çekme");
                        Console.WriteLine("3-Bakiye Sorgulama");
                        Console.WriteLine("4-Fatura ödeme");
                        Console.WriteLine("5-Çıkış");
                        islem = Convert.ToInt32(Console.ReadLine());
                        while (islem == 5)
                        {
                            Console.WriteLine("ATM'den çıkış yaptınız. Tekrar bekleriz."); break;
                        }
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
