using System;
using System.Collections.Generic;

namespace Genericsİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string>isimler = new MyList<string>();
            isimler.Add("Samet");
            Console.WriteLine(isimler.Length);


            isimler.Add("Hasan");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            //List<string> liste = new List<string>();
            //Console.WriteLine(liste.Count);

        }
    }
}
