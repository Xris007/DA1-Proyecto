using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proy_eSports_ADO
{
    public class JugadorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public DataTable ListarJugador()
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListarJugador";

                SqlDataAdapter sqlDataAdapter;
                sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataSet, "Jugador");


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dataSet.Tables["Jugador"];
        }
    }
}
