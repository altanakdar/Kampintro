using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici";
            string kurs2 = "Programlamaya başlama";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım geliştirici", "Programlamaya başlama", "Java","Python","C#" };
            
            
            for (int i = 0; i<kurslar.Length; i++)
            
            
            
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("Sayfa sonu");
        }
    }
}
