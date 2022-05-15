using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem;


internal class StudentService
{
    ConnectionFactory MyDbcon = new ConnectionFactory();

    public void AddStudent(Student s)
    {
        
        s.getStudentDetails();
        using (SqlCommand command = new SqlCommand("AddStudent", MyDbcon.MydbConnection()))
        {

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@RollNo", s.Rollno));
            command.Parameters.Add(new SqlParameter("@StudentName", s.StudentName));
            command.Parameters.Add(new SqlParameter("@StudentEmail", s.StudentEmail));
            command.Parameters.Add(new SqlParameter("@StudentAddress", s.StudentAddress));
            command.Parameters.Add(new SqlParameter("@CourseId", s.CourseId));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                }
            }
            

        }

    }


    public void UpdateStudent(Student s)
    {
        s.getStudentDetails();
        using (SqlCommand command = new SqlCommand("UpdateStudent", MyDbcon.MydbConnection()))
        {

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@RollNo", s.Rollno));
            command.Parameters.Add(new SqlParameter("@StudentName", s.StudentName));
            command.Parameters.Add(new SqlParameter("@StudentEmail", s.StudentEmail));
            command.Parameters.Add(new SqlParameter("@StudentAddress", s.StudentAddress));
            command.Parameters.Add(new SqlParameter("@CourseId", s.CourseId));

            int updatecount = command.ExecuteNonQuery();
            Console.WriteLine(updatecount + "records updated");

            if (updatecount == 0)
            {
                Console.WriteLine("invalid Student_id");
            }

        }

    }

    public void DeleteStudent(Student s)
    {
        Console.WriteLine("Enter Roll Number");
       s.Rollno = int.Parse(Console.ReadLine());

        using (SqlCommand command = new SqlCommand("[student].DeleteStudent", MyDbcon.MydbConnection()))
        {

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@RollNo", s.Rollno));

            int updatecount = command.ExecuteNonQuery();
            Console.WriteLine(updatecount + "records updated");

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + "|       " + reader[1].ToString());
                }
            }


        }

    }
    //ListAllDetails
    public void DisplayStudentReport()
    {
        using (SqlCommand command = new SqlCommand("[ListAllDetails]", MyDbcon.MydbConnection()))
        {

            command.CommandType = System.Data.CommandType.StoredProcedure;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + "|     " + reader[1].ToString()+" |       "+reader[2].ToString() + "|     " + reader[3].ToString());
                }
            }


        }

    }

}

