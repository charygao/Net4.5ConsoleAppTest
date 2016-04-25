using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Em.Source.Report.Common
{
    /// <summary>
    /// publish/subscribe model: publisher
    /// </summary>
    public class CoConTimer : IDisposable
    {
        #region static Dictionary<string, int>

        #endregion
        /// <summary>
        /// int 0:without new cache;1:update group one;2:update group two;and so on
        /// </summary>
        public static Dictionary<string, int> classDic = new Dictionary<string, int>
        {
            {"ResearchCode51"                          ,(int)GroupName.Group0},//{"ResearchCode51"                          ,GroupName.Group0},
            {"SCode28"                                 ,(int)GroupName.Group0},//{"SCode28"                                 ,GroupName.Group0},
            {"SecCode114"                              ,(int)GroupName.Group0},//{"SecCode114"                              ,GroupName.Group0},
            {"SecIndustry2012Sub111"                   ,(int)GroupName.Group0},//{"SecIndustry2012Sub111"                   ,GroupName.Group0},
            {"SecInstituCode127"                       ,(int)GroupName.Group0},//{"SecInstituCode127"                       ,GroupName.Group0},
            {"SecurityCompCode11"                      ,(int)GroupName.Group0},//{"SecurityCompCode11"                      ,GroupName.Group0},
            {"ShareholderCode83"                       ,(int)GroupName.Group0},//{"ShareholderCode83"                       ,GroupName.Group0},
            {"StandBondContract99"                     ,(int)GroupName.Group0},//{"StandBondContract99"                     ,GroupName.Group0},
            {"StockBondCode123"                        ,(int)GroupName.Group0},//{"StockBondCode123"                        ,GroupName.Group0},
            {"StockOption88"                           ,(int)GroupName.Group0},//{"StockOption88"                           ,GroupName.Group0},
            {"StockReplaceCode64"                      ,(int)GroupName.Group0},//{"StockReplaceCode64"                      ,GroupName.Group0},
            {"StockResearchedDataSource55"             ,(int)GroupName.Group0},//{"StockResearchedDataSource55"             ,GroupName.Group0},
            {"StopRecordTable35"                       ,(int)GroupName.Group0},//{"StopRecordTable35"                       ,GroupName.Group0},
            {"TestTree45"                              ,(int)GroupName.Group0},//{"TestTree45"                              ,GroupName.Group0},
            {"TopCompanyManagement63"                  ,(int)GroupName.Group0},//{"TopCompanyManagement63"                  ,GroupName.Group0},
            {"TradingTipsCodes31"                      ,(int)GroupName.Group0},//{"TradingTipsCodes31"                      ,GroupName.Group0},
            {"TrustCode23"                             ,(int)GroupName.Group0},//{"TrustCode23"                             ,GroupName.Group0},
            {"TrustNetSource59"                        ,(int)GroupName.Group0},//{"TrustNetSource59"                        ,GroupName.Group0},
            {"USAStockAnnounCode100"                   ,(int)GroupName.Group0},//{"USAStockAnnounCode100"                   ,GroupName.Group0},
            {"USAStockCode89"                          ,(int)GroupName.Group0},//{"USAStockCode89"                          ,GroupName.Group0},
            {"USAStockIssueBasicInfo121"               ,(int)GroupName.Group0},//{"USAStockIssueBasicInfo121"               ,GroupName.Group0},
            {"UsrerName18"                             ,(int)GroupName.Group0},//{"UsrerName18"                             ,GroupName.Group0},
            {"WealthManagePrivateProdect125"           ,(int)GroupName.Group0},//{"WealthManagePrivateProdect125"           ,GroupName.Group0},
            {"ACompCode32"                             ,(int)GroupName.Group0},//{"ACompCode32"                             ,GroupName.Group0},
            {"AcrossMarketFund80"                      ,(int)GroupName.Group0},//{"AcrossMarketFund80"                      ,GroupName.Group0},
            {"AnnounceCompanyCode71"                   ,(int)GroupName.Group0},//{"AnnounceCompanyCode71"                   ,GroupName.Group0},
            {"AssetBackSecCode118"                     ,(int)GroupName.Group0},//{"AssetBackSecCode118"                     ,GroupName.Group0},
            {"AssetReorganCode120"                     ,(int)GroupName.Group0},//{"AssetReorganCode120"                     ,GroupName.Group0},
            {"AStockHKStock94"                         ,(int)GroupName.Group0},//{"AStockHKStock94"                         ,GroupName.Group0},
            {"BaseRate109"                             ,(int)GroupName.Group0},//{"BaseRate109"                             ,GroupName.Group0},
            {"BCode30"                                 ,(int)GroupName.Group0},//{"BCode30"                                 ,GroupName.Group0},
            {"BcompCode14"                             ,(int)GroupName.Group0},//{"BcompCode14"                             ,GroupName.Group0},
            {"BondCode20"                              ,(int)GroupName.Group0},//{"BondCode20"                              ,GroupName.Group0},
            {"BondCode42"                              ,(int)GroupName.Group0},//{"BondCode42"                              ,GroupName.Group0},
            {"BondCode85"                              ,(int)GroupName.Group0},//{"BondCode85"                              ,GroupName.Group0},
            {"BondFundPortfolioCode72"                 ,(int)GroupName.Group0},//{"BondFundPortfolioCode72"                 ,GroupName.Group0},
            {"BondholderMeetTableSerialNumber09"       ,(int)GroupName.Group0},//{"BondholderMeetTableSerialNumber09"       ,GroupName.Group0},
            {"BondMarketCode73"                        ,(int)GroupName.Group0},//{"BondMarketCode73"                        ,GroupName.Group0},
            {"BondPlanInnerCode15"                     ,(int)GroupName.Group0},//{"BondPlanInnerCode15"                     ,GroupName.Group0},
            {"BondRepurchaseSN104"                     ,(int)GroupName.Group0},//{"BondRepurchaseSN104"                     ,GroupName.Group0},
            {"BrokerageSaleDepartment82"               ,(int)GroupName.Group0},//{"BrokerageSaleDepartment82"               ,GroupName.Group0},
            {"BusinessDepartCode91"                    ,(int)GroupName.Group0},//{"BusinessDepartCode91"                    ,GroupName.Group0},
            {"CompAndFundTyoe48"                       ,(int)GroupName.Group0},//{"CompAndFundTyoe48"                       ,GroupName.Group0},
            {"CompCode29"                              ,(int)GroupName.Group0},//{"CompCode29"                              ,GroupName.Group0},
            {"CompIndiviCode90"                        ,(int)GroupName.Group0},//{"CompIndiviCode90"                        ,GroupName.Group0},
            {"CorrespondingStockCodes44"               ,(int)GroupName.Group0},//{"CorrespondingStockCodes44"               ,GroupName.Group0},
            {"CreditVoucher65"                         ,(int)GroupName.Group0},//{"CreditVoucher65"                         ,GroupName.Group0},
            {"EMPlate115"                              ,(int)GroupName.Group0},//{"EMPlate115"                              ,GroupName.Group0},
            {"FCompCode02"                             ,(int)GroupName.Group0},//{"FCompCode02"                             ,GroupName.Group0},
            {"FinanceAuditCode112"                     ,(int)GroupName.Group0},//{"FinanceAuditCode112"                     ,GroupName.Group0},
            {"FinanceCode05"                           ,(int)GroupName.Group0},//{"FinanceCode05"                           ,GroupName.Group0},
            {"FinancePlanCode25"                       ,(int)GroupName.Group0},//{"FinancePlanCode25"                       ,GroupName.Group0},
            {"FinancialCompList87"                     ,(int)GroupName.Group0},//{"FinancialCompList87"                     ,GroupName.Group0},
            {"Fmcode07"                                ,(int)GroupName.Group0},//{"Fmcode07"                                ,GroupName.Group0},
            {"ForeignCustomCode103"                    ,(int)GroupName.Group0},//{"ForeignCustomCode103"                    ,GroupName.Group0},
            {"FpCode33"                                ,(int)GroupName.Group0},//{"FpCode33"                                ,GroupName.Group0},
            {"FundCode21"                              ,(int)GroupName.Group0},//{"FundCode21"                              ,GroupName.Group0},
            {"FundCustodianCode16"                     ,(int)GroupName.Group0},//{"FundCustodianCode16"                     ,GroupName.Group0},
            {"FundFinancialCode106"                    ,(int)GroupName.Group0},//{"FundFinancialCode106"                    ,GroupName.Group0},
            {"FundHolderMeetingSn08"                   ,(int)GroupName.Group0},//{"FundHolderMeetingSn08"                   ,GroupName.Group0},
            {"FundInvestSecCode78"                     ,(int)GroupName.Group0},//{"FundInvestSecCode78"                     ,GroupName.Group0},
            {"FundNote54"                              ,(int)GroupName.Group0},//{"FundNote54"                              ,GroupName.Group0},
            {"FundNoteSubjects53"                      ,(int)GroupName.Group0},//{"FundNoteSubjects53"                      ,GroupName.Group0},
            {"FundPerformBenchCode116"                 ,(int)GroupName.Group0},//{"FundPerformBenchCode116"                 ,GroupName.Group0},
            {"FundPrivateCode75"                       ,(int)GroupName.Group0},//{"FundPrivateCode75"                       ,GroupName.Group0},
            {"FundSeriesCode36"                        ,(int)GroupName.Group0},//{"FundSeriesCode36"                        ,GroupName.Group0},
            {"FutureContractCode79"                    ,(int)GroupName.Group0},//{"FutureContractCode79"                    ,GroupName.Group0},
            {"FutureMember84"                          ,(int)GroupName.Group0},//{"FutureMember84"                          ,GroupName.Group0},
            {"FuturesVarietiesCode58"                  ,(int)GroupName.Group0},//{"FuturesVarietiesCode58"                  ,GroupName.Group0},
            {"GCompCode34"                             ,(int)GroupName.Group0},//{"GCompCode34"                             ,GroupName.Group0},
            {"HKCode74"                                ,(int)GroupName.Group0},//{"HKCode74"                                ,GroupName.Group0},
            {"HKCompanyCode93"                         ,(int)GroupName.Group0},//{"HKCompanyCode93"                         ,GroupName.Group0},
            {"HKExecutiveCode98"                       ,(int)GroupName.Group0},//{"HKExecutiveCode98"                       ,GroupName.Group0},
            {"HKexStructProduct108"                    ,(int)GroupName.Group0},//{"HKexStructProduct108"                    ,GroupName.Group0},
            {"HKFund47"                                ,(int)GroupName.Group0},//{"HKFund47"                                ,GroupName.Group0},
            {"HKFund105"                               ,(int)GroupName.Group0},//{"HKFund105"                               ,GroupName.Group0},
            {"HKIssueNumber119"                        ,(int)GroupName.Group0},//{"HKIssueNumber119"                        ,GroupName.Group0},
            {"HKShareHolderCode81"                     ,(int)GroupName.Group0},//{"HKShareHolderCode81"                     ,GroupName.Group0},
            {"HKStructProduct102"                      ,(int)GroupName.Group0},//{"HKStructProduct102"                      ,GroupName.Group0},
            {"HostMeetingNoticeSN26"                   ,(int)GroupName.Group0},//{"HostMeetingNoticeSN26"                   ,GroupName.Group0},
            {"IndexCodes49"                            ,(int)GroupName.Group0},//{"IndexCodes49"                            ,GroupName.Group0},
            {"IndustryCategoryCode69"                  ,(int)GroupName.Group0},//{"IndustryCategoryCode69"                  ,GroupName.Group0},
            {"IndustryChangeCompCode76"                ,(int)GroupName.Group0},//{"IndustryChangeCompCode76"                ,GroupName.Group0},
            {"InputDateBasetableName17"                ,(int)GroupName.Group0},//{"InputDateBasetableName17"                ,GroupName.Group0},
            {"InternetToolsJ97"                        ,(int)GroupName.Group0},//{"InternetToolsJ97"                        ,GroupName.Group0},
            {"InvestmentPAccount10"                    ,(int)GroupName.Group0},//{"InvestmentPAccount10"                    ,GroupName.Group0},
            {"Iscode06"                                ,(int)GroupName.Group0},//{"Iscode06"                                ,GroupName.Group0},
            {"JobCode50"                               ,(int)GroupName.Group0},//{"JobCode50"                               ,GroupName.Group0},
            {"LawSourceDepartment86"                   ,(int)GroupName.Group0},//{"LawSourceDepartment86"                   ,GroupName.Group0},
            {"LCompCode40"                             ,(int)GroupName.Group0},//{"LCompCode40"                             ,GroupName.Group0},
            {"MainlandHKFund122"                       ,(int)GroupName.Group0},//{"MainlandHKFund122"                       ,GroupName.Group0},
            {"MajorSecuCodeTypes43"                    ,(int)GroupName.Group0},//{"MajorSecuCodeTypes43"                    ,GroupName.Group0},
            {"MergerEventID68"                         ,(int)GroupName.Group0},//{"MergerEventID68"                         ,GroupName.Group0},
            {"MineBaseInfo52"                          ,(int)GroupName.Group0},//{"MineBaseInfo52"                          ,GroupName.Group0},
            {"NewCodeTableStockCode124"                ,(int)GroupName.Group0},//{"NewCodeTableStockCode124"                ,GroupName.Group0},
            {"NewStockCode95"                          ,(int)GroupName.Group0},//{"NewStockCode95"                          ,GroupName.Group0},
            {"OfferFinanceInnerCode19"                 ,(int)GroupName.Group0},//{"OfferFinanceInnerCode19"                 ,GroupName.Group0},
            {"Official1103"                            ,(int)GroupName.Group0},//{"Official1103"                            ,GroupName.Group0},
            {"Official1227"                            ,(int)GroupName.Group0},//{"Official1227"                            ,GroupName.Group0},
            {"Official1338"                            ,(int)GroupName.Group0},//{"Official1338"                            ,GroupName.Group0},
            {"OrgBaseInfoAssociatedCode12"             ,(int)GroupName.Group0},//{"OrgBaseInfoAssociatedCode12"             ,GroupName.Group0},
            {"OtherResearchSourceCode57"               ,(int)GroupName.Group0},//{"OtherResearchSourceCode57"               ,GroupName.Group0},
            {"ParticipatorCode13"                      ,(int)GroupName.Group0},//{"ParticipatorCode13"                      ,GroupName.Group0},
            {"Partiescode24"                           ,(int)GroupName.Group0},//{"Partiescode24"                           ,GroupName.Group0},
            {"PeFunds46"                               ,(int)GroupName.Group0},//{"PeFunds46"                               ,GroupName.Group0},
            {"PeInvestEventInfo41"                     ,(int)GroupName.Group0},//{"PeInvestEventInfo41"                     ,GroupName.Group0},
            {"PersonInfoCode39"                        ,(int)GroupName.Group0},//{"PersonInfoCode39"                        ,GroupName.Group0},
            {"PEVCInvestorCode113"                     ,(int)GroupName.Group0},//{"PEVCInvestorCode113"                     ,GroupName.Group0},
            {"PfProductCode04"                         ,(int)GroupName.Group0},//{"PfProductCode04"                         ,GroupName.Group0},
            {"PreferShareTable67"                      ,(int)GroupName.Group0},//{"PreferShareTable67"                      ,GroupName.Group0},
            {"PreferStockCode66"                       ,(int)GroupName.Group0},//{"PreferStockCode66"                       ,GroupName.Group0},
            {"PrivateFund107"                          ,(int)GroupName.Group0},//{"PrivateFund107"                          ,GroupName.Group0},
            {"ProvinceCity70"                          ,(int)GroupName.Group0},//{"ProvinceCity70"                          ,GroupName.Group0},
            {"ProvinceLevel56"                         ,(int)GroupName.Group0},//{"ProvinceLevel56"                         ,GroupName.Group0},
            {"Ptcode22"                                ,(int)GroupName.Group0},//{"Ptcode22"                                ,GroupName.Group0},
            {"PurchaseSerialNumber37"                  ,(int)GroupName.Group0},//{"PurchaseSerialNumber37"                  ,GroupName.Group0},
            {"QDlllndustryType77"                      ,(int)GroupName.Group0},//{"QDlllndustryType77"                      ,GroupName.Group0},
            {"RaiseFundFinancProgramCode117"           ,(int)GroupName.Group0},//{"RaiseFundFinancProgramCode117"           ,GroupName.Group0},
            {"RateDerivateContract126"                 ,(int)GroupName.Group0},//{"RateDerivateContract126"                 ,GroupName.Group0},
            {"RateVarieties96"                         ,(int)GroupName.Group0},//{"RateVarieties96"                         ,GroupName.Group0},
            {"RegistInfoTableID110"                    ,(int)GroupName.Group0},//{"RegistInfoTableID110"                    ,GroupName.Group0},
            {"RepurchaseCode101"                       ,(int)GroupName.Group0} //{"RepurchaseCode101"                       ,GroupName.Group0}
    };

        //private readonly string[] _groupNames = new string[]
        //{
        //    "UpdataGroup0",
        //    "UpdataGroup1",
        //    "UpdataGroup2",
        //    "UpdataGroup3",
        //    "UpdataGroup4",
        //    "UpdataGroup5"
        //};
        private int iGroupId = 0;
        private int iGroupNum = 0;
        public void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            iGroupId++;
            if (iGroupId == iGroupNum)
            {
                iGroupId = 1;//完成一个循环(轮训完毕)
                Debug.WriteLine("轮训完成一次");
                Console.WriteLine("轮训完成一次");
            }
            //Console.WriteLine(Enum.GetName(typeof(GroupName), iGroupId));//通知
            OnTimesUp(iGroupId);
            //System.Threading.Thread.Sleep(1 * 1000);//5秒钟更新一组        
        }
        public CoConTimer()
        {

            System.Timers.Timer t = new System.Timers.Timer(1*1000);//实例化Timer类，设置间隔时间为1秒；
            t.Elapsed += new System.Timers.ElapsedEventHandler(theout);//到达时间的时候执行事件；
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
            GroupName eGroupName = new GroupName();
            iGroupNum = Enum.GetNames(eGroupName.GetType()).Length;
        }

        ~CoConTimer()
        {
            Dispose();
        }

        public event EventHandler<TimesUpEventArgs> TimesUpEvent;//更新组事件
        public void OnTimesUp(int iGroupName)// 事件发生
        {
            TimesUpEventArgs args = new TimesUpEventArgs(iGroupName);
            Console.WriteLine(args);//tostring方法
            if (TimesUpEvent != null) { TimesUpEvent(this, args); }
        }
        public enum GroupName : int//取值范围是{0,127}
        {
            Group0,// = 0,
            Group1,// = 1,
            Group2,// = 2,
            Group3,// = 3,
            Group4,// = 4,
            Group5,// = 4,
        }
        //时间到点事件

        /// <summary>
        /// For Dispose
        /// </summary>
        public void Dispose()
        {
        }

        //#region overwriter method

        //protected override bool CheckNeededParam(Dictionary<string, string> dict)
        //{
        //    return true;
        //}

        //#endregion overwriter method
    }

    #region class TimesUpEventArgs

    /// <summary>
    /// 时间到点时间参数
    /// </summary>
    public class TimesUpEventArgs : EventArgs
    {
        private readonly int _CurrentGroup;//到点的当前时间(或者分组依据)

        /// <summary>
        /// Constructor构造函数
        /// </summary>
        /// <param name="sCurrentTime">到点的当前时间(或者分组依据)</param>
        public TimesUpEventArgs(int iCurrentFreshGroups)
        {
            _CurrentGroup = iCurrentFreshGroups;
        }

        public int CurrentGroup
        {
            get
            {
                return _CurrentGroup;
            }
        }

        public override string ToString()
        {
            return "Group" + CurrentGroup + " refreshed!!";
        }
    }

    #endregion class TimesUpEventArgs

    internal class MainClass
    {
        private static void Main(string[] args)
        {

            ////线程A
            //Thread ThreadA = new Thread(delegate ()
            //{
            //    Console.WriteLine("辅助线程开始A...");
            //    coConTimer = new CoConTimer();
            //    Console.WriteLine("辅助线程结束A.");
            //});

            ////线程B
            //Thread ThreadB = new Thread(delegate ()
            //{
            //    Console.WriteLine("辅助线程开始B...");
            //    new SQLItem(coConTimer);
            //    Console.WriteLine("辅助线程结束B.");
            //});
            ////启动线程
            //ThreadA.Start();
            //ThreadB.Start();
            new SQLItem(new CoConTimer());
            Thread.Sleep(500*1000);
        }

        //private static CoConTimer coConTimer;
    }
    public class SQLItem
    {
        public SQLItem(CoConTimer coConTimer)// 构造函数,老鼠的名字,发出叫声的猫
        {
            if (coConTimer != null)
            {
                coConTimer.TimesUpEvent += fresh;//订阅猫叫事件
            }
        }

        private void fresh(object sender, TimesUpEventArgs args)// 猫叫事件处理,
        {
            if (args.CurrentGroup == 3)
            {
                string sID = DateTime.Now.ToString();
                Console.WriteLine(sID + ":Group3 start refresh");
                Thread.Sleep(15*1000);
                Console.WriteLine(sID + ":Group3 refresh finish!");
            }
        }
    }







}

//using System;

//namespace JsonDynamic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("请输入一个0-3的数字...");
//            //Console.ReadKey();
//            var input = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("数字{0}对应的枚举Name值:{1}", input, Enum.GetName(typeof(SocialType), input));
//            Console.ReadKey();
//        }
//    }

//    enum SocialType : int
//    {
//        Facebook,
//        Twitter,
//        GooglePlus,
//        Other
//    }
//}