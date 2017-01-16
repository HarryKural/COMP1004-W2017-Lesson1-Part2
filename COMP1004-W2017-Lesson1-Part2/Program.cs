using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1004_W2017_Lesson1_Part2
{
    


    /// <summary>
    /// Driver class for our console application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person Tom = new Person("Tom", 30);
            Tom.SaysHello();

            Console.WriteLine();

            Person Jane = new Person("Jane", 26);
            Jane.SaysHello();
        }
    }
}
