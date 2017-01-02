using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace array_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int [4];
            numbers[1] = 24;
            for (int n=0; n < numbers.Length; n++)
            {
                Console.WriteLine("Here is what is in the array item {0}: {1}",n,numbers[n]);
                
            }
            foreach (var i in numbers)
            {
                Console.WriteLine("Here are contents of numbers array using foreach {0}",i);
            }
            int  [] [] jaggedInts = new int [6] [];
            jaggedInts[0] = new int[2];
            jaggedInts[1] = new int[3];
            jaggedInts[2] = new int[4];
            jaggedInts[3] = new int[4];
            jaggedInts[4] = new int[5];
            jaggedInts[5] = new int[6];
            foreach (var jag in jaggedInts)
            {
                Console.WriteLine(jag);
            }
            for (int i = 0; i < jaggedInts.Length; i++)
            {
                for (int j = 0; j < jaggedInts[i].Length; j++)
                {
                   Console.WriteLine("row {0} column {1} value {2}",i,j,jaggedInts[i][j]);
                }
            }
            IList<int> inList = new List<int>() { 45, 34, 66 };
            inList.Add(22);
            foreach (int item in inList)
            {
                Console.WriteLine("Here is what is in my list called inlist {0}",item);
            }
            Console.WriteLine("Here is item zero {0}", inList[0]);
            
            inList.ToList().ForEach(el => Console.WriteLine("Via lambda {0}",el));
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt","notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dip", "notepad.exe");
            openWith.Add("rtf", "wordpad.exe");
            try
            {
                openWith.Add("txt", "notepad.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with key \"txt\" already exists");
            }
            Console.WriteLine("For key = \"rtf\" ,value = {0}.",openWith["rtf"]);
            openWith["doc"] = "winword.exe";
            try
            {
                Console.WriteLine("for key = \"tif\" value = {0}", openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key \"tif\" is not found");
            }
            string value = "";
            if (openWith.TryGetValue("tif",out value))
            {
                Console.WriteLine("For key \"tif\", value = {0} ",value);
            }
            else
            {
                Console.WriteLine("Key \"tif\" is not found.");
            }
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht","hyperterm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);

            }
            foreach (KeyValuePair<string,string> item in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}",item.Key, item.Value);
            }
            Dictionary<string, string>.ValueCollection valueCol = openWith.Values;
            foreach (string item in valueCol)
            {
                Console.WriteLine("Here are just the values in the Dictionary {0}",item);
            }
            Dictionary<string, string>.KeyCollection keyCol = openWith.Keys;
            foreach (string item in keyCol)
            {
                Console.WriteLine("Here are just the keys in the Dictionary {0}", item);
            }
            openWith.Remove("doc");
            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" was successfully removed");
            }
            Console.ReadLine();
        }
    }
}
