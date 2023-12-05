using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void sayHi()
            {
                Console.WriteLine("Hi");
            }

            void sayHiUser(string name)
            {
                Console.WriteLine("Hello " + name);
            }

            void sayHiAge(string name, int age)
            {
                Console.WriteLine("Hello " + name + " you are " + age);
            }

            sayHi();
            sayHiAge("John", 55);
            sayHiUser("Evans");
        }
    }
}
