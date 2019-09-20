using System;
using System.Reflection;

namespace DynamicCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Windows\Microsoft.NET\Framework64\v4.0.30319\System.Web.dll";

            Assembly webAssembly = Assembly.LoadFile(path);

            Type utilType = webAssembly.GetType("System.Web.HttpUtility");

            MethodInfo enCodeInfo = utilType.GetMethod("HtmlEncode", new Type[] { typeof(string) });
            MethodInfo deCodeInfo = utilType.GetMethod("HtmlDecode", new Type[] { typeof(string) });

            string aString = "This is a chickhead <') ";

            Console.WriteLine(aString);

            string encode = (string)enCodeInfo.Invoke(null, new object[] { aString });

            Console.WriteLine(encode);

            string decode = (string)deCodeInfo.Invoke(null, new object[] { encode });

            Console.WriteLine(decode);
        }
    }
}
