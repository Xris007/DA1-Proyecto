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
    public class HeroeADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;



        public Boolean InsertHero(HeroeBE objHeroeBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "InsertarHeroe";

          
            command.Parameters.AddWithValue("@NomHeroe", objHeroeBE.NomHeroe);
            command.Parameters.AddWithValue("@Atributo", objHeroeBE.Atributo);
            command.Parameters.AddWithValue("@Tipo", objHeroeBE.Tipo);
            command.Parameters.AddWithValue("@Complejidad", objHeroeBE.Complejidad);
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

        public Boolean UpdateHero(HeroeBE objHeroeBE)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ActualizarHeroe";

            command.Parameters.AddWithValue("@IdHeroe", objHeroeBE.IdHeroe);
            command.Parameters.AddWithValue("@NomHeroe", objHeroeBE.NomHeroe);
            command.Parameters.AddWithValue("@Atributo", objHeroeBE.Atributo);
            command.Parameters.AddWithValue("@Tipo", objHeroeBE.Tipo);
            command.Parameters.AddWithValue("@Complejidad", objHeroeBE.Complejidad);
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

        public Boolean DeleteHero(String HeroeId)
        {
            connection.ConnectionString = MiConexion.GetCnx();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "EliminarHeroe";

            command.Parameters.AddWithValue("@IdHeroe", HeroeId);
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

        public HeroeBE ConsultHero(String HeroeId)
        {
            HeroeBE objHeroeBE = new HeroeBE();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ConsultarHeroe";

                command.Parameters.AddWithValue("@IdHeroe", HeroeId);

                connection.Open();
                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();

                    objHeroeBE.IdHeroe = Convert.ToInt32(dataReader["IdHeroe"]);
                    objHeroeBE.NomHeroe = dataReader["NomHeroe"].ToString();
                    objHeroeBE.Atributo = dataReader["Atributo"].ToString();
                    objHeroeBE.Tipo = dataReader["Tipo"].ToString();
                    objHeroeBE.Complejidad = dataReader["Complejidad"].ToString();
                   
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
            return objHeroeBE;
        }





        public DataTable ListarHeroes()
        {
            DataSet dataSet = new DataSet();
            try
            {
                connection.ConnectionString = MiConexion.GetCnx();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "usp_ListarHeroes";

                SqlDataAdapter sqlDataAdapter;
                sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataSet, "Heroe");

                
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dataSet.Tables["Heroe"];
        }
    }
}
