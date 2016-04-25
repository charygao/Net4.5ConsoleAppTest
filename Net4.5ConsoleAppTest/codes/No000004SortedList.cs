using System;
using System.Collections.Generic;
using System.Linq;

namespace Chinese中文排序Sort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tmpDic = new SortedList<string, string>();
            tmpDic.Add("a", "a");
            tmpDic.Add("1", "1");
            tmpDic.Add("2", "2");
            tmpDic.Add("b", "b");
            //tmpDic.Reverse();//12ab
            foreach (var item in tmpDic.Keys.Reverse())//ba21
            {
                Console.WriteLine(item);
            }
            var firstSortWord = new SortedList<string, string>();
            tmpDic.Add("a", "a");
            tmpDic.Add("1", "1");
            tmpDic.Add("2", "2");
            tmpDic.Add("b", "b");




            Console.ReadKey();
        }
    }
}