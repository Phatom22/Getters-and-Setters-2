using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_Setters_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("jeff", 23, "mtt");
            Console.WriteLine(student1.gender);
            Console.ReadLine();
        }
    }
}
