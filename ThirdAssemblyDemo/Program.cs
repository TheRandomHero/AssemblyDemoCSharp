using System;
using System.Reflection;


namespace ThirdAssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Windows\Microsoft.NET\Framework64\v4.0.30319\System.ServiceProcess.dll";

            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public  | BindingFlags.Instance;

            Assembly processAssembly = Assembly.LoadFrom(path);
            Console.WriteLine(processAssembly.FullName);

            Type[] types = processAssembly.GetTypes();

            foreach(Type t in types)
            {
                Console.WriteLine("type name : {0}", t.Name);
                MemberInfo[] memberInfos = t.GetMembers(flags);

                foreach(var member in memberInfos)
                {
                    Console.WriteLine("Memebername :{0} memeberType: {1}", member.Name, member.MemberType);
                }
            }

            Console.Read();
        }
    }
}
