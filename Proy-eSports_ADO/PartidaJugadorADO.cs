using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proy_eSports_ADO
{
    public class PartidaJugadorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public DataTable ListarHeroeRol(String idheroe, String roljugador)
        {
            try
            {
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter;

                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListarHeroeRol";

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@nomHero", idheroe);
                command.Parameters.AddWithValue("@roljugador", roljugador);

                sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataSet, "DETALLE_JUGADOR_PARTIDA");
                return dataSet.Tables["DETALLE_JUGADOR_PARTIDA"];
                
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
