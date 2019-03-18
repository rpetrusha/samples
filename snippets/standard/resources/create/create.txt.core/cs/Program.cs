using System;
using System.IO;
using System.Reflection;
using System.Resources;

namespace ResourceExamples
{
    public class Example
    {
        public static void Main()
        {
//            var di = new DirectoryInfo(Directory.GetCurrentDirectory());
Console.WriteLine(typeof(Example).Assembly.GetName().Name);

            var resName = $"{typeof(Example).Assembly.GetName().Name}.GreetingResources";
            ResourceManager rm = new ResourceManager(resName, 
                                    typeof(Example).Assembly);
            Console.Write(rm.GetString("prompt"));
            string name = Console.ReadLine();
            Console.WriteLine(rm.GetString("greeting"), name);                                                                          
        }
    }
}
// The example displays output like the following:
//       Enter your name: Wilberforce
//       Hello, Wilberforce!