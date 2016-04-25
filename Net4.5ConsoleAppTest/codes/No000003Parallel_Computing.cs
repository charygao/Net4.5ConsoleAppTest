using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chinese中文排序Sort
{
    internal class Program
    {
        private static List<int> Data = new List<int>();
        /// <summary>
        /// 是否显示执行过程
        /// </summary>
        public static bool ShowProcessExecution = true;
        /// <summary>
        /// 这是普通循环for
        /// </summary>
        private static void Demo1NormaFor()
        {
            List<int> data = Program.Data;
            DateTime dt1 = DateTime.Now;
            for (int i = 0; i < data.Count; i++)
            {
                Thread.Sleep(500);
                if (ShowProcessExecution)
                    Console.WriteLine(data[i]);
            }
            DateTime dt2 = DateTime.Now;
            Console.WriteLine("普通循环For运行时长：{0}毫秒。", (dt2 - dt1).TotalMilliseconds);
        }
        /// <summary>
        /// 这是普通循环foreach
        /// </summary>
        private static void Demo2NormalForeach()
        {
            List<int> data = Program.Data;
            DateTime dt1 = DateTime.Now;
            foreach (var i in data)
            {
                Thread.Sleep(500);
                if (ShowProcessExecution)
                    Console.WriteLine(i);
            }
            DateTime dt2 = DateTime.Now;
            Console.WriteLine("普通循环Foreach运行时长：{0}毫秒。", (dt2 - dt1).TotalMilliseconds);
        }
        /// <summary>
        /// 这是并行计算For
        /// </summary>
        private static void Demo3ParallelFor()
        {
            List<int> data = Program.Data;
            DateTime dt1 = DateTime.Now;
            Parallel.For(0, data.Count, (i) =>
            {
                Thread.Sleep(500);
                if (ShowProcessExecution)
                    Console.WriteLine(data[i]);
            });
            DateTime dt2 = DateTime.Now;
            Console.WriteLine("并行运算For运行时长：{0}毫秒。", (dt2 - dt1).TotalMilliseconds);
        }
        /// <summary>
        /// 这是并行计算ForEach
        /// </summary>
        private static void Demo4ParallelForeach()
        {
            List<int> data = Program.Data;
            DateTime dt1 = DateTime.Now;
            Parallel.ForEach(data, (i) =>
            {
                Thread.Sleep(500);
                if (ShowProcessExecution)
                    Console.WriteLine(i);
            });
            DateTime dt2 = DateTime.Now;
            Console.WriteLine("并行运算ForEach运行时长：{0}毫秒。", (dt2 - dt1).TotalMilliseconds);
        }
        private static void Main(string[] args)
        {
            string sTemp = "0123456789";
            Console.WriteLine(sTemp.Substring(0, 3));//012
            UInt64 uintROWNUM = 0;
            UInt64 sInt = ++uintROWNUM;
            Console.WriteLine(sInt.ToString());//1

            Program.Data = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Data.Add(i);
            }
            Demo1NormaFor();//5004.347毫秒。
            Demo2NormalForeach();//5003.8115毫秒。
            Demo3ParallelFor();//1089.198毫秒。
            Demo4ParallelForeach();//1021.5196毫秒。

            Console.ReadKey();
        }
    }
}