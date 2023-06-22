using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(ReflectionOrnek);


            // Özelliklerin Bilgilerini alıyoruz

            PropertyInfo[] properties = type.GetProperties(); 
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("Property: " + property.Name);
            }

            // Metodların Bilgilerini Alıyoruz

            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Method: " +  method.Name);
            }

            Console.ReadLine();
        }
    }
}
