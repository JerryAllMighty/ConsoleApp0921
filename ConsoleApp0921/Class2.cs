using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Class2
    {

        static int Divide(int x, int y, out int mod)
        {
            mod = x % y;
            return x / y;
            
        }

        static void Main()
        {
            int x = 10;
            int y = 4;
            int mod ;


            int result = Divide(x, y, out mod);      //out으로 값에 영향을 주는 것을 지정해주고, 리턴으로 다른 값을 전달해주는 것도 가능하다

            Console.WriteLine($" 몫 : {Divide(x, y, out mod)}, 나머지 : {mod}") ; 
        }
    }
}
