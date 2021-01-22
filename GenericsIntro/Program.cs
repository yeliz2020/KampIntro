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
            
            Console.WriteLine(isimler.IndexofArray[0]);


            List<string> liste = new List<string>();
            liste.Add("Ahmet");
            
            Console.WriteLine(liste[0]);
            
            
        }
    }
}
