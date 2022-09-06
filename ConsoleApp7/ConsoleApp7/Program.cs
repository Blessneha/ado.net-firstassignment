using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp7
{
    internal class Program
    {
        public static void GetProductById(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-45DGQP0R\SQLEXPRESS;Initial Catalog=assign2;Integrated Security=True");
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select emp,emp_fna from Employee where emp=" + id, con);
                SqlDataReader dr = cmd.ExecuteReader(); //ExecureReader() method stores result set data into DataReader object
                if (dr.HasRows)
                {
                    dr.Read();


                    Console.WriteLine("Id:{0} Name:{1}", dr["emp"], dr["emp_fna"]);
                }
                else
                    Console.WriteLine("Invalid Id");


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();//close connection i.e disconnected from database
            }
        }

        public static void Workdetail()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-45DGQP0R\SQLEXPRESS;Initial Catalog=assign2;Integrated Security=True");
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select*from Works_on", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Console.WriteLine("Id:{0} projectno:{1} Job {2} Date {3}", dr["emp_no"], dr["project_no"], dr["Job"], dr["enter_date"]);

                }


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        static void Main(string[] args)
        {
          //  GetProductById(25348);
            Workdetail();
            Console.ReadKey();
        }
    }

    }

    

