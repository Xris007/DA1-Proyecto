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
                command.CommandText = "ListarJugador";

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

        public DataTable ListarCapitanes()
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ListarCapitanes";

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

        public DataTable ListarCapitanPorPais(String pais)
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ListarCapitanPorPais";

                command.Parameters.AddWithValue("@pais", pais);

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

        public DataTable ListarJugadorPorPais(String pais)
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ListarJugadorPorPais";

                command.Parameters.AddWithValue("@pais", pais);

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

        public DataTable ListarPaisJugador()
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ListarPaisJugadores";

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

        public Boolean InsertarJugador(JugadorBE jugadorBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertarJugador";

            command.Parameters.AddWithValue("@ApeJugador", jugadorBE.ApeJugador);
            command.Parameters.AddWithValue("@NomJugador", jugadorBE.NomJugador);
            command.Parameters.AddWithValue("@NickJugador", jugadorBE.NickJugador);
            command.Parameters.AddWithValue("@EdadJugador", jugadorBE.EdadJugador);
            command.Parameters.AddWithValue("@PaisJugador", jugadorBE.PaisJugador);
            command.Parameters.AddWithValue("@CapJugador", jugadorBE.CapJugador);
            command.Parameters.AddWithValue("@RolJugador", jugadorBE.RolJugador);
            command.Parameters.AddWithValue("@IdEquipo", jugadorBE.IdEquipo);



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

        public Boolean ActualizarJugador(JugadorBE jugadorBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ActualizarJugador";

            command.Parameters.AddWithValue("@IdJugador", jugadorBE.IdJugador);
            command.Parameters.AddWithValue("@ApeJugador", jugadorBE.ApeJugador);
            command.Parameters.AddWithValue("@NomJugador", jugadorBE.NomJugador);
            command.Parameters.AddWithValue("@NickJugador", jugadorBE.NickJugador);
            command.Parameters.AddWithValue("@EdadJugador", jugadorBE.EdadJugador);
            command.Parameters.AddWithValue("@PaisJugador", jugadorBE.PaisJugador);
            command.Parameters.AddWithValue("@CapJugador", jugadorBE.CapJugador);
            command.Parameters.AddWithValue("@RolJugador", jugadorBE.RolJugador);
            command.Parameters.AddWithValue("@IdEquipo", jugadorBE.IdEquipo);

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

        public Boolean EliminarJugador(String JugadorId)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "EliminarJugador";

            command.Parameters.AddWithValue("@IdJugador", JugadorId);
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

        public JugadorBE ConsultarJugador(String JugadorId)
        {
            JugadorBE jugadorBE = new JugadorBE();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ConsultarJugador";

                command.Parameters.AddWithValue("@IdJugador", JugadorId);

                connection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();

                    jugadorBE.IdJugador= Convert.ToInt32(dataReader["IdJugador"]);
                    jugadorBE.ApeJugador = dataReader["ApeJugador"].ToString();
                    jugadorBE.NomJugador = dataReader["NomJugador"].ToString();
                    jugadorBE.NickJugador = dataReader["NickJugador"].ToString();
                    jugadorBE.EdadJugador = Convert.ToInt32(dataReader["EdadJugador"]);
                    jugadorBE.PaisJugador = dataReader["PaisJugador"].ToString();
                    jugadorBE.CapJugador = Convert.ToChar(dataReader["CapJugador"]);
                    jugadorBE.RolJugador = dataReader["RolJugador"].ToString();
                    jugadorBE.IdEquipo = Convert.ToInt32(dataReader["IdEquipo"]);

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
            return jugadorBE;
        }
        

    }

}