using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{

    public class Time
    {
        int hours;
        int minutes;


        public Time(int minutes) : this(0, minutes) { }

        public Time(int hours, int minutes)
        {
            this.hours = hours;     //이럴 떄는 this를 꼭 붙여주어야한다. 구분을 해주어야하기때문에
            this.minutes = minutes;
            Examine();

        }

        private void Examine()
        {
            if (hours < 0 || minutes < 0)
            {
                Console.WriteLine("올바르지 않은 입력값입니다.");
                return;
            }

            hours = hours + (minutes / 60);
            minutes = minutes % 60;
        }

        //public void PrintTime()
        //{
        //    Console.WriteLine($"{hours} : {minutes}");
        //}

        public override string ToString()
        {
            return this.hours + ":" + this.minutes;
        }

        public override bool Equals(object obj)
        {

            return obj is Time time &&
                hours == time.hours &&
                minutes == time.minutes;
        }
        private int TotalMinute()
        {
            return this.hours * 60 + minutes;
        }

        public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1.TotalMinute() + t1.TotalMinute());
        }

        public static Time operator ++ (Time t1)
        {
            return new Time(t1.TotalMinute() + 1);
        }

        public static bool operator > (Time t1, Time t2)
        {
            return t1.TotalMinute() > t2.TotalMinute();
        }

        public static bool operator <(Time t1, Time t2)
        {
            return t1.TotalMinute() < t2.TotalMinute();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(1, 40);
            //t1.PrintTime();
            Console.WriteLine(t1.ToString());

            Time t2 = new Time(1, 20);
            //t1.PrintTime();
            Console.WriteLine(t1.Equals(t2));


            Time t3 = t1 + t2;
            Console.WriteLine(t3);


            t1++;

            Console.WriteLine(t1.ToString());

            Console.WriteLine(t1 < t2 ); 
        }

        
    }
}
