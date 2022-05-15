using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class MarksService
    {
        ConnectionFactory connection = new ConnectionFactory();
       

       
        public void AddMark(Marks m)
        {
            m.getMarkDetails();
            using (SqlCommand command = new SqlCommand("[mark].AddMark", connection.MydbConnection()))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Studentid", m.Studentid));
                command.Parameters.Add(new SqlParameter("@Sub_id", m.Sub_id));

                command.Parameters.Add(new SqlParameter("@marks", m.marks));
                command.Parameters.Add(new SqlParameter("@mark_id",m.mark_id));


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

        public void UpdateMark(Marks m)
        {
            m.getMarkDetails();
            using (SqlCommand command = new SqlCommand("UpdateMarks", connection.MydbConnection()))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Studentid", m.Studentid));
                command.Parameters.Add(new SqlParameter("@Sub_id", m.Sub_id));

                command.Parameters.Add(new SqlParameter("@marks", m.marks));
                command.Parameters.Add(new SqlParameter("@mark_id", m.mark_id));

                int updatecount = command.ExecuteNonQuery();
                Console.WriteLine(updatecount + "records updated");

            }
        }

        public void DeleteMark(Marks m)
        {
            Console.WriteLine("ENTER MARKS ID");
            m.mark_id = int.Parse(Console.ReadLine());

            using (SqlCommand command = new SqlCommand("[mark].DeleteMark", connection.MydbConnection()))
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@mark_id", m.mark_id));

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

        public void DisplayMarksByRollNo(Marks m)
        {
            Console.WriteLine("ENTER STUDENT ROLL NO");
            m.Studentid = int.Parse(Console.ReadLine());

            using (SqlCommand command = new SqlCommand("RollnoWiseStudMark", connection.MydbConnection()))
            {

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@", m.mark_id));

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
}
