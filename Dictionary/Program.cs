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

            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Ahmet");
            dictionary.Add(2, "mehmet");
            dictionary.Add(2, "mehmet");
            Console.WriteLine(dictionary.Length);

            for (int i = 0; i < dictionary.Length; i++)
            {
                Console.WriteLine("id: {0} - isim:{1} ", dictionary.GetKeys[i], dictionary.GetValues[i]);
            }


            Console.ReadLine();
        }
    }
}
