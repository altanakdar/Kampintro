using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);

                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------");
            }
            Console.WriteLine("-------Metodlar--------");
            SepetManager sepetManagar = new SepetManager();
            sepetManagar.Ekle(urun1);
            sepetManagar.Ekle(urun2);

            sepetManagar.Ekle2("Armut","YeşilArmut", 12,10);
            sepetManagar.Ekle2("Elme","YeşilElma", 12,10);
            sepetManagar.Ekle2("karpuz","diyarbakırkarpuzu", 12,10);
        }
    }
}
