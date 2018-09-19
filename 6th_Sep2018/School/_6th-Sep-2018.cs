using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuvateSchool1.subjects
{
    class Subject
    {
        StudentDetails studentd;
        public string subject;
        public int highmarks;

    }
    class StudentDetails
    {
        int RollNo;
        string Name;
        int grade;
        int []marks=new int[6];
        float percent;
    }
    class Execute
    {
        public static void Main(String[] args)
        {
            Subject []subjectobj = new Subject[6];
            Console.WriteLine("Enter The Subject Name");
            for (int count = 0; count < subjectobj.Length; count++)
            {
                subjectobj[count] = new Subject();
                Console.WriteLine("Enter subject: " + (count+1));
                subjectobj[count].subject = Console.ReadLine();
            }
        }
    }
}
