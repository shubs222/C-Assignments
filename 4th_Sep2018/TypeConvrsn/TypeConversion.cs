//Write a program using a switch statement that takes one value from the user and asks about the type of conversion 
//and then performs a conversion depending on the type of conversion.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLeapYear
{
    class TypeConversion
    {
        
        void TypeConv()
        {
            int opt;
            string str;
            Console.WriteLine("Enter your value");
            str=Console.ReadLine();
            //Console.WriteLine("\n1.short\n2.int\n3.long\n.4.float\n5.exit\n Enter your choice" );
            //opt = Convert.ToInt32(Console.ReadLine());

            //num = Console.ReadLine();
            Console.WriteLine("\nIn which Data type you want to convert your input in: \n1.Int \n2.float\n3.char\n4.double\nEnter your choice");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    {
                        float n = 0;
                        bool tryp = float.TryParse(str, out n);
                        Console.WriteLine("before convert :" + str);
                        if (tryp)
                        {
                            Console.WriteLine("value is converted into int : " + (int)n);
                        }
                        else
                        {
                            Console.WriteLine("Conversion is not possible");
                        }

                        break;
                    }
                case 2:
                    {
                        float no = 0;
                        bool tryp = float.TryParse(str, out no);
                        if (tryp)
                        {
                            Console.WriteLine("Value is converted into float : "+(float)no);
                        }
                        else
                        {
                            Console.WriteLine("Conversion not possible");
                        }
                    break;
                    }
                case 3:
                    {
                       int no = 0;
                        bool tryp = int.TryParse(str, out no);
                        if (tryp)
                        {
                            Console.WriteLine("Value is converted into char : " + (char)no);
                        }
                        else
                        {
                            Console.WriteLine("Conversion not possible");
                        }
                        break;
                    }
                case 4:
                    {
                        double no = 0;
                        bool tryp = double.TryParse(str, out no);
                        if (tryp)
                        {
                            Console.WriteLine("Value is converted into double : " + (double)no);
                        }
                        else
                        {
                            Console.WriteLine("Conversion not possible");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }
            
        }
    
    static void Main(string[] args)
    {
            TypeConversion tc = new TypeConversion();
            tc.TypeConv();
            Console.ReadKey();
            long dm = 1111111111111111;
            int myIntValue = unchecked((int)dm);
            Console.WriteLine("long to int : " + myIntValue);
    }
   }
}
