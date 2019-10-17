using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Proy_eSports_BE;


namespace Proy_eSports_ADO
{
    public class TeamADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public Boolean InsertTeam(TeamBE objTeamBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertarEquipo";

            command.Parameters.AddWithValue("@NomEquipo", objTeamBE.NomEquipo);
            command.Parameters.AddWithValue("@PaisEquipo", objTeamBE.PaisEquipo);
            try
            {
                connection.Open();
                command.ExecuteNonQuery(); 
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                command.Parameters.Clear();
            }
        }

        public Boolean UpdateTeam(TeamBE objTeamBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ActualizarEquipo";

            command.Parameters.AddWithValue("@IdEquipo", objTeamBE.IdEquipo);
            command.Parameters.AddWithValue("@NomEquipo", objTeamBE.NomEquipo);
            command.Parameters.AddWithValue("@PaisEquipo", objTeamBE.PaisEquipo);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                command.Parameters.Clear();
            }
        }

        public Boolean DeleteTeam(String TeamId)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "EliminarEquipo";

            command.Parameters.AddWithValue("@IdEquipo", TeamId);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                command.Parameters.Clear();
            }
        }

        public TeamBE ConsultTeam(String TeamId)
        {
            TeamBE objTeamBE = new TeamBE();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ConsultarEquipo";

                command.Parameters.AddWithValue("@IdEquipo", TeamId);

                connection.Open();
                dataReader = command.ExecuteReader(); 

                if (dataReader.HasRows)
                {
                    dataReader.Read();

                    objTeamBE.IdEquipo = Convert.ToInt32(dataReader["IdEquipo"]);
                    objTeamBE.NomEquipo = dataReader["NomEquipo"].ToString();
                    objTeamBE.PaisEquipo = dataReader["PaisEquipo"].ToString();
                }
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                command.Parameters.Clear();
            }
            return objTeamBE;
        }
        public DataTable ListTeams()
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ListarEquipo";

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(command);

                adapter.Fill(dataSet, "Equipo");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dataSet.Tables["Equipo"];
        }
    }
}
