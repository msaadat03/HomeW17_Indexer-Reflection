using System;
using System.Collections.Generic;

namespace HomeW17_Indexer_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> studentnames = new MyList<string>();

            studentnames.Add("Fidan");
            studentnames.Add("Nermin");
            studentnames.Add("Saadat");

            studentnames.Clear("Saadat");
            studentnames.Find("Nermin");

        }
        public class MyList<T>
        {
            private string[] arr;

            public MyList()
            {
                arr = new string[0];
            }

            public void Add(string names)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = names;
            }


            public void Clear(string names)
            {
                

            }



            public void Find(string names)
            {
                var result = names;

                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}