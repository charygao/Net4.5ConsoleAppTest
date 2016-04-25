using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
class test
{
    public void Method()//1
    {
        Console.WriteLine("1:__" + "Method调用成功！");
    }
    public void Method(string str)//2
    {
        Console.WriteLine("2:__" + str);
    }

    public string Method(string str1, string str2)//3
    {
        string className1 = this.GetType().FullName;//非静态方法中获取类名
        string className2 = MethodBase.GetCurrentMethod().ReflectedType.FullName;//静态方法中的获取类名
        Console.WriteLine("3:__;类名"+className1+"_"+ className2);
        return "3:__" + str1 + str2;
    }
}
class Program
{
    public static void run(string testcase)
    {
        string strClass = "test";  //命名空间+类名
        string strMethod = "Method";//方法名

        Type type;
        object obj;

        type = Type.GetType(strClass);//通过string类型的strClass获得同名类“type”
        obj = System.Activator.CreateInstance(type);//创建type类的实例 "obj"

        MethodInfo method = type.GetMethod(strMethod, new Type[] { });//取的方法描述//通过string类型的strMethod获得同名的方法“method”//1
        method.Invoke(obj, null);//type类实例obj,调用方法"method"//1

        method = type.GetMethod(strMethod, new Type[] { typeof(String) });//取的方法描述//2
        object[] objs = new object[] { testcase };
        method.Invoke(obj, objs);//t类实例obj,调用方法"method(testcase)"//2

        method = type.GetMethod(strMethod, new Type[] { typeof(String), typeof(String) });//取的方法描述//2
        var result = (string)method.Invoke(obj, new object[] { "a", "b" });//3
        Console.WriteLine(result);//3

        //string className = this.GetType().FullName;
        string className = MethodBase.GetCurrentMethod().ReflectedType.FullName;//静态方法中的获取类名
        Console.WriteLine(className);
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        string testcase = "测试呀";//自己定义的类
        run(testcase);
    }
}
