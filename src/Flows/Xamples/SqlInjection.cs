using System;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace FlowBlot.Flows.Xamlpes
{
    public class SqlInjection
    {
        [HttpGet]
        public IActionResult Search(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(""))
            {
                connection.Open();
                // Create a SqlCommand object and specify the SQL query that you want to execute.
                var sqlQuery = $"SELECT * FROM  Customers WHERE {keyword}";
                var command = new SqlCommand(sqlQuery, connection);
            }
            return null;
        } 
    }
}