using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    
    class swap
    {
        static void Swap(out int a, out int b)      //아웃과 레프는 똑같은 데이터 타입으로 취급한다
        {                                           //레프는 무조건 값을 주고 시작해야한다. 아웃과의 차이점이다 //호출하던 안 하던 값을 줬던 안 줬든 아웃 메서드 정의 안 쪽에서 다시 값을 주고 시작한다
            a = 3;
            b = 5;
                                                    //메서드 호출시 : 값 - call by value; 
                                                                    //참조주소값 - call by reference

            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine($"x = {a}, y = {b}");

        }

        //static void Swap(ref int a, ref int b)
        //{
        //    int temp = b;
        //    b = a;
        //    a = temp;

        //    Console.WriteLine($"x = {a}, y = {b}");

        //}


        static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine($"x = {a}, y = {b}");
              
        }

        static void Main()
        {
            int x = 3;
            int y = 5;


            Console.WriteLine($"x = {x}, y = {y}");

            Swap(x,y);

            Console.WriteLine($"x = {x}, y = {y}");

            //Swap(ref x,ref y);

            //Console.WriteLine($"x = {x}, y = {y}");

            Swap(out x, out y);

            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
