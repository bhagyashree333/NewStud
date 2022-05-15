using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem;

public  class Course
{
    public string CourseCode;
    public string CourseTitle;
    public string CourseDescription;
    public int CourseId;


    public void getCourseDetails()
    {
        //Console.WriteLine("ENTER COURSE ID");
        //CourseId = int.Parse(Console.ReadLine());

        Console.WriteLine("|==========================================================================|");
        Console.WriteLine("ENTER COURSE CODE");
        CourseCode = Console.ReadLine();

        Console.WriteLine("ENTER COURSE TITLE");
        CourseTitle = Console.ReadLine();

        Console.WriteLine(" ENTER COURSE DESCRIPTION ");
        CourseDescription = Console.ReadLine();



        Console.WriteLine("|==========================================================================|");

    }
}
