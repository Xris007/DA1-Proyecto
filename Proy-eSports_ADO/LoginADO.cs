using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Proy_eSports_BE;
using System.Data;

namespace Proy_eSports_ADO
{
    public class LoginADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        //SqlDataReader dataReader;
        SqlDataAdapter dataAdapter;

        public DataTable D_login(String user1, String pass)
        {
            

            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_Usuario";

                command.Parameters.AddWithValue("@user", user1);
                command.Parameters.AddWithValue("@pass", pass);



                SqlDataAdapter sqlDataAdapter;
                sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
                //sqlDataAdapter.Fill(dataSet, "Usuario");
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
