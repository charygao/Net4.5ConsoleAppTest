using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleTest
{

    class Program
    {
        class Test
        {
            public string Num = "";
        }

        static void Main(string[] args)
        {

            List<Test> listTest = new List<Test>();

            for (int i = 0; i < 10; i++)
            {
                listTest.Add(new Test { Num = i.ToString() });
            }
            int NumCount = 10;
            //foreach (var list in listTest)
            //{
            //    NumCount++;
            //    if (listTest.Count < 20)
            //    {
            //        listTest.Add(new Test { Num = NumCount.ToString() });
            //    }
            //    Console.WriteLine(list.Num);
            //}//报错
            NumCount = 100;
            for (int i = 0; i < listTest.Count; i++)
            {
                NumCount++;
                if (listTest.Count < 20)
                {
                    listTest.Add(new Test { Num = NumCount.ToString() });
                }
                Console.WriteLine(listTest[i].Num);
            }

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("1", "helo1");
            dict.Add("2", "helo2");
            var keysList = new string[dict.Count];
            dict.Keys.CopyTo(keysList, 0);
            foreach (var key in keysList)
            {
                Console.WriteLine("key_  " + key.ToString() + ":" + dict[key]);
                dict.Remove(key);          //   Response.Write("key" + key.ToString() + ":" + dict[key]);   
            }
            Console.WriteLine("AfterRemoved!=========================================");

            foreach (var dic in dict)
            {
                Console.WriteLine(dic.Key, dic.Value);
            }
            Console.WriteLine("dic AfterShow!=========================================");

            Dictionary<int, string> dict2 = new Dictionary<int, string>();
            dict2.Add(1, "helo21");
            dict2.Add(2, "helo22");
            var keysList2 = new int[dict2.Count];
            dict2.Keys.CopyTo(keysList2, 0);
            foreach (var key2 in keysList2)
            {
                Console.WriteLine("key_  " + key2.ToString() + ":" + dict2[key2]);
                dict.Remove(key2.ToString());          //   Response.Write("key" + key.ToString() + ":" + dict[key]);   
            }
            Console.WriteLine("dict2 AfterRemoved!=========================================");

            foreach (var dic in dict)
            {
                Console.WriteLine(dic.Key, dic.Value);
            }


            Console.ReadLine();

            Console.Read();


        }
    }
}