using Campeonato.Dominio;
using Campeonato.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Campeonato.Dominio.util;

namespace Campeonato.RepositorioADO
{
    public class NoticiaDAO 
    {

        public static List<Noticia_Web> ObterNoticia()
        {
            List<Noticia_Web> listaNoticia = new List<Noticia_Web>();

            try
            {
                String SQL = @"SELECT ID, TITULO, NOTICIA, DATA_NOTICIA 
	                                FROM NOTICIA 
                                  WHERE DATA_INATIVACAO IS NULL
                                  ORDER BY DATA_NOTICIA";

                using (SqlConnection conexao = Conexoes.ObterConexaoExclusiva())
                {
                    SqlCommand comando = new SqlCommand(SQL, conexao);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Noticia_Web noticia = new Noticia_Web();
                            if (!reader.IsDBNull(reader.GetOrdinal("ID"))) noticia.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                            if (!reader.IsDBNull(reader.GetOrdinal("TITULO"))) noticia.Titulo = reader.GetString(reader.GetOrdinal("TITULO"));
                            if (!reader.IsDBNull(reader.GetOrdinal("NOTICIA"))) noticia.Noticia = reader.GetString(reader.GetOrdinal("NOTICIA"));
                            if (!reader.IsDBNull(reader.GetOrdinal("DATA_NOTICIA"))) noticia.DataNoticia = reader.GetDateTime(reader.GetOrdinal("DATA_NOTICIA"));

                            listaNoticia.Add(noticia);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaNoticia;
        }

        public static void InserirNoticia(Noticia_Web item)
        {
            try
            {

                String SQL = @"INSERT INTO NOTICIA (TITULO, NOTICIA, DATA_NOTICIA)
	                                        VALUES ('" + item.Titulo + "', '" + item.Noticia + "', GETDATE())";

                using (SqlConnection conexao = Conexoes.ObterConexaoExclusiva())
                {
                    SqlCommand comando = new SqlCommand(SQL, conexao);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RemoveNoticia(Noticia_Web item)
        {
            try
            {
                String SQL = @"UPDATE NOTICIA
                                    SET DATA_INATIVACAO = GETDATE()
                                  WHERE ID = " + item.Id;

                using (SqlConnection conexao = Conexoes.ObterConexaoExclusiva())
                {
                    SqlCommand comando = new SqlCommand(SQL, conexao);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizaNoticia(Noticia_Web item)
        {
            try
            {
                String SQL = @"UPDATE NOTICIA
                                    SET TITULO = '" + item.Titulo + "', NOTICIA = '" + item.Noticia + @"', DATA_NOTICIA = GETDATE()                                         
                                  WHERE ID = " + item.Id;

                using (SqlConnection conexao = Conexoes.ObterConexaoExclusiva())
                {
                    SqlCommand comando = new SqlCommand(SQL, conexao);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
