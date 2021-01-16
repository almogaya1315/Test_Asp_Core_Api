using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Asp_Core_Api
{
    public class UserRepository
    {
        public string InsertUser(User user)
        {
            using (var con = OpenConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id", user.Id, DbType.Int32, ParameterDirection.Input);
                parameters.Add("Name", user.UserName, DbType.String, ParameterDirection.Input);
                parameters.Add("Pass", user.Password, DbType.String, ParameterDirection.Input);
                return con.QuerySingle<string>("", parameters, commandType: CommandType.StoredProcedure);
            }
        }


        private SqlConnection OpenConnection()
        {
            var connectionString = "";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
