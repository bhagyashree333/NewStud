using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem;

public class Marks
{
    public int Studentid;
    public int marks;
    public int mark_id;
    public int Sub_id;

    public void getMarkDetails()
    {
        Console.WriteLine("|==========================================================================|");
        Console.WriteLine("ENTER STUDENT ID/roll no");
        Studentid = int.Parse(Console.ReadLine());

        Console.WriteLine("ENTER SUBJECT ID");
        Sub_id = int.Parse(Console.ReadLine());

        Console.WriteLine(" ENTER MARKS ");
        marks = int.Parse(Console.ReadLine());

        Console.WriteLine("ENTER MARKS ID");
        mark_id = int.Parse(Console.ReadLine());

        Console.WriteLine("|==========================================================================|");


    }

}
