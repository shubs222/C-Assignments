using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuvateSchool
{
    public class Program
    {
        string fname;
        string lname;
        int grade;
        string sub;
        //public  void GetData()
        //{
        //    Console.WriteLine("Enter fisrt name of student");
        //    fname = Console.ReadLine();
        //    Console.WriteLine("Enter fisrt last of student");
        //    lname = Console.ReadLine();
        //    Console.WriteLine("Enter grade of student");
        //    grade = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter rool number name of student");
        //    rollno = Convert.ToInt32(Console.ReadLine());
        //}
        static void Main(string[] args)
        {
            Program[] pg = new Program[1000];

            int[] gradearr = new int[12];
            int opt = 0;
            Console.WriteLine(" Add Data");


            for (int i = 0; i <= pg.Length; i++)
            {

                //if (opt == 1)
                //{
                pg[i] = new Program();
                Console.WriteLine("Enter fisrt name of student");
                pg[i].fname = Console.ReadLine();
                Console.WriteLine("Enter  last name of student");
                pg[i].lname = Console.ReadLine();
                Console.WriteLine("Enter grade of student");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= 1 && num <= 12)
                {
                    pg[i].grade = num;
                    if (gradearr[pg[i].grade - 1] < 22)
                    {
                        gradearr[pg[i].grade - 1]++;
                    }
                }
                else
                {
                    Console.WriteLine("Enter grade between 1 and 12");
                }


                Console.WriteLine("Add more data \n1.Yes\n0.exit");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    continue;
                }
                else if (opt == 0)
                {
                    Console.WriteLine("  1.get count\n2.Exit");
                    int opt1 = Convert.ToInt32(Console.ReadLine());
                    
                    if (opt1 == 1)
                    {
                        for (int j = 0; j < gradearr.Length; j++)
                        {
                            Console.WriteLine("{0} grade value is {1}", j + 1, gradearr[j]);
                        }
                        break;
                    }
                    else
                    {
                        return;
                    }

                    

                }


            }
            Console.ReadKey();
        }
    }
}