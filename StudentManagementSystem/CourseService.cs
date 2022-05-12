using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class CourseService
    {
        
        ConnectionFactory connection=new ConnectionFactory();
       
        
        public void AddCourse(Course c)
        {
            c.getCourseDetails();
            
            using (SqlCommand command=new SqlCommand("AddCourse",connection.MydbConnection()))
         
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseCode", c.CourseCode));
                command.Parameters.Add(new SqlParameter("@CourseTitle", c.CourseTitle));

                command.Parameters.Add(new SqlParameter("@CourseDescription", c.CourseDescription));
                command.Parameters.Add(new SqlParameter("@Course_id", c.CourseId));

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

        public void UpdateCourse(Course c)
        {
            c.getCourseDetails();

            string connectionStrig = @"Data Source=WAIDESK01\MSSQLSERVER01;Initial Catalog=Bk1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionStrig))
           
            {

                connection.Open();

                SqlCommand command = new SqlCommand("UpdateCourse", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CourseCode", c.CourseCode));
                command.Parameters.Add(new SqlParameter("@CourseTitle", c.CourseTitle));

                command.Parameters.Add(new SqlParameter("@CourseDescription", c.CourseDescription));
                command.Parameters.Add(new SqlParameter("@Course_id", c.CourseId));

                int updatecount=command.ExecuteNonQuery();
                Console.WriteLine(updatecount+"records updated");

               if(updatecount==0)
                {
                    Console.WriteLine("invalid Course_id");
                }

            }

        }

        public void DeleteCourse(Course c)
        {

            Console.WriteLine("ENTER COURSE ID");
            c.CourseId = int.Parse(Console.ReadLine());

            using (SqlCommand command = new SqlCommand("[course].DeleteCourse", connection.MydbConnection()))
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Course_id", c.CourseId));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                    }
                }

                int updatecount = command.ExecuteNonQuery();
                Console.WriteLine(updatecount + "records updated");

            }

        }

        public void CourseWiseAverageMark()
        {
            using (SqlCommand command = new SqlCommand("[CourseWiseAvgMark]", connection.MydbConnection()))
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                    }
                }

            }
        }

        public void DisplayCourseWiseTopper()
        {
            using (SqlCommand command = new SqlCommand("[CourseWiseTopper]", connection.MydbConnection()))
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
                    }
                }

            }

        }

        public void DisplayCourseWiseMaxMarks()
        {
            using (SqlCommand command = new SqlCommand("[MaxMarks]", connection.MydbConnection()))
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;

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
}
