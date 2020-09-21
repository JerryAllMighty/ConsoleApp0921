using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{

    class Point
    {
        public int x = 0;
        public int y = 0;
    }



    class Swap3
    {
        static void Swap(Point p1)
        {
            int temp = p1.y;
            p1.y = p1.x;
            p1.x = temp;
        }

        static void Main()
        {
            Point p1 = new Point();
            p1.x = 3;
            p1.y = 5;

            Console.WriteLine($"x = {p1.x}, y = {p1.y}");
            Swap(p1);


            Point p2 = new Point();                     //deep copy : 인스턴스 자체를 따로 만들어서 복사해서 넘기는 것
            p2.x = p1.x;
            p2.y = p1.y;
            Swap(p2);
            Console.WriteLine($"x = {p1.x}, y = {p1.y}");





        }
    }
}
