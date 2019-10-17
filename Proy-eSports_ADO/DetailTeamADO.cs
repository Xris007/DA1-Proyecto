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
    public class DetailTeamADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public Boolean InsertDetailTeam(DetailTeamBE objDetailTeamBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertarDetalle_Equipo";

            command.Parameters.AddWithValue("@IdEquipo", objDetailTeamBE.IdEquipo);
            command.Parameters.AddWithValue("@IdTorneo", objDetailTeamBE.IdTorneo);
            command.Parameters.AddWithValue("@Victorias", objDetailTeamBE.Victorias);
            command.Parameters.AddWithValue("@Derrotas", objDetailTeamBE.Derrotas);
            command.Parameters.AddWithValue("@Puesto", objDetailTeamBE.Puesto);


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

        public Boolean UpdateDetailTeam(DetailTeamBE objDetailTeamBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ActualizarDetalle_Equipo";

            command.Parameters.AddWithValue("@IdEquipo", objDetailTeamBE.IdEquipo);
            command.Parameters.AddWithValue("@IdTorneo", objDetailTeamBE.IdTorneo);
            command.Parameters.AddWithValue("@Victorias", objDetailTeamBE.Victorias);
            command.Parameters.AddWithValue("@Derrotas", objDetailTeamBE.Derrotas);
            command.Parameters.AddWithValue("@Puesto", objDetailTeamBE.Puesto);
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

        public Boolean DeleteDetailTeam(DetailTeamBE objDetailTeamBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "EliminarDetalle_Equipo";

            command.Parameters.AddWithValue("@IdEquipo", objDetailTeamBE.IdEquipo);
            command.Parameters.AddWithValue("@IdTorneo", objDetailTeamBE.IdTorneo);
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

        public DetailTeamBE ConsultDetailTeam(DetailTeamBE objDetailTeamBE)
        {
            DetailTeamBE detailTeamBE2 = new DetailTeamBE();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ConsultarDetalle_Equipo";

                command.Parameters.AddWithValue("@IdEquipo", objDetailTeamBE.IdEquipo);
                command.Parameters.AddWithValue("@IdTorneo", objDetailTeamBE.IdTorneo);

                connection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();

                    detailTeamBE2.IdEquipo = Convert.ToInt32(dataReader["IdEquipo"]);
                    detailTeamBE2.IdTorneo = Convert.ToInt32(dataReader["IdTorneo"]);
                    detailTeamBE2.Victorias = Convert.ToInt32(dataReader["Victorias"]);
                    detailTeamBE2.Derrotas = Convert.ToInt32(dataReader["Derrotas"]);
                    detailTeamBE2.Puesto = Convert.ToInt32(dataReader["Puesto"]);
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
            return detailTeamBE2;
        }

        public DataTable ListDetailTeam()
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ListarDetalle_Equipo";

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(command);

                adapter.Fill(dataSet, "DETALLE_EQUIPO");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dataSet.Tables["DETALLE_EQUIPO"];
        }
    }
}
