﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
     class MyDictionary<T>
    {
       
        public MyDictionary()
        {   
            items= new T[0];
        }
        T[] items;
        public void Add(T data)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length+1] = data; 
        }

    }
}
