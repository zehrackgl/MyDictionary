﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<TKey, TValue>
    {
        TKey[] keys ;
        TValue[] values;
        public Dictionary() //constructor 
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] temValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < temValues.Length; i++)
            {
                values[i] = temValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public TKey[] Keys
        {
            get { return keys; }
        }

        public TValue[] Values
        {
            get { return values; }
        }


    }
}
