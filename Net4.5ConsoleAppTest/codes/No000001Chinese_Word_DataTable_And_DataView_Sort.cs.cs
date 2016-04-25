using System;
using System.Collections.Generic;
using System.Data;

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
            List<string> list = new List<string>() {
                  "张三"
                , "李四"
                , "王五"
                ,"Admin"
                ,"Gauge"
                ,"JIRA"
                ,"Class"
                ,"Kauai"
                ,"aDesign"
                ,"here"
                ,"jeans"
                ,"lax"
                ,"Data"
                ,"010Admin"
                ,"452Gauge"
                ,"45JIRA"
                ,"8963Class"
                ,"45Kauai"
                ,"445245aDesign"
                ,"   here"
                ,"..jeans"
                ,"@lax"
                ,"^Data"
                ,"啊"
            };
            list.Sort();
            //list.Reverse();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("********************************");

            //****先建立一个表DataTable,然后添加列名称Columns,构建框架!
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("COMPCODE");//机构代码
            dataTable.Columns.Add("INSTNAME");//机构全称
            dataTable.Columns.Add("INSTSNAME");//机构简称
            //****
            dataTable.Locale = System.Globalization.CultureInfo.CreateSpecificCulture("zh-CN");//国际化语言,参见No000000Invariant_Language.cs

            #region 数据字典

            string[] sCOMPCODE = {//机构代码数据字典
            "80156777","80046614","80351345","80365986","80455765","80065113","80341238","80043259",
            "80163340","80000236","80365985","80000226","80161341","80139382","80000239",
            "80000249","80468996","80452130","80066470","80074234","80280395","80036742","80000229",
            "80046522","80000237","80000235","80175498","80356155","80280036","80036782","80403111",
            "80091787","80280038","80000231","80000080","80145102","80050229","80366080","80045188",
            "80000238","80061674","80000247","80041198","80127873","80000252","80000240","80147736",
            "80114781","80174741","80128562","80000221","80064225","80048088","80000248","80000095",
            "80044515","80102419","80280039","80043374","80355783","80000224","80000233","80000246",
            "80205263","80385906","80000228","80000250","80368700","80037023","80092743","80199117",
            "80106677","80036797","80000220","80092233","80049689","80068180","80000230","80168726",
            "80000227","80000243","80380794","80000225","80175511","80042861","80205268","80048161",
            "80053204","80055334","80000222","80201857","80067635","80053708","80365987","80000223",
            "80065990","80205264","80064562","80446423","80000245","80086876","80000251","80384640",
            "80355113","80048752","80075936","80294346","80424273","80351991"
            };
            string[] sINSTNAME = {//机构全称数据字典
            "安信基金管理有限责任公司","宝盈基金管理有限公司","北信瑞丰基金管理有限公司","博时基金管理有限公司",
            "财通基金管理有限公司","长安基金管理有限公司","长城基金管理有限公司","长盛基金管理有限公司",
            "华宸未来基金管理有限公司","汇丰晋信基金管理有限公司","汇添富基金管理股份有限公司","嘉合基金管理有限公司",
            "招商基金管理有限公司","浙江浙商证券资产管理有限公司","浙商基金管理有限公司","中海基金管理有限公司","中加基金管理有限公司",
            "中金基金管理有限公司","中科沃土基金管理有限公司","中欧基金管理有限公司","中融基金管理有限公司","中信基金管理有限责任公司",
            "嘉实基金管理有限公司","建信基金管理有限责任公司","江信基金管理有限公司","交银施罗德基金管理有限公司","金信基金管理有限公司",
            "上银基金管理有限公司","申万菱信基金管理有限公司","泰达宏利基金管理有限公司","泰康资产管理有限责任公司","泰信基金管理有限公司",
            "天弘基金管理有限公司","天津德厚基金管理有限公司","天治基金管理有限公司","万家基金管理有限公司","西部利得基金管理有限公司",
            "新华基金管理股份有限公司","新疆前海联合基金管理有限公司","新沃基金管理有限公司","信诚基金管理有限公司","信达澳银基金管理有限公司",
            "金鹰基金管理有限公司","金元顺安基金管理有限公司","景顺长城基金管理有限公司","九泰基金管理有限公司",
            "民生加银基金管理有限公司","摩根士丹利华鑫基金管理有限公司","南方基金管理有限公司","农银汇理基金管理有限公司",
            "诺安基金管理有限公司","诺德基金管理有限公司","鹏华基金管理有限公司","平安大华基金管理有限公司","浦银安盛基金管理有限公司",
            "长信基金管理有限责任公司","创金合信基金管理有限公司","大成基金管理有限公司","德邦基金管理有限公司",
            "东方基金管理有限责任公司","东海基金管理有限责任公司","东吴基金管理有限公司","东兴证券股份有限公司",
            "银河基金管理有限公司","银华基金管理有限公司","英大基金管理有限公司","永赢基金管理有限公司","圆信永丰基金管理有限公司",
            "国金基金管理有限公司","国开泰富基金管理有限责任公司","国联安基金管理有限公司","国寿安保基金管理有限公司",
            "国泰基金管理有限公司","国投瑞银基金管理有限公司","海富通基金管理有限公司","红塔红土基金管理有限公司","红土创新基金管理有限公司",
            "华安基金管理有限公司","华宝兴业基金管理有限公司","华福基金管理有限责任公司","华富基金管理有限公司","华融证券股份有限公司",
            "华润元大基金管理有限公司","华商基金管理有限公司","华泰柏瑞基金管理有限公司","华夏基金管理有限公司",
            "前海开源基金管理有限公司","融通基金管理有限公司","山西证券股份有限公司","上海东方证券资产管理有限公司","上投摩根基金管理有限公司",
            "方正富邦基金管理有限公司","富安达基金管理有限公司","富国基金管理有限公司","工银瑞信基金管理有限公司",
            "光大保德信基金管理有限公司","广发基金管理有限公司","国都证券股份有限公司","国海富兰克林基金管理有限公司",
            "兴业基金管理有限公司","兴业全球基金管理有限公司","易方达基金管理有限公司","益民基金管理有限公司",
            "中信建投基金管理有限公司","中银基金管理有限公司","中邮创业基金管理股份有限公司","中原英石基金管理有限公司","泓德基金管理有限公司",
            "鑫元基金管理有限公司"
            };
            string[] sINSTSNAME = {//机构简称数据字典
            "安信基金","宝盈基金","北信瑞丰","博时基金","财通基金","长安基金","长城基金",
            "前海开源基金","融通基金","山西证券","上海东方证券资产管理","上投摩根基金","上银基金",
            "金信基金","金鹰基金","金元顺安基金","景顺长城基金","九泰基金","民生加银基金","摩根士丹利华鑫基金",
            "万家基金","西部利得基金","新华基金","前海联合","新沃基金","信诚基金","信达澳银基金","兴业基金",
            "汇丰晋信基金","汇添富基金","嘉合基金","嘉实基金","建信基金","江信基金","交银施罗德基金",
            "东兴证券","方正富邦基金","富安达基金","富国基金","工银瑞信基金","光大保德信基金","广发基金",
            "南方基金","农银汇理基金","诺安基金","诺德基金","鹏华基金","平安大华基金","浦银安盛基金",
            "国都证券","国海富兰克林基金","国金基金","国开泰富基金","国联安基金","国寿安保基金",
            "兴业全球基金","易方达基金","益民基金","银河基金","银华基金","英大基金","永赢基金","圆信永丰基金",
            "华福基金","华富基金","华融证券","华润元大基金","华商基金","华泰柏瑞基金","华夏基金","华宸未来基金",
            "长盛基金","长信基金","创金合信基金","大成基金","德邦基金","东方基金","东海基金","东吴基金",
            "申万菱信基金","泰达宏利基金","泰康资产","泰信基金","天弘基金","天津德厚基金","天治基金",
            "招商基金","浙江浙商证券资产管理","浙商基金","中海基金","中加基金","中金基金","中科沃土基金","中欧基金",
            "国泰基金","国投瑞银基金","海富通基金","红塔红土","红土创新基金","华安基金","华宝兴业基金",
            "中融基金","中信基金","中信建投基金","中银基金","中邮基金","中原英石基金","泓德基金","鑫元基金"
            };

            #endregion 数据字典

            for (int i = 0; i < 109; i++)//加数据到dataTable
            {
                DataRow drRows = dataTable.NewRow();
                drRows["COMPCODE"] = sCOMPCODE[i];
                drRows["INSTNAME"] = sINSTNAME[i];
                drRows["INSTSNAME"] = sINSTSNAME[i];
                dataTable.Rows.Add(drRows);
            }

            #region 显示原表

            foreach (DataColumn columnItem in dataTable.Columns)
            {
                string sDisplaied = padRight(columnItem.Caption, 17, '高');//右对齐,左补位
                Console.Write("=+{0,-17:G}+=\t", sDisplaied);
            }

            Console.WriteLine("\n-------------------------------------------原表表内容如下-------------------------------------------");

            foreach (DataRow rowItem in dataTable.Rows)
            {
                foreach (var rowArrayItem in rowItem.ItemArray)
                {
                    string sItemString = rowArrayItem.ToString();
                    string sDisplaied = padRight(sItemString, 17, '高');//左补位，右对齐
                    Console.Write("|*{0,-17:G}*| ", sDisplaied);
                }
                Console.WriteLine();
            }

            #endregion 显示原表

            Console.WriteLine("\n\n\n===========================================排序表内容如下===========================================\n\n\n");

            #region 排序

            DataView dataView = dataTable.DefaultView;
            dataView.Sort = "[INSTSNAME] asc";//DV.Sort = "c1 desc,c2 asc";desc 降序,asc升序  //dv.Sort = "[字段1] desc,[字段2]"
            dataTable = dataView.ToTable();

            #endregion 排序

            #region 显示排序后的内容

            foreach (DataColumn columnItem in dataTable.Columns)
            {
                string sDisplaied = padLeft(columnItem.Caption, 17, '高');//右补位，左对齐
                Console.Write("=+{0,-17:G}+=\t", sDisplaied);
            }

            Console.WriteLine("\n-------------------------------------------表内容如下-------------------------------------------");

            foreach (DataRow rowItem in dataTable.Rows)
            {
                foreach (var rowArrayItem in rowItem.ItemArray)
                {
                    string sItemString = rowArrayItem.ToString();
                    string sDisplaied = padLeft(sItemString, 17, '高');//右补位，左对齐
                    Console.Write("|*{0,-17:G}*| ", sDisplaied);
                }
                Console.WriteLine();
            }

            #endregion 显示排序后的内容

            Console.ReadKey();
        }
    }
}