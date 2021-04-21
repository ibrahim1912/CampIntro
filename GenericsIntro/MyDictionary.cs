using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key,V value)
        {
            K[] tempArray1 = keys;
            V[] tempArray2 = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                values[i] = tempArray2[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Length
        {
            get { return keys.Length; }
        }
        public K[] Keys; V[] Values
        {
            get { return keys; return values; }
            
        }

    }
}
