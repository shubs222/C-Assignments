//Write a program using conditional operators to determine whether a year entered through the keyboard is a leap year or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLeapYear
{
    class Program
    {
        
        void IsLeap(int year)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine(year + " Is Leap year");
            }
            else
                Console.WriteLine(year + " Is not leap year");
        }
        static void Main(string[] args)
        {
            int uyear;
            int opt;
            Console.WriteLine("Enter any year to check weather it is leap year or not: ");
            uyear = Convert.ToInt32(Console.ReadLine());
            Program pg = new Program();
            pg.IsLeap(uyear);
            Console.WriteLine("Want To check More \n1.Yes\n2.No");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                        Main(args);
                        break;
                default : return;
                            
            }
            
        }
    }
}
