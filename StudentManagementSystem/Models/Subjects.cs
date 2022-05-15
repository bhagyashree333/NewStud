using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Subjects
    {
        public string SubCode;
        public string SubjectTitle;
        public string SubjectDescription;
        public int CourseId;
        public int Sub_id;


        public void getSubjectDetails()
        {
            Console.WriteLine("|==========================================================================|");
            Console.WriteLine("ENTER SUBJECT CODE");
            SubCode = Console.ReadLine();

            Console.WriteLine("ENTER SUBJECT TITLE");
            SubjectTitle = Console.ReadLine();

            Console.WriteLine(" ENTER SUBJECT DESCRIPTION ");
            SubjectDescription = Console.ReadLine();

            Console.WriteLine("ENTER COURSE ID");
            CourseId = int.Parse(Console.ReadLine());

            Console.WriteLine("ENETR SUBJECT ID");
            Sub_id = int.Parse(Console.ReadLine());

            Console.WriteLine("|==========================================================================|");
            // string connectionStrig = @"Data Source=WAIDESK01\MSSQLSERVER01;Initial Catalog=Bk1;Integrated Security=True";
        }
    }
}
