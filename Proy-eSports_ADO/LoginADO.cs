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

        public DataTable D_login(Proy_eSports_BE.LoginBE obje)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "usp_login";

            command.Parameters.AddWithValue("@user",obje.userEsport);
            command.Parameters.AddWithValue("@pass", obje.password);

            

            DataTable dtable1 = new DataTable();
           
            dataAdapter = new SqlDataAdapter(command);

            dataAdapter.Fill(dtable1);
            return dtable1;

        }
    }
}
