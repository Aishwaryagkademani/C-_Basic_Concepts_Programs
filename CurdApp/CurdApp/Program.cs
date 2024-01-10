using System;
using System.Data.SqlClient ;
namespace CurdApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlconnection;
            string connectionString = @"Data Source=DESKTOP-R2SN2OB\SQLEXPRESS;Initial Catalog=CoDb;Integrated Security=True";

            try
            {
                sqlconnection = new SqlConnection(connectionString);
                //Console.WriteLine("connection established successfully");
                Console.WriteLine();
                do
                {
                    sqlconnection.Open();

                    Console.WriteLine("choose the operation\n1.Insert data\n2.Display data\n3.Update data\n4.Delete data");
                    int choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            //create => c
                            //Console.WriteLine("enter user id");
                            //string userid=Console.ReadLine();
                            Console.WriteLine("enter user name");
                            string username = Console.ReadLine();
                            Console.WriteLine("enter age of user");
                            int age = int.Parse(Console.ReadLine());

                            string insertQuery = "insert into details values('" + username + "','" + age + "')";
                            SqlCommand insertcommand = new SqlCommand(insertQuery, sqlconnection);
                            insertcommand.ExecuteNonQuery();
                            Console.WriteLine("data inserted sucdessfully");
                            break;

                        case 2://read => r                         
                            string displayquery = "select * from details";
                            SqlCommand dispalycommand = new SqlCommand(displayquery, sqlconnection);
                            SqlDataReader reader = dispalycommand.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine("id: " + reader.GetValue(0) + " " + "user name: " + reader.GetValue(1) + " " + "age: " + reader.GetValue(2));
                            }
                            break;

                        case 3:
                            int uid, uage;
                            Console.WriteLine("Enter the user id for updating");
                            uid = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter the user age for updating");
                            uage = int.Parse(Console.ReadLine());
                            string updatequery = "update details set user_age=" + uage + "where user_id=" + uid;
                            SqlCommand updatecommand = new SqlCommand(updatequery, sqlconnection);
                            updatecommand.ExecuteNonQuery();
                            Console.WriteLine("data updated");
                            break;

                        case 4:
                            int us_id;
                            Console.WriteLine("Enter the user id whose record that is to be deleted");
                            us_id = int.Parse(Console.ReadLine());
                            string deletequery = "delete from details where user_id=" + us_id;
                            SqlCommand deletecommand = new SqlCommand(deletequery, sqlconnection);
                            deletecommand.ExecuteNonQuery();
                            Console.WriteLine("Data deleted successfully");
                            break;

                        default:
                            Console.WriteLine("Enter the correct value");
                            break;

                    }
                    sqlconnection.Close();
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
