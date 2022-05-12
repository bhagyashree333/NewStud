using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem;


internal class SubjectService
{
    ConnectionFactory connection = new ConnectionFactory();

    



   
    public void AddSubject(Subjects s)
    {
        s.getSubjectDetails();
        using (SqlCommand command = new SqlCommand("addSubject", connection.MydbConnection()))
        {

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@SubCode", s.SubCode));
            command.Parameters.Add(new SqlParameter("@SubTitle", s.SubjectTitle));

            command.Parameters.Add(new SqlParameter("@SubDescription", s.SubjectDescription));
            command.Parameters.Add(new SqlParameter("@Course_id", s.CourseId));
            command.Parameters.Add(new SqlParameter("@Sub_id", s.Sub_id));

            
           

        }

    }

    public void UpdateSubject(Subjects s)
    {
        s.getSubjectDetails();
        using (SqlCommand command = new SqlCommand("UpdateSubject", connection.MydbConnection()))
        {

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@SubCode", s.SubCode));
            command.Parameters.Add(new SqlParameter("@SubTitle", s.SubjectTitle));

            command.Parameters.Add(new SqlParameter("@SubDescription", s.SubjectDescription));
            command.Parameters.Add(new SqlParameter("@Course_id", s.CourseId));
            command.Parameters.Add(new SqlParameter("@Sub_id", s.Sub_id));

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                }
            }


        }


    }

    public void DeleteSubject(Subjects s)
    {
        Console.WriteLine("ENETR SUBJECT ID");
        s.Sub_id = int.Parse(Console.ReadLine());

        using (SqlCommand command = new SqlCommand("[course].DeleteSubject", connection.MydbConnection()))
        {

            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Sub_id", s.Sub_id));

            int updatecount = command.ExecuteNonQuery();
            Console.WriteLine(updatecount + "records updated");

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                }
            }


        }
    }
}

