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
            throw new NotImplementedException();
        }

        public bool Insert(string firstName, string lastName, string address, string mobile, string telephon)
        {
            throw new NotImplementedException();
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
