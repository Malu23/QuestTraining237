using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Contacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new ContactManager();
            app.AddContact();
            app.GetAllContacts();
        }
    }
}
