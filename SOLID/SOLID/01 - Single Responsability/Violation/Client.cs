using SOLID.Solution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Violation
{
    public class Client
    {
        #region ==== Props ====

        public int ClientId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public bool IsActive { get; set; }

        public int Age { get; set; } 

        public string Email { get; set; }
        #endregion

        #region ==== Methods ====
        public string AddClient()
        {
            #region [1] ============ [Check Valid User] ============
            if (!IsActive || Age < 18 || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Name))
            {
                return "Client Ivalid! ";
            }
            #endregion

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

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("surname", Surname);
                cmd.Parameters.AddWithValue("isActive", IsActive);
                cmd.Parameters.AddWithValue("age", Age);
                cmd.Parameters.AddWithValue("email", Email);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            #endregion

            #region [3] ============ [Notify new Client] ============
            var mailClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };
            var mailMessage = new MailMessage("subscribe@xpto.com", Email);
            mailMessage.Subject = $"Welcome {Name} {Surname} as our new client!";
            mailMessage.Body = "Now you can use our plataform and make ...";
            mailClient.Send(mailMessage);
            #endregion

            return "OK";
        }
        #endregion
    }
}