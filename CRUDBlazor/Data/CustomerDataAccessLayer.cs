using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBlazor.Data
{
    public class CustomerDataAccessLayer
    {
        // string connectionString = "Put Your Connection string here";
        string connectionString = "Data Source=192.168.1.67,5810;Initial Catalog=Customers;Integrated Security=True";
        //To View all Customers details    
        public IEnumerable<CustomerInfo> GetAllCustomers()
        {
            List<CustomerInfo> lstCustomer = new List<CustomerInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_GetAllCustomers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    CustomerInfo Customer = new CustomerInfo();
                    Customer.CustomerId = Convert.ToInt32(rdr["CustomerID"]);
                    Customer.Name = rdr["Name"].ToString();
                    Customer.Gender = rdr["Gender"].ToString();
                    Customer.Country = rdr["Country"].ToString();
                    Customer.City = rdr["City"].ToString();
                    lstCustomer.Add(Customer);
                }
                con.Close();
            }
            return lstCustomer;
        }
        //To Add new Customer record    
        public void AddCustomer(CustomerInfo Customer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_AddCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
                cmd.Parameters.AddWithValue("@Country", Customer.Country);
                cmd.Parameters.AddWithValue("@City", Customer.City);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Update the records of a particluar Customer  
        public void UpdateCustomer(CustomerInfo Customer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_UpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerId", Customer.CustomerId);
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
                cmd.Parameters.AddWithValue("@Country", Customer.Country);
                cmd.Parameters.AddWithValue("@City", Customer.City);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Get the details of a particular Customer  
        public CustomerInfo GetCustomerData(int? id)
        {
            CustomerInfo Customer = new CustomerInfo();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("usp_GetCustomerByID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerId", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Customer.CustomerId = Convert.ToInt32(rdr["CustomerID"]);
                    Customer.Name = rdr["Name"].ToString();
                    Customer.Gender = rdr["Gender"].ToString();
                    Customer.Country = rdr["Country"].ToString();
                    Customer.City = rdr["City"].ToString();
                }
            }
            return Customer;
        }
        //To Delete the record on a particular Customer  
        public void DeleteCustomer(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_DeleteCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
