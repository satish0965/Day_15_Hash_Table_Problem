using DataStructure;
using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary
            ///UC1:Find the frequency of word in sentence
            /// </summary>
            Console.WriteLine("Welcome to Data Structure Problem Using Generics");
            LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);  ///1 Creating Linklist Hashmap 
            string sentence = "to be or not to be";                                        ///2
            string[] words = sentence.ToLower().Split(" ");                                ///3 Created the array and Splitting The Sentances, 
            foreach (string word in words)                                                 ///4 To Take Every Word In That Sentaces
            {
                int value = LinkedHashMap.Get(word);                                       ///5 To determine its value We are getting in to 5.1
                if (value == default)                                                      //5.9 Storing Value as 1
                {
                    value = 1;
                }
                else value += 1;                                                           ///6 We get a identity but not intialize the linked list
                LinkedHashMap.Add(word, value);                                            //6.20 At last it will come here and Second word will executed
            }
            int frequency = LinkedHashMap.Get("to");
            Console.WriteLine(frequency);

            ///UC_2:Find the frequency of word in paragraph
             string Paragraph = "“Paranoids are not paranoid because they are " +
                "paranoid but because they keep putting themselves deliberately into" +
                " paranoid avoidable situations";
            string[] letters = Paragraph.ToLower().Split(" ");

            foreach (string word in letters)
            {
             int value = LinkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequency1 = LinkedHashMap.Get("paranoid");
            Console.WriteLine(frequency1);

            //UC_3:Remove particular word from the paragraph

            LinkedHashMap.Remove("avoidable");
            int frequency2 = LinkedHashMap.Get("avoidable");

            Console.WriteLine(frequency2);
        }
    }
}

//UC_3
//Remove avoidable word from the phrase “Paranoids are not paranoid
//because they are paranoid but because they keep putting themselves
//deliberately into paranoid avoidable situations”
//- Use LinkedList to do the Hash Table Operation like here the removal of word avoidable
//- To do this create MyMapNode with Key Value Pair and create LinkedList of MyMapNode

//Result
//Welcome to Data Structure Problem Using Generics
//0