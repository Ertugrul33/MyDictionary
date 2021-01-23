using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci1 = new Dictionary<int, string>();
            ogrenci1.Add(101, "Engin Demiroğ");
            ogrenci1.Add(102, "Ertuğrul EŞOL");
            ogrenci1.Add(103, "Samet KARASU");
            Console.WriteLine(ogrenci1.Count);

            MyDictionary<int, string> ogrenci2 = new MyDictionary<int, string>();
            ogrenci2.Add(101, "Engin Demiroğ");
            ogrenci2.Add(102, "Ertuğrul EŞOL");
            ogrenci2.Add(103, "Samet KARASU");
            Console.WriteLine(ogrenci2.Count);
        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] _keyarray;
        TKey[] _keytempArray;

        TValue[] _valuearray;
        TValue[] _valuetempArray;

        public MyDictionary()
        {
            _keyarray = new TKey[0];
            _valuearray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _keytempArray = _keyarray;
            _keyarray = new TKey[_keyarray.Length + 1];

            _valuetempArray = _valuearray;
            _valuearray = new TValue[_valuearray.Length + 1];

            for (int i = 0; i < _keytempArray.Length; i++)
            {
                _keyarray[i] = _keytempArray[i]; 
            }
            _keyarray[_keyarray.Length - 1] = key;

            for (int i = 0; i < _valuetempArray.Length; i++)
            {
                _valuearray[i] = _valuetempArray[i];
            }
            _valuearray[_valuearray.Length - 1] = value;
        }

        public int Count
        {
            get { return _keyarray.Length; } //Sadece key'in kaç elemanlı olduğunu göstermemiz yeterli.
        }
    }
}
