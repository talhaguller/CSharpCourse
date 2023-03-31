using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Ahmet");
            //dictionary.Add(2, "mehmet");
            //dictionary.Add(4, "deli");

            //Console.WriteLine(dictionary.Count);
            //for (int i = 0; i < dictionary.Count; i++)
            //{

            //}


            MyDictionary<int, string> dene = new MyDictionary<int, string>();
            dene.Add(1, "Ahmet");
            dene.Add(2, "mehmet");
            dene.Add(2, "mehmet");
            Console.WriteLine(dene.Length);

            for (int i = 0; i < dene.Length; i++)
            {
                Console.WriteLine("id: {0} - isim:{1} ", dene.GetKeys[i], dene.GetValues[i]);
            }


            Console.ReadLine();
        }
    }
}
