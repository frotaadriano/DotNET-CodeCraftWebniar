using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID._05___Dependency_Inversion_Principle.Violation
{
    public class ClientRepository
    {
        public void AddClient(Client client)
        {
            #region [2] ============ [Register client] ============
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " " +
                    " INSERT INTO CLIENT ( Name ,  Surname ,  IsActive , Age  , Email  ) " +
                    " VALUES             (@name , @surname , @isActive , @age , @email ) ) ";

                cmd.Parameters.AddWithValue("name", client.Name);
                cmd.Parameters.AddWithValue("surname", client.Surname);
                cmd.Parameters.AddWithValue("isActive", client.IsActive);
                cmd.Parameters.AddWithValue("age", client.Age);
                cmd.Parameters.AddWithValue("email", client.Email);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            #endregion
        }
    }
}
