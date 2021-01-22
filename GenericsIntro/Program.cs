using System;
using System.Collections.Generic;


namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Yeliz");
            isimler.Add("Selma");

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler.Items[i]);
            }

            Console.WriteLine();


            List<string> liste = new List<string>();
            liste.Add("Ahmet");
            
            Console.WriteLine(liste[0]);
            
            
        }
    }
}
