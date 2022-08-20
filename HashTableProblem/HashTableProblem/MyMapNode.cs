﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    //To create key value pair hashtable
    public class MyMapNode<K, V>
    {
        public K key;
        public V value;
        public MyMapNode<K, V> next;

        public MyMapNode(K key, V value)            //6.18 Key and value is intialised 
        {
            this.key = key;
            this.value = value;
            next = null;                            //6.19 Next will be null
        }


    }
}