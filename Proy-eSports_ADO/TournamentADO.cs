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
    public class TournamentADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public Boolean InsertTournament(TournamentBE objTournamentBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertarTorneo";

            command.Parameters.AddWithValue("@NomTorneo", objTournamentBE.NomTorneo);
            command.Parameters.AddWithValue("@OrgTorneo", objTournamentBE.OrgTorneo);
            command.Parameters.AddWithValue("@PaisTorneo", objTournamentBE.PaisTorneo);
            command.Parameters.AddWithValue("@LugarTorneo", objTournamentBE.LugarTorneo);
            command.Parameters.AddWithValue("@FechaInicioTorneo", objTournamentBE.FechaInicioTorneo);
            command.Parameters.AddWithValue("@FechaFinTorneo", objTournamentBE.FechaFinTorneo);
            command.Parameters.AddWithValue("@IdJuego", 1); //hasta desarrollar CRUD de juego

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
        public Boolean UpdateTournament(TournamentBE objTournamentBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ActualizarTorneo";

            command.Parameters.AddWithValue("@IdTorneo", objTournamentBE.IdTorneo);
            command.Parameters.AddWithValue("@NomTorneo", objTournamentBE.NomTorneo);
            command.Parameters.AddWithValue("@OrgTorneo", objTournamentBE.OrgTorneo);
            command.Parameters.AddWithValue("@PaisTorneo", objTournamentBE.PaisTorneo);
            command.Parameters.AddWithValue("@LugarTorneo", objTournamentBE.LugarTorneo);
            command.Parameters.AddWithValue("@FechaInicioTorneo", objTournamentBE.FechaInicioTorneo);
            command.Parameters.AddWithValue("@FechaFinTorneo", objTournamentBE.FechaFinTorneo);
            command.Parameters.AddWithValue("@IdJuego", 1); //hasta desarrollar CRUD de juego
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

        public Boolean DeleteTournament(String TournId)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "EliminarTorneo";

            command.Parameters.AddWithValue("@IdTorneo", TournId);
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

        public TournamentBE ConsultTournament(String TournId)
        {
            TournamentBE objTournamentBE = new TournamentBE();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ConsultarTorneo";

                command.Parameters.AddWithValue("@IdTorneo", TournId);

                connection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();

                    objTournamentBE.IdTorneo = Convert.ToInt32(dataReader["IdTorneo"]);
                    objTournamentBE.NomTorneo = dataReader["NomTorneo"].ToString();
                    objTournamentBE.OrgTorneo = dataReader["OrgTorneo"].ToString();
                    objTournamentBE.PaisTorneo = dataReader["PaisTorneo"].ToString();
                    objTournamentBE.LugarTorneo = dataReader["LugarTorneo"].ToString();
                    objTournamentBE.FechaInicioTorneo = Convert.ToDateTime(dataReader["FechaInicioTorneo"]);
                    objTournamentBE.FechaFinTorneo = Convert.ToDateTime(dataReader["FechaFinTorneo"]);
                    objTournamentBE.IdJuego = Convert.ToInt32(dataReader["IdJuego"]);
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
            return objTournamentBE;
        }
        public DataTable ListTournaments()
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ListarTorneo";

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(command);

                adapter.Fill(dataSet, "Torneo");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dataSet.Tables["Torneo"];
        }
    }
}
