using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Domain.Entities
{
    public class AccountRepository 
    {
        private readonly string _connection;
        public AccountRepository(string connection)
        {
            this._connection = connection;
        }
        public Account GetAccount(int Id)
        {
            string query = "";
            SqlConnection connection = null;
            SqlCommand command = null;
            Account account = null;
            SqlDataReader sqlDataReader = null;

            try
            {
                using (connection = new SqlConnection(this._connection))
                {
                    command = new SqlCommand(query, connection);

                    sqlDataReader = command.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Read();

                        account = Account.Create(sqlDataReader.GetGuid(0), sqlDataReader.GetDecimal(1),
                            sqlDataReader.GetGuid(2), sqlDataReader.GetDateTime(3));

                        return account;
                    }

                }
            }
            catch (Exception)
            {

                
            }
            return account;
        }
    }
}
