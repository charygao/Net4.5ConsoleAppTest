using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleTest
{

    class Program
    {
        static void Main(string[] args)
        {

            List<string> listTest = new List<string>();
            for (int i = 1; i <= 500000; i++)//50_0000
            {
                listTest.Add(i.ToString().PadLeft(10, '0'));
            }

            Stopwatch stopMatch = new Stopwatch();
            stopMatch.Start();
            List<string> listOrder = listTest.OrderByDescending(c => c).ToList<string>();
            stopMatch.Stop();

            Console.WriteLine("Linq排序耗时:\t{0}毫秒", stopMatch.ElapsedMilliseconds.ToString());

            stopMatch.Reset();

            stopMatch.Start();

            var sortedList = new System.Collections.Generic.SortedList<string, string>();
            foreach (var item in listTest)
            {
                sortedList.Add(item,item);
            }
            Console.WriteLine("SortedList排序耗时:\t{0}毫秒", stopMatch.ElapsedMilliseconds.ToString());
            stopMatch.Stop();

            string[] arrTest = listOrder.ToArray();

            stopMatch.Reset();
            stopMatch.Start();
            QuickSort(arrTest, 0, arrTest.Length - 1);

            stopMatch.Stop();

            Console.WriteLine("二分法排序耗时:\t{0}毫秒", stopMatch.ElapsedMilliseconds.ToString());


            Console.Read();


        }



        /// <summary>
        /// 二分法从小到大排序
        /// </summary>
        /// <param name="array">需要排序的字符串数组</param>
        /// <param name="start">排序元素的起始下标</param>
        /// <param name="end">排序元素的结止下标</param>       
        public static void QuickSort(string[] array, int start, int end)
        {

            //有可能造成start>end   因为递归调用时j+1，可能引起j比end还大1。 另外如果数组是空的，或者输入错误也会出现这种情况
            if (end <= start)
            {
                return;
            }
            else
            {

                //取中间元素为中心点，然后移到最右边
                int sign = (start + end) / 2;
                string tmp = array[end];
                array[end] = array[sign];
                array[sign] = tmp;
                int j = start;

                for (int i = start; i <= end - 1; i++)
                {

                    //小于的元素和标记互换，等于的不能互换，否则会形成死循环                   
                    if (array[i].CompareTo(array[end]) == -1)
                    {

                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                        j = j + 1;

                    }

                }

                //把标记元素和第一个>=它的元素位置互换，这样数组就分成2个部分，一个部分比中心值小，一个部分比中心值大。
                tmp = array[j];
                array[j] = array[end];
                array[end] = tmp;
                QuickSort(array, start, j);
                QuickSort(array, j + 1, end);
            }

        }


    }
}