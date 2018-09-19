using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLeapYear
{
    class IdentityMatrix
    {
        void Matrix()
        {
            int n;
            Console.WriteLine("Enter size of two dimensional matrix");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            Console.WriteLine("your matrix is [" + n + "]*[" + n + "]");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\t");
                    if (i == j)
                    {
                        Console.Write(1);
                    }
                    else
                        Console.Write(0);
                }
            }

        }

        static void Main(string[] args)
        {
            IdentityMatrix obj = new IdentityMatrix();
            obj.Matrix();
            Console.ReadKey();
        }
    }
}
