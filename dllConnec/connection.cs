using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace dllConnec
{
   public class Connection
    {
        public SqlConnection DBConnection;

        public Connection()
        {
            
        }

        public Connection(string _nameDB, string _userId, string _dataSource, string _password) 
        { 
        
                DBConnection = new SqlConnection();
                SqlConnectionStringBuilder stringBuilder;
                stringBuilder = new SqlConnectionStringBuilder();
                stringBuilder.IntegratedSecurity = false;
                stringBuilder.InitialCatalog = _nameDB;
                stringBuilder.UserID = _userId;
                stringBuilder.DataSource = _dataSource;
                stringBuilder.Password = _password;
                DBConnection.ConnectionString = (stringBuilder.ConnectionString);
        }

        public void Connect()
        {
            DBConnection.Open();
        }

        public SqlDataReader GetDataReader(string _commandText, List<string> _parameter, List<string> _value)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = DBConnection;
                command.CommandText = _commandText;
                if (_value == null)
                {
                    command.CommandType = CommandType.Text;
                    return command.ExecuteReader();
                }
                else
                {
                    command.Parameters.Clear();
                    command.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i < _parameter.Count; i++)
                    {
                        command.Parameters.Add(new SqlParameter(_parameter[i], _value[i]));
                    }
                    return command.ExecuteReader();
                }
            }
        }

    }
}
