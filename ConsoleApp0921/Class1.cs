using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    abstract class Person
    {
        public void Speak()
        {
            Console.WriteLine("삐리리");
        }
        
        public void Work()
        {
            Console.WriteLine("일을 합니다");
        }

        public void Study()
        {
            Console.WriteLine("공부를 합니다");
        }
    }

    //class Employee : Person
    //{
    //    public override void Speak()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    class Class1
    {
        static void Main()
        {
            //Person p1 = new Person();
            
        }
    }
}
