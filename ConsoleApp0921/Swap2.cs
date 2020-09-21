using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{



    // string  에 대한 예제이다
    class Swap2
    {
        static void Changeword(string arg)
        {
            arg = "World";
        }

        //static void Changeword(ref string arg)
        //{
        //    arg = "World";
        //}


        static void Main()
        {
            string str = "Hello";
            Changeword(str);
            Console.WriteLine(str);         //Hello

            //Changeword(ref str);
            //Console.WriteLine(str);         //World


        }
    }
}
