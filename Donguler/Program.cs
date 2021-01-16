using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yaz Gel Kampı";
            string kurs2 = "Program Baş Tem Kurs";
            string kurs3 = "Java";

            // array
            string[] kurslar = new string[] { "Yaz Gel Kampı", "Program Baş Tem Kurs", "Java","Python", "C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
