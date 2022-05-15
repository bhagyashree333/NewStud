using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem;

public class Menu
{
    public static void Test()
    {
        Student stud=new Student();
        Course course = new Course();
        Subjects subject=new Subjects();
        Marks marks=new Marks();


        CourseService c1=new CourseService();
        StudentService s1=new StudentService();
        SubjectService sb1=new SubjectService();
        MarksService m1=new MarksService();

        
        Console.WriteLine("Menu");

        int ch;
        do
        {
            DisplayStart();
            Console.WriteLine("=======Menu=======");
            Console.WriteLine("1-Add Student");
            Console.WriteLine("2-Add course");
            Console.WriteLine("3-Add subject");
            Console.WriteLine("4-Enter marks of student");
            Console.WriteLine("5-Edit Student data\n");

            Console.WriteLine("6-Edit course");
            Console.WriteLine("7-Edit subject");
            Console.WriteLine("8-Delete Student");
            Console.WriteLine("9-Delete Subject\n");

            Console.WriteLine("10-Delete Course");
            Console.WriteLine("11-Delete marks");
            Console.WriteLine("12-List all students with details of course, subject, and total marks");
            Console.WriteLine("13-Ask roll number to display subject wise marks for a student\n");

            Console.WriteLine("14-List course wise average marks");
            Console.WriteLine("15-List course wise max marks");
            Console.WriteLine("16-List course wise topper");
            Console.WriteLine("18-Edit Marks(Teachers section)");

            Console.WriteLine("Enter Your Choice[1-20]");

            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 0:
                    {
                        Console.WriteLine("enter valid choice");
                        break;
                    }
                case 1:
                    {
                        s1.AddStudent(stud);
                        break;
                    }
                case 2:
                    {
                        c1.AddCourse(course);
                        break;
                    }

                case 3:
                    {
                        sb1.AddSubject(subject);
                        break;
                    }
                case 4:
                    {
                        m1.AddMark(marks);
                        break;
                    }
                case 5:
                    {
                      s1.UpdateStudent(stud);
                        break;
                    }
                case 6:
                    {
                       c1.UpdateCourse(course);
                        break;
                    }

                case 7:
                    {
                        sb1.UpdateSubject(subject);
                        break;
                    }
                case 8:
                    {
                        s1.DeleteStudent(stud);
                        break;
                    }
                case 9:
                    {
                       sb1.DeleteSubject(subject);
                        break;

                    }
                case 10:
                    {
                       c1.DeleteCourse(course);
                        break;
                    }

                case 11:
                    {
                       m1.DeleteMark(marks);
                        break;
                    }
                case 12:
                    {
                        s1.DisplayStudentReport();
                        break;
                    }
                case 13:
                    {
                        m1.DisplayMarksByRollNo(marks);
                        break;
                    }
                case 14:
                    {
                        c1.CourseWiseAverageMark();
                        break;
                    }

                case 15:
                    {
                       c1.DisplayCourseWiseMaxMarks();
                        break;
                    }
                case 16:
                    {
                        c1.DisplayCourseWiseTopper();
                        break;
                    }
                case 18:
                    {
                        m1.UpdateMark(marks);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid choice");
                        break;
                    }
            }
        } while (ch != 0);

    }
    private static void DisplayStart()
    {
        Console.WriteLine("**********************************************************************************************");
    }
}


