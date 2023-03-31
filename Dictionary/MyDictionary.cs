using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<T, A>
    {
        T[] Keys;
        A[] Values;
        int count;
        public MyDictionary()
        {
            Keys = new T[0];
            Values = new A[0];
            count = 0;
        }

        public void Add(T Key, A Value)
        {
            T[] tempArrayKeys = Keys;
            A[] tempArrayValues = Values;
            
            //Aynı Anahtar dan var mı kontrol
            count = tempArrayKeys.Length;
            for (int i = 0; i < count; i++)
            {
                if (tempArrayKeys[i].Equals(Key))
                {
                    Console.WriteLine("Aynı anahtar zaten koleksiyonda mevcut");
                }
            }




            //Key kısmı
            Keys = new T[Keys.Length + 1];
            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                Keys[i] = tempArrayKeys[i];
            }
            //son ekleneni ekleme yeri
            Keys[Keys.Length - 1] = Key;

            
            //Value Kısmı
            Values = new A[Values.Length + 1];
            for (int i = 0; i < tempArrayValues.Length; i++)
            {
                Values[i] = tempArrayValues[i];
            }
            //Son eklenen Value değeri
            Values[Values.Length - 1] = Value;

        }

        public int Length
        { 
            get{ return count; }
        }

        public T[] GetKeys 
        { 
            get { return Keys ; }  
        }

        public A[] GetValues { get {return Values ; } }
    }
}
