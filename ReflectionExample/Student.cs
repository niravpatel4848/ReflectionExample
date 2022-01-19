using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public void GetId()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }
        public void GetName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
