using System;

namespace Homework3MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,String> ProductAndPrice = new MyDictionary<string,String>();
            ProductAndPrice.Add("DELL VOSTRO 6878 PC", "1000 $");
            ProductAndPrice.Add("APPLE MACBOOK", "1326$");
            ProductAndPrice.Add("SAMSUNG GALAXY NOTE 10", "740$");
            ProductAndPrice.Add("HUAWEI MATE 10 PRO", "236$");
            ProductAndPrice.Add("SAMSUNG 970 Evo Plus 500GB SSD ", "86$");

            //NOT:T2 yani Price kısmını int tipinde yapabilirdik. Ancak $ işaretini koymak için string  yaptık.
        }
    }




class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;
      
        //constructor işlemi (ctor + TAB+TAB)
        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }

        public void Add(T1 key,T2 value)
        {
            T1[] tempKeys = keys;     //elemanlaın kaybolması engellendi
            T2[] tempValues = values;

            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }
           
        
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


        }



    }


















}


