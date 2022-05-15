using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem;

public class ConnectionFactory
{
    public SqlConnection connection;
    public ConnectionFactory()
    {

    }
    public SqlConnection MydbConnection()
    {

        string connectionStrig = @"Data Source=DESKTOP-P2FMG09;Initial Catalog=Bk1;Integrated Security=True";
       connection = new SqlConnection(connectionStrig);

          connection.Open();
            return connection;
           connection.Close();
        

    }





}
