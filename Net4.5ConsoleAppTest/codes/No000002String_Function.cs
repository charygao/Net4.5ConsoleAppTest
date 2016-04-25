using System;

namespace Chinese中文排序Sort
{
    internal class Program
    {
        /// <summary>
        /// 取子字符串
        /// </summary>
        /// <param name="oriStr">原字符串</param>
        /// <param name="beginIndex">取子串的起始位置</param>
        /// <param name="len">取子串的长度</param>
        /// <returns>子字符串</returns>
        public static String subString(String oriStr, int beginIndex, int len)
        {
            int strlen = oriStr.Length;
            beginIndex = beginIndex - 1;
            string str = null;
            if (strlen <= beginIndex)
            {
                Console.WriteLine("out of " + oriStr + "'s length, please recheck!");
            }
            else if (strlen <= beginIndex + len)
            {
                str = oriStr.Substring(beginIndex);
            }
            else {
                str = oriStr.Substring(beginIndex, beginIndex + len);
            }
            return str;
        }

        /// <summary>
        /// 左补位，右对齐
        /// </summary>
        /// <param name="oriStr">原字符串</param>
        /// <param name="len">目标字符串长度</param>
        /// <param name="alexin">补位字符</param>
        /// <returns>目标字符串</returns>
        public static String padRight(String oriStr, int len, char alexin)
        {
            int strlen = oriStr.Length;
            string str = null;
            if (strlen < len)
            {
                for (int i = 0; i < len - strlen; i++)
                {
                    str = str + alexin;
                }
            }
            str = str + oriStr;
            return str;
        }

        /// <summary>
        /// 右补位，左对齐
        /// </summary>
        /// <param name="oriStr">原字符串</param>
        /// <param name="len">目标字符串长度</param>
        /// <param name="alexin">补位字符</param>
        /// <returns>目标字符串</returns>
        public static String padLeft(String oriStr, int len, char alexin)
        {
            int strlen = oriStr.Length;
            string str = null;
            if (strlen < len)
            {
                for (int i = 0; i < len - strlen; i++)
                {
                    str = str + alexin;
                }
            }
            str = oriStr + str;
            return str;
        }

        private static void Main(string[] args)
        {
            string sTemp = "0123456789";
            Console.WriteLine(sTemp.Substring(0, 3));//012
            UInt64 uintROWNUM = 0;
            UInt64 sInt = ++uintROWNUM;
            Console.WriteLine(sInt.ToString());//1




            Console.ReadKey();
        }
    }
}

