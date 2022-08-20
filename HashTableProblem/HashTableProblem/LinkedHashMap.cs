using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedHashMap<K, V> where K : IComparable               //Created class name as LinkedHashMap and passing Key and Value,
                                                                         //IComparable means it Compare the value and give it in sorting manner.
    {
        private readonly int NumBuckets;
        readonly List<LinkedList<K, V>> BucketList;

        public LinkedHashMap(int NumBuckets)                             // 1.2 Creating Constructor,Creating Five Identical Position in Bucket list
        {
            //Linked list added to array locatation
            //NumBuckets is Array size
            this.NumBuckets = NumBuckets;
            BucketList = new List<LinkedList<K, V>>(NumBuckets);

            for (int i = 0; i < this.NumBuckets; i++)
                BucketList.Add(null);                                    // 1.2 in Bucket list Intializing the 5 Identical position with null value in it.
        }

        public V Get(K key)                                             // 5.1 V is Return Type and passing the Key (Key="to)
        {
            //Check value of particular key(word)
            int index = GetBucketIndex(key);                            //5.2 Need to find the index for the Key
            //check  particular linked list at the array position
            LinkedList<K, V> myLinkedList = BucketList[index];          //5.6 In Bucket list stroing 3 as index value
            if (myLinkedList == null)                                   //5.7 Intialaly We dont have any link list here that is why it is null
                return default;                                         //5.8 Default value will be 1 5.9 since linklist is null
            //Check particular key mymapnode in the linked list at array position
            MyMapNode<K, V> myMapNode = myLinkedList.Search(key);
            return (myMapNode == null) ? default : myMapNode.value;
        }

        private int GetBucketIndex(K key)                    //6.3      //5.3 finding the index for the Key in Bucket
        {
            //Return the absolute value because hashCode contain negative value sometime
            int hashCode = Math.Abs(key.GetHashCode());      //6.4      //5.4 Return the "Abs" absolute value because hashCode contain negative value sometime
            //To get the hashcode within range
            int index = hashCode % NumBuckets;              //6.5
            return index;                                   //6.6       //5.5 In This case index is 3
        }

        public void Add(K key, V value)                                 //6.1 For Adding the particular value and key at linked list 
        {
            //Adding the particular value and key at linked list 
            int index = this.GetBucketIndex(key);                       //6.2 Same index we are going to get from above method
            LinkedList<K, V> myLinkedList = BucketList[index];          //6.7 From that index we are intializing link list
            ///Check linked list is null or not
            if (myLinkedList == null)                                   //6.8 yes Linked list is null and it will get if statement
            {
                myLinkedList = new LinkedList<K, V>();                  //6.9 now it is going to intialize at a index in linked list class 6.10
                BucketList[index] = myLinkedList;                       //6.11 Intailised linked list by Storing Bucketlist of 3 as Head and tail
                                                                        //as null as per 6.10 
            }
            //Check myMapNode is present or not if not then create new else add value in previous mymapnode
            MyMapNode<K, V> myMapNode = myLinkedList.Search(key);       //6.12 Searching for the key "Key = To" in 6.13 in Linked list class
            if (myMapNode == null)                                      //6.15 I dont have any node inside the link list since Head and tail is null
            {
                myMapNode = new MyMapNode<K, V>(key, value);            //6.16 Node will be intialized now key will be 3 and value is "to"
                myLinkedList.Append(myMapNode);                         //6.17 Key and value intialized in append method in Mymaponode 6.18
            }                                                           //6.19 in Linked List class checking node is present or not
            else myMapNode.value = value;
        }


    }
}