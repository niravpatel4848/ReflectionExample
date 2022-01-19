using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("ReflectionExample.Student");

            Console.WriteLine("Class Name = {0}", T.Name);
            Console.WriteLine("Namespace = {0}", T.Namespace);
            Console.WriteLine();

            Console.WriteLine("Methods in Student Class");

            MethodInfo[] methods = T.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name + " and it's return type is: " + method.ReturnType.Name );
            }

            Console.WriteLine();


            Console.WriteLine("Properties in Student Class");

            PropertyInfo[] properties = T.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name + " and it's type is: " + property.PropertyType.Name);
            }
            
            Console.ReadKey();
        }
    }
}
