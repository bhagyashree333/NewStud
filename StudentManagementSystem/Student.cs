using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem;

public  class Student
{
    public int Rollno;
    public string StudentName;
    public string StudentEmail;
    public string StudentAddress;
    public  int CourseId;

    public void getStudentDetails()
    {
        Console.WriteLine("|==========================================================================|");

        Console.WriteLine("Enter Roll Number");
        Rollno = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Student Name");
        StudentName = Console.ReadLine();

        Console.WriteLine("Enter Student Email");
        StudentEmail = Console.ReadLine();

        Console.WriteLine(" Enter Student Address ");
        StudentAddress = Console.ReadLine();

        Console.WriteLine("Enter Course id");
        CourseId = int.Parse(Console.ReadLine());

        Console.WriteLine("|==========================================================================|");


    }

}
