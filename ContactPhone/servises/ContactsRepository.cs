using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ContactPhone 
{
    class ContactsRepository : IContactsRepository
    {
        private string connectionString = "Data Source=.; initial Catalog = telContact; Integrated Security=true";
        public bool Delete(int contactId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete from contact_number where contactId=@id";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@id", contactId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
           


            }
        }

        public bool Insert(string firstName, string lastName, string address, string mobile, string telephon)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                
                string query = "Insert into contact_number(firstName, lastName, address, telephon, mobile) values(@firstName,@lastName,@address,@telephon,@mobile)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName",firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@telephon", telephon);
                command.Parameters.AddWithValue("@mobile", mobile);
                connection.Open();
                command.ExecuteNonQuery();
                
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectAll()
        {
            string query = "select * from contact_number";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int contactId, string firstName, string lastName, string address, string mobile, string telephon)
        {
            throw new NotImplementedException();
        }
    }
}
