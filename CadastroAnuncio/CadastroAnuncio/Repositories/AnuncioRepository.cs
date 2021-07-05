using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroAnuncio.Repositories
{
    public class AnuncioRepository : DbConnection
    {
        public AnuncioModel Get(int id)
        {
            AnuncioModel anuncioModel = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string sql = $@"SELECT Id, NomeAnuncio, Cliente, DataInicio , DataTermino, InvestimentoPorDia 
                              FROM Anuncio WHERE Id = {id}";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            anuncioModel = new AnuncioModel
                            {
                                Id = reader.GetInt32(0),
                                NomeAnuncio = reader.GetString(1),
                                Cliente = reader.GetString(2),
                                DataInicio = reader.GetDateTime(3),
                                DataTermino = reader.GetDateTime(4),
                                InvestimentoPorDia = reader.GetDouble(5)
                            };
                        }
                    }
                }
            }
            return anuncioModel;
        }        

        public List<AnuncioModel> GetAll()
        {
            List<AnuncioModel> anuncioModel = new List<AnuncioModel>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string sql = $@"SELECT Id, NomeAnuncio, Cliente, DataInicio , DataTermino, InvestimentoPorDia 
                              FROM Anuncio";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            anuncioModel.Add(new AnuncioModel
                            {
                                Id = reader.GetInt32(0),
                                NomeAnuncio = reader.GetString(1),
                                Cliente = reader.GetString(2),
                                DataInicio = reader.GetDateTime(3),
                                DataTermino = reader.GetDateTime(4),
                                InvestimentoPorDia = reader.GetDouble(5)
                            });
                        }
                    }
                }
            }
            return anuncioModel;
        }

        internal List<AnuncioModel> GetAllByFilter(string cliente, DateTime dataInicio, DateTime dataTermino)
        {
            List<AnuncioModel> anuncioModel = new List<AnuncioModel>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string sql = $@"SELECT Id, NomeAnuncio, Cliente, InvestimentoPorDia 
                              FROM Anuncio 
                              WHERE cliente like '%{cliente}%' AND DataInicio >= {dataInicio} AND DataTermino {dataTermino}";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            anuncioModel.Add(new AnuncioModel
                            {
                                Id = reader.GetInt32(0),
                                NomeAnuncio = reader.GetString(1),
                                Cliente = reader.GetString(2),
                                DataInicio = dataInicio,
                                DataTermino = dataTermino,
                                InvestimentoPorDia = reader.GetDouble(5)
                            });
                        }
                    }
                }
            }
            return anuncioModel;
        }

        public int Insert(AnuncioModel anuncio)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string sql = $@"INSERT INTO Anuncio ( NomeAnuncio, Cliente, DataInicio , DataTermino, InvestimentoPorDia)
                                OUTPUT INSERTED.ID VALUES (@NomeAnuncio, @Cliente, @DataInicio, @DataTermino, @InvestimentoPorDia)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@NomeAnuncio", anuncio.NomeAnuncio);
                    command.Parameters.AddWithValue("@Cliente", anuncio.Cliente);
                    command.Parameters.AddWithValue("@DataInicio", anuncio.DataInicio);
                    command.Parameters.AddWithValue("@DataTermino", anuncio.DataTermino);
                    command.Parameters.AddWithValue("@InvestimentoPorDia",anuncio.InvestimentoPorDia);
                    command.CommandType = System.Data.CommandType.Text;
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
