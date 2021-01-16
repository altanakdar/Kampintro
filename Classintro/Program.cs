using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Altan";
            int yas = 36;
            Kurs kurs1;

            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C#";
            Kurs1.Egitmen = "altan";
            Kurs1.IzlenmeOranı = 68;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "java";
            Kurs2.Egitmen = "osman";
            Kurs2.IzlenmeOranı = 68;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "python";
            Kurs3.Egitmen = "ali";
            Kurs3.IzlenmeOranı = 68;

            //Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.Egitmen);

            Kurs[] Kurslar = new Kurs[] { Kurs1, Kurs2, Kurs3 };
            foreach (var Kurs in Kurslar) 
            {
                Console.WriteLine(Kurs.KursAdi + " : " + Kurs.Egitmen);
            }
           
            
            
            
            Console.WriteLine("Hello World!");
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public  int IzlenmeOranı { get; set; }
    }
}

