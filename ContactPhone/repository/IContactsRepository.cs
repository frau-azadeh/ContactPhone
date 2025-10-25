using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ContactPhone
{
    interface IContactsRepository
    {
        bool Insert(string firstName, string lastName, string address, string mobile, string telephon);
        bool Update(int contactId, string firstName, string lastName, string address, string mobile, string telephon);
        bool Delete(int contactId);
        DataTable SelectAll();
        DataTable SelectRow(int contactId);

       
    }
}
