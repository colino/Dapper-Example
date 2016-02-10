using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace DapperExample
{
    public class ContactRepository : IContactRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServerConnString"].ConnectionString);

        public List<Contact> GetAll()
        {
            return this.db.Query<Contact>("SELECT * FROM dapper_example").ToList();
        }
    }
}
