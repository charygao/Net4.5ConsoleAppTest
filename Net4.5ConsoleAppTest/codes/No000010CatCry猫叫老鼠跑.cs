using System;
using System.Collections.Generic;
using System.Text;

namespace CatCry
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Cat");
            Mouse mouse = new Mouse("Mouse", cat);
            Man ren = new Man("Ren", cat);
            cat.CatM();
            Console.ReadLine();
        }
    }
    public class Cat
    {
        private string _name;//猫名
        public event EventHandler<CatMiaoEventArgs> CatMEvent;//猫叫事件
        public Cat(string name)// 构造函数,名字参数
        {
            _name = name;
        }
        public void CatM()// 促发猫叫的事件
        {
            CatMiaoEventArgs args = new CatMiaoEventArgs(_name);
            Console.WriteLine(args);//tostring方法
            CatMEvent(this, args);
        }
    }
    public class CatMiaoEventArgs : EventArgs// 猫叫事件参数
    {

        private string _catname;//发出叫声的猫的名字
        public CatMiaoEventArgs(string catname) : base()// 构造函数
        {
            _catname = catname;
        }
        public override string ToString()// 输出参数内容
        {
            return _catname + "叫";
        }

    }
    public class Mouse
    {
        private string _name;//老鼠名字
        public Mouse(string name, Cat cat)// 构造函数,老鼠的名字,发出叫声的猫
        {
            _name = name;
            cat.CatMEvent += CatMHandle;//订阅猫叫事件
        }
        private void CatMHandle(object sender, CatMiaoEventArgs args)// 猫叫事件处理,
        {
            Console.WriteLine(_name + "逃");// 逃跑方法
        }
    }
    public class Man
    {
        private string _name;//主人名字
        public Man(string name, Cat cat)// 构造函数，订阅事件,主人名字,猫
        {
            _name = name;
            cat.CatMEvent += CatCryHandler;//订阅猫叫事件
        }
        private void CatCryHandler(object sender, CatMiaoEventArgs args)//猫叫事件处理,,猫叫事件
        {
            Console.WriteLine(_name + "醒");// 主人醒了事件
        }
    }
}

