using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {

            // sınıf ilk oluşturulduğunda çalışacak kod.
            // ilk çalıştığında dizi elemanları 0 olarak belirliyoruz.
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            // dizideki elemanları geçici bir diziye atıyoruz.
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;
            // dizi elaman sayısını bir arttırıyoruz. Yni 1 elemanlı yeni bir dizi oluşturuyoruz.
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];

            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public TValue[] Values
        {
            get { return values; }
        }
    }
}
