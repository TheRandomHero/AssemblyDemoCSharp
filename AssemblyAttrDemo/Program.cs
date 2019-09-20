using System;
using System.Reflection;

namespace AssemblyAttrDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type descrioptionType = typeof(AssemblyDescriptionAttribute);

            object[] attributes = currentAssembly.GetCustomAttributes(descrioptionType, false);

            if (attributes.Length > 0)
            {
                AssemblyDescriptionAttribute newDescription = (AssemblyDescriptionAttribute)attributes[0];
                Console.WriteLine("Description: {0}", newDescription.Description);
            }
        }
    }
}
