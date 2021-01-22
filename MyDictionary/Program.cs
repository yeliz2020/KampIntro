using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> employeeData = new MyDictionary<int, string>();
            employeeData.Add(1011, "Ali Oğuz");
            employeeData.Add(1012, "Hikmet İşler");
            employeeData.Add(1013, "Özgür Sönmez");
            employeeData.Add(1014, "Yeliz Yılmaz");
            employeeData.Add(1015, "Yasemin Şener");

            for (int i = 0; i < employeeData.Count; i++)
            {
                Console.WriteLine(employeeData.Keys[i] +" "+employeeData.Values[i]);
            }
            

        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        TKey[] tempKeys;
        TValue[] tempValues;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new TKey [tempKeys.Length + 1];
            values = new TValue[tempValues.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        

        public int Count
        {
            get { return keys.Length; }
            
        }
        public  TKey[] Keys
        {
            get { return keys; }
            
        }
        public TValue[] Values
        {
            get { return values; }

        }



    }
}
